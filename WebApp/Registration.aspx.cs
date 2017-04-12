using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmitRegister_Click(object sender, EventArgs e)
    {
        int usertype;
        if (drpUserSelect.SelectedIndex == 0)
        {
            usertype = 0;
        }
        else
        {
            usertype = 1;
        }

         
        bool RegisterCheck = Patron.AddPatron(txtPickFirstName.Text, txtPickLastName.Text, txtPickUsername.Text, txtPickPassword.Text, txtAddress.Text, txtCity.Text, DropDownListState.SelectedItem.ToString(), txtZipCode.Text, txtPhone.Text, usertype, txtProgram.Text, txtCredit.Text);

        if (RegisterCheck)
        {
            Response.Redirect("Default.aspx");
        }
        
    }

    protected void drpUserSelect_SelectedIndexChanged(object sender, EventArgs e)
    {
        

    }
}