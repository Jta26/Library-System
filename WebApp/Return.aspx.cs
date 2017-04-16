using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Return : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string query = Request.QueryString["Token"];
        if (query != LocalData.GetUserToken() || LocalData.GetUserToken() == null)
        {
            Response.Redirect("Default.aspx");
        }
        SqlDataSource1.SelectCommand = "SELECT Books.*, Loans.* FROM  Books INNER JOIN Loans ON Books.CatalogNumber = Loans.CatalogNumber WHERE (Loans.Username='" + LocalData.GetCurrentPatron().Username + "');";
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtSearch.Text))
        {
            Response.Redirect("Return.aspx?Token=" + LocalData.GetUserToken());
        }
        else
        {
            SqlDataSource1.SelectCommand = "SELECT Books.*, Loans.* FROM  Books INNER JOIN Loans ON Books.CatalogNumber = Loans.CatalogNumber WHERE (Loans.Username='" + LocalData.GetCurrentPatron().Username + "') AND ("+ drpSearch.SelectedValue + "='" + txtSearch.Text + "');";
        }
    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        Response.Redirect("Return.aspx?Token=" + LocalData.GetUserToken());
    }

    protected void SqlDataSource1_Load(object sender, EventArgs e)
    {

    }

    protected void ViewCheckoutRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        Control ctlCatalogNumber = e.Item.FindControl("lblCatalogNumber");
        Label lblCatalogNumber = (Label)ctlCatalogNumber;
        Book book = new Book("", "", "", Convert.ToInt32(lblCatalogNumber.Text), "", 0, 0, true, "");
       string returned = Patron.Return(book);
        Response.Write("<script>alert('" + returned + "');</script>");
        Response.Redirect("Return.aspx?Token=" + LocalData.GetUserToken());
        
    }
}