using System;
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
        string query = "INSERT INTO Books (imgURl, Title, Author, Publisher, ISBN, Edition, PublicationYear, CopyNumber, BookStatus) VALUES (@imgurl, @title, @author, @publisher, @isbn, @edition, @publicationyear, @copynumber, @bookstatus)";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@imgurl", book.ImageUrl);
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
    public static bool RemoveBook(Book book)
    {
        SqlConnection conn = new SqlConnection(LocalData.ConnectionString);
        string query = "DELETE FROM Books WHERE CatalogNumber=@catalognumber";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@catalognumber", book.CatalogNumber);
        conn.Open();
        cmd.ExecuteNonQuery();
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
    public static string Return(Book book)
    {
        book.isCheckedOut = false;
        SqlConnection conn = new SqlConnection(LocalData.ConnectionString);
        string query = "Update Books SET BookStatus=@status WHERE CatalogNumber=@catalognumber; DELETE FROM Loans Where CatalogNumber=@catalognumber2 AND Username=@username";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@status", book.isCheckedOut);
        cmd.Parameters.AddWithValue("@catalognumber", book.CatalogNumber);
        cmd.Parameters.AddWithValue("@catalognumber2", book.CatalogNumber);
        cmd.Parameters.AddWithValue("@username", LocalData.GetCurrentPatron().Username);
        string query2 = "SELECT Username, DueDate FROM Loans Where CatalogNumber=@catalognumber3;";
        SqlConnection connDueDate = new SqlConnection(LocalData.ConnectionString);
        SqlCommand cmdDueDate = new SqlCommand(query2, connDueDate);
        cmdDueDate.Parameters.AddWithValue("@catalognumber3", book.CatalogNumber);
        connDueDate.Open();
        SqlDataReader dr = cmdDueDate.ExecuteReader();
        DateTime now = DateTime.Now;
        while (dr.Read())
        {
            DateTime dueDate = Convert.ToDateTime(dr["DueDate"]);
            if (dueDate > now)
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                connDueDate.Close();
                return "Book Returned, Overdue Charge $1.00";
                
            }
            else
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                connDueDate.Close();
                return "Book Returned Successfully";
            }
        }
        connDueDate.Close();
        return "Error: Not Returned";
        
    }
    public static bool ElevateLibrarian(string strUsername)
    {
        int librarian = 3;
        SqlConnection conn = new SqlConnection(LocalData.ConnectionString);
        string query = "UPDATE UserType SET UserType=@type WHERE Id = (SELECT Id FROM USERS WHERE UPPER(Username)=@username)";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@type", librarian);
        cmd.Parameters.AddWithValue("@username", strUsername.ToUpper());
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
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