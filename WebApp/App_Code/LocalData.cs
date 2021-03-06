﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LocalData
/// </summary>
public class LocalData
{
    public static string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

    private static Patron currentPatron;
    private List<Book> bookList = new List<Book>();
    private static string userToken;
 
    public static Patron GetCurrentPatron()
    {
        return currentPatron;
    }
    public static void SetCurrentPatron(Patron patron)
    {
        currentPatron = patron;
    }
    public List<Book> GetBookList()
    {
        return bookList;
    }
    public void FillBookList(Book book)
    {
        bookList.Add(book);
    }
    public static string GetUserToken()
    {
        return userToken;
    }
    public static void SetUserToken(string strUserToken)
    {
        userToken = strUserToken;
    }


}