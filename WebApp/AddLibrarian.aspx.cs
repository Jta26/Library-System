using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddLibrarian : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
         bool isLibrarian = Patron.ElevateLibrarian(txtUsername.Text);
        lblLibrarian.Visible = true;
        if (isLibrarian)
        {
            lblLibrarian.Text = "User Elevated to Librarian";
        }
        else
        {
            lblLibrarian.Text = "User Not Elevated";
        }
    }
}