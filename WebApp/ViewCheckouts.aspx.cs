using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ViewCheckouts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string query = Request.QueryString["Token"];
        if (query != LocalData.GetUserToken() || LocalData.GetUserToken() == null)
        {
            Response.Redirect("Default.aspx");
        }

    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewCheckouts.aspx?Token=" + LocalData.GetUserToken());
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtSearch.Text))
        {
            Response.Redirect("ViewCheckouts.aspx?Token=" + LocalData.GetUserToken());
        }
        else
        {
            SqlDataSource1.SelectCommand = "SELECT Books.*, Loans.* FROM  Books INNER JOIN Loans ON Books.CatalogNumber = Loans.CatalogNumber WHERE (" + drpSearch.SelectedValue + " ='" + txtSearch.Text + "');";
        }
    }

    protected void btnOverDue_Click(object sender, EventArgs e)
    {
        SqlDataSource1.SelectCommand = "SELECT Books.*, Loans.* FROM  Books INNER JOIN Loans ON Books.CatalogNumber = Loans.CatalogNumber WHERE (DueDate < '"+ DateTime.Now +"');";
    }
}