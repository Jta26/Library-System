using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddorRemove : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string query = Request.QueryString["Token"];
        if (query != LocalData.GetUserToken() || LocalData.GetUserToken() == null)
        {
            Response.Redirect("Default.aspx");
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtSearch.Text))
        {
            Response.Redirect("AddorRemove.aspx?Token=" + LocalData.GetUserToken());
        }
        else
        {
            SqlDataSource1.SelectCommand = "SELECT * FROM Books WHERE " + drpSearch.SelectedValue + "='" + txtSearch.Text + "';";
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string Title = txtTitle.Text;
        string Author = txtAuthor.Text;
        string Publisher = txtPublisher.Text;
        int CatalogNumber = 0;
        string ISBN = txtISBN.Text;
        int PublicationYear = Convert.ToInt32(txtPubYear.Text);
        int Edition = Convert.ToInt32(txtEdition.Text);
        bool isCheckedOut = false;
        string Image = txtURL.Text;
        Book book = new Book(Title, Author, Publisher, CatalogNumber, ISBN, PublicationYear, Edition, isCheckedOut,Image);
        bool isAdded = Patron.AddBook(book);
        if (isAdded)
        {
            Response.Redirect("AddorRemove.aspx?Token=" + LocalData.GetUserToken());
            Response.Write("<script>alert('Book Added Successfully')</script>");    
        }
        else
        {
            Response.Write("<script>alert('Error: Not Added')</script>");
        }
    }

    protected void bookRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        Control ctlCatalogNumber = e.Item.FindControl("lblCatalogNumber");
        Label lblCatalogNumber = (Label)ctlCatalogNumber;
        int CatalogNumber = Convert.ToInt32(lblCatalogNumber.Text);
        Book book = new Book("","","",CatalogNumber,"",0,0,false,"");
        Patron.RemoveBook(book);
        Response.Redirect("AddorRemove.aspx?Token=" + LocalData.GetUserToken());
    }
}