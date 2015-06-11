using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WfrmDrinksList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnDoc_Click(object sender, EventArgs e)
    {
        Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();   //在office软件中打开
        word.Visible = true;
        string filename = Server.MapPath("~/doc/help.doc");
        word.Documents.Open(filename);
        word = null;
        Response.Write("<Script language='JavaScript'>alert('您已開啟說明文件)');</Script>");
    }
}