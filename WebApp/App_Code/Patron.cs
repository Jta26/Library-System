﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Patron
/// </summary>
public class Patron
{
    //Patron Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string PhoneNumber { get; set; }
    public int UserType { get; set; }
    public string ProgramOffice { get; set; }
    public string CreditPhone { get; set; }

    public bool Librarian;

    public Patron()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public void SetUserData(string strFirstName, string strLastName, string strUsername, string strAddress, string strCity, string strState, string strZipCode, string strPhoneNumber, int intUserType, string strProgramOffice, string strCreditPhone)
    {
        FirstName = strFirstName;
        LastName = strLastName;
        Username = strUsername;
        Address = strAddress;
        City = strCity;
        State = strState;
        ZipCode = strZipCode;
        PhoneNumber = strPhoneNumber;
        UserType = intUserType;
        ProgramOffice = strProgramOffice;
        CreditPhone = strCreditPhone;
    }
    public bool IsLibrarian()
    {
        return Librarian;
    }
    public static bool AddPatron(string strFirstname, string strLastname, string strUsername, string strPassword, string strAddress, string strCity, string strState, string strZipCode, string strPhoneNumbers, int intUserType, string strProgramOffice, string strCreditPhone)
    {
        

        SqlConnection conn = new SqlConnection(LocalData.ConnectionString);

        string query = "EXEC InsertUsers @firstname, @lastname, @username, @password, @phonenumber, @address, @city, @zipcode, @usertype, @programoffice, @creditphone";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@firstname", strFirstname);
        cmd.Parameters.AddWithValue("@lastname", strLastname);
        cmd.Parameters.AddWithValue("@username", strUsername);
        cmd.Parameters.AddWithValue("@password", strPassword);
        cmd.Parameters.AddWithValue("@phonenumber", strPhoneNumbers);
        cmd.Parameters.AddWithValue("@address", strAddress);
        cmd.Parameters.AddWithValue("@city", strCity);
        cmd.Parameters.AddWithValue("@zipcode", strZipCode);
        cmd.Parameters.AddWithValue("@usertype", intUserType);
        cmd.Parameters.AddWithValue("@programoffice", strProgramOffice);
        cmd.Parameters.AddWithValue("@creditphone", strCreditPhone);

        int intReturn;

        conn.Open();
        intReturn = cmd.ExecuteNonQuery();
        conn.Close();
        return true;
    }
    public static bool AddBook(Book book)
    {
        SqlConnection conn = new SqlConnection(LocalData.ConnectionString);
        string query = "INSERT INTO Books (Title, Author, Publisher, ISBN, Edition, PublicationYear, CopyNumber, BookStatus) VALUES (@catalognumber, @title, @author, @publisher, @isbn, @edition, @publicationyear, @copynumber, @bookstatus)";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@title", book.Title);
        cmd.Parameters.AddWithValue("@author", book.Author);
        cmd.Parameters.AddWithValue("@publisher", book.Publisher);
        cmd.Parameters.AddWithValue("@isbn", book.ISBN);
        cmd.Parameters.AddWithValue("@edition", book.Edition);
        cmd.Parameters.AddWithValue("@publicationyear", book.PublicationYear);
        cmd.Parameters.AddWithValue("@copynumber", book.CopyNumber);
        cmd.Parameters.AddWithValue("@bookstatus", book.isCheckedOut);

        int intReturn;
        conn.Open();
        intReturn = cmd.ExecuteNonQuery();
        conn.Close();
        return true;
    }
    public bool Checkout(Book book)
    {
        book.isCheckedOut = true;
        DateTime currentTime = DateTime.Now;
        DateTime dueDate = DateTime.Now.AddDays(14);
        SqlConnection conn = new SqlConnection(LocalData.ConnectionString);
        string query = "Update Books SET BookStatus=@status WHERE CatalogNumber=@catalognumber";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Status", book.isCheckedOut);
        cmd.Parameters.AddWithValue("@catalognumber", book.CatalogNumber);
        string query2 = "INSERT INTO Loans (Username, CatalogNumber, DueDate, DateCheckedOut) VALUES (@username, @catalognumber, @duedate, @datecheckedout)";
        SqlCommand cmd2 = new SqlCommand(query2, conn);
        cmd2.Parameters.AddWithValue("@username", Username);
        cmd2.Parameters.AddWithValue("@catalognumber", book.CatalogNumber);
        cmd2.Parameters.AddWithValue("@duedate", dueDate);
        cmd2.Parameters.AddWithValue("@datecheckedout", currentTime);


        conn.Open();
        cmd.ExecuteNonQuery();
        try
        {
            cmd2.ExecuteNonQuery();
        }
        catch
        {

        }
        
        conn.Close();


        
        return true;
    }
    public static bool Return(Book book)
    {
        return true;
    }
    public void Logout()
    {
        LocalData.SetCurrentPatron(null);
        FirstName = null;
        LastName = null;
        Username = null;
        Address = null;
        City = null;
        State = null;
        ZipCode = null;
        PhoneNumber = null;
        UserType = 4;
        ProgramOffice = null;
        CreditPhone = null;
        Librarian = false;
    }

}