using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LocalData
/// </summary>
public class LocalData
{
    public static string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Joel\\Box Sync\\School\\Uni\\Semester 4\\Systems Analysis and Design\\Project\\WebApp\\App_Data\\SysAnalysisDb.mdf';Integrated Security=True";
    private static Patron currentPatron;
    private List<Book> bookList = new List<Book>();
 
    public Patron GetCurrentPatron()
    {
        return currentPatron;
    }
    public void SetCurrentPatron(Patron patron)
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

}