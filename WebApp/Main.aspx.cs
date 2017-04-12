﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Main : System.Web.UI.Page
{
    Patron patron;
    LocalData localdata = new LocalData();

    protected void Page_Load(object sender, EventArgs e)
    {
        
        patron = localdata.GetCurrentPatron();
        if ( patron == null)
        {
            Response.Write("<script>alert('Not Logged In');</script>");
            Response.Redirect("Default.aspx");
        }
        if (patron.IsLibrarian())
        {
            imgAddRemove.ImageUrl = "https://cdn1.iconfinder.com/data/icons/education-solid-icons-vol-4/48/156-512.png";
            pnlbtn.Visible = true;
            lblAddRemove.Text = "Add/Remove Books";
        } 


        lblWelcome.Text = "Welcome" + " " + patron.FirstName + " " + patron.LastName;

            
        
    }

    protected void imgLogout_Click(object sender, ImageClickEventArgs e)
    {
        patron.Logout();
        Response.Redirect("Default.aspx");
    }

    protected void imgSettings_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("AccountSettings.aspx");
    }

    protected void imgCheckout_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Checkout.aspx");
    }

    protected void imgAddRemove_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("AddorRemove.aspx");
    }
}