using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class Book
{
    public string Title;
    public string Author;
    public string Publisher;
    public int CatalogNumber;
    public string ISBN;
    public int PublicationYear;
    public int Edition;
    public int CopyNumber;
    public bool isCheckedOut;


    public Book(string strTitle, string strAuthor, string strPublisher, int intCatalogNumber, string strISBN, int intPublicationYear, int Edition, bool boolIsCheckedOut)
    {
        Title = strTitle;
        Author = strAuthor;
        Publisher = strPublisher;
        CatalogNumber = intCatalogNumber;
        ISBN = strISBN;
        PublicationYear = intPublicationYear;
    }

    
        

}