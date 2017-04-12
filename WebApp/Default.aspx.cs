using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnLogin_Click(object sender, EventArgs e)
    {

        
        string strUsername = txtUsername.Text;
        string strPassword = txtPassword.Text;
        Login newLogin = new Login();
        bool isVerfied = newLogin.LoginUser(strUsername, strPassword);
      
        if (isVerfied)
        {
            Response.Redirect("Main.aspx");
        }
        else
        {
            lblPassincorrect.Visible = true;
            lblPassincorrect.Text = "Username or Password Incorrect";
            lblPassincorrect.Font.Size = 20;
        }
    }

    protected void btnNewUser_Click(object sender, EventArgs e)
    {
        Response.Redirect("Registration.aspx");

    }
}