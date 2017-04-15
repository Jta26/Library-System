using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Checkout : System.Web.UI.Page
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
            Response.Redirect("Checkout.aspx?Token=" + LocalData.GetUserToken());
        }
        else
        {
            SqlDataSource1.SelectCommand = "SELECT * FROM Books WHERE " + drpSearch.SelectedValue + "='" + txtSearch.Text + "';";
        }


    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        Response.Redirect("Checkout.aspx?Token=" + LocalData.GetUserToken());
    }

    protected void bookRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

        Control ctlTitle = e.Item.FindControl("lblTitle");
        Label lblTitle = (Label)ctlTitle;

        Control ctlAuthor = e.Item.FindControl("lblAuthor");
        Label lblAuthor = (Label)ctlAuthor;

        Control ctlPublisher = e.Item.FindControl("lblPublisher");
        Label lblPublisher = (Label)ctlPublisher;

        Control ctlISBN = e.Item.FindControl("lblISBN");
        Label lblISBN = (Label)ctlISBN;

        Control ctlEdition = e.Item.FindControl("lblEdition");
        Label lblEdition = (Label)ctlEdition;

        Control ctlPublicationYear = e.Item.FindControl("lblPublicationYear");
        Label lblPublicationYear = (Label)ctlPublicationYear;

        Control ctlCatalogNumber = e.Item.FindControl("lblCatalogNumber");
        Label lblCatalogNumber = (Label)ctlCatalogNumber;

        Control ctlCopyNumber = e.Item.FindControl("lblCopyNumber");
        Label lblCopyNumber = (Label)ctlCopyNumber;

        Control ctlBookStatus = e.Item.FindControl("lblBookStatus");
        Label lblBookStatus = (Label)ctlBookStatus;

        Control ctlCheckout = e.Item.FindControl("btnCheckout");
        Button btnCheckout = (Button)ctlCheckout;

        string Title = lblTitle.Text;
        string Author = lblAuthor.Text;
        string Publisher = lblPublisher.Text;
        int CatalogNumber = Convert.ToInt32(lblCatalogNumber.Text);
        string ISBN = lblISBN.Text;
        int PublicationYear = Convert.ToInt32(lblPublicationYear.Text);
        int Edition = Convert.ToInt32(lblEdition.Text);
        bool BookStatus = Convert.ToBoolean(lblBookStatus.Text);
        string img = "";
        Book book = new Book( Title,Author,Publisher,CatalogNumber,ISBN,PublicationYear, Edition, BookStatus, img);

        LocalData localdata = new LocalData();
        Patron patron = LocalData.GetCurrentPatron();
        if (BookStatus == false)
        {
            lblBookStatus.Text = patron.Checkout(book).ToString();
            btnCheckout.Text = "Reserve";
            Response.Write("<script>alert(" + lblTitle.Text + " Checked out Successfully')</script>");

        }
        else
        {
            Response.Write("<script>alert('Already Checked Out')</script>");
            //patron.Reserve(book);
        }
        
        
        

    }
    protected void bookRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        foreach (RepeaterItem Item in bookRepeater.Items)
        {

            Control ctlBookStatus = Item.FindControl("lblBookStatus");
            Label lblBookStatus = (Label)ctlBookStatus;

            if (lblBookStatus.Text == "True")
            {
                Control ctlCheckout = Item.FindControl("btnCheckout");
                Button btnCheckout = (Button)ctlCheckout;
                btnCheckout.Text = "Reserve";
            }
        }
    }
}