﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    CUsersFactory factory = new CUsersFactory();
    string loginPassword = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["loginName"] = null;
        if (!IsPostBack) { lblMessage.Visible = false;}
        
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Session["loginName"] = Request.Form["loginName"].ToString();
        loginPassword = Request.Form["Passwd"].ToString();
        
        if (factory.loginCheck(Request.Form["loginName"].ToString(), loginPassword))
        {
            Response.Redirect("index.aspx");
        }
        else
        {
            divLog.Visible = true;
            lblMessage.Visible = true;
        }
    }
}