using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;


//Login Class
//Checks if the entered username and password are equal to a ID in the database, if so, Logs the user in under that data.
public class Login
{
    string connection;

    public Login()
    {
        connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Joel\\Box Sync\\School\\Uni\\Semester 4\\Systems Analysis and Design\\Project\\WebApp\\App_Data\\SysAnalysisDb.mdf';Integrated Security=True";
    }

    public bool LoginUser(string strUsername, string strPassword)
    {
        //Database Connection Here
        //Check strUsername & strPassword
        //TODO
        SqlConnection conn = new SqlConnection(connection);


        string query = "SELECT Username, Password, FirstName, LastName, PhoneNumber, Address, City, ZipCode, UserType, [Program/Office], [Credit/Phone] FROM Users INNER JOIN UserAddress ON Users.Id = UserAddress.id INNER JOIN UserType ON UserAddress.id = UserType.id WHERE Username = @Username;";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@username", strUsername.ToUpper());

        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        string drUsername = null;
        string drPassword = null;
        string drFirstName = null;
        string drLastName = null;
        string drPhoneNumber = null;
        string drAddress = null;
        string drCity = null;
        string drZipCode = null;
        int drUserType = 4;
        string drProgramOffice = null;
        string drCreditPhone = null;
        while (dr.Read())
        {
            drUsername = dr["Username"].ToString();
            drPassword = dr["Password"].ToString();
            drFirstName = dr["FirstName"].ToString();
            drLastName = dr["LastName"].ToString();
            drPhoneNumber = dr["PhoneNumber"].ToString();
            drAddress = dr["Address"].ToString();
            drCity = dr["City"].ToString();
            drZipCode = dr["ZipCode"].ToString();
            drUserType = Convert.ToInt32(dr["UserType"]);
            drProgramOffice = dr["Program/Office"].ToString();
            drCreditPhone = dr["Credit/Phone"].ToString();



        }
        conn.Close();
        if (strUsername.ToUpper() == drUsername.ToUpper() && strPassword == drPassword)
        {
            Patron patron = new Patron()
            {
                Username = drUsername,
                FirstName = drFirstName,
                LastName = drLastName,
                PhoneNumber = drPhoneNumber,
                Address = drAddress,
                City = drCity,
                ZipCode = drZipCode,
                UserType = drUserType,
                ProgramOffice = drProgramOffice,
                CreditPhone = drCreditPhone
            };
            LocalData localdata = new LocalData();
            localdata.SetCurrentPatron(patron);
            if (drUserType == 3)
            {
                patron.Librarian = true;
            }
                

            return true;
        }
        else
        {
            return false;
        }
    }
    
}