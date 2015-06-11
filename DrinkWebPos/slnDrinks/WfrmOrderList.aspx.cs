using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WfrmOrderList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) 
        {
            List<COrders> list = Session["order"] as List<COrders>;
            GridView1.DataSource = list;
            GridView1.DataBind();
            double dblPay = 0;
            int count = 0;
            foreach (COrders o in list) 
            {
                dblPay += o.小計;
                count += o.購買數量;
            }
            lblTotal.Text = dblPay.ToString("###,###,##0");
            lblTotalCount.Text = count.ToString();
            list.Clear();
        }
        
    }
    protected void btnReturn_Click(object sender, EventArgs e)
    {
        btnEnd.Enabled = true;
        double pay, otzuri;
        try
        {
            pay = Convert.ToDouble(tboxPay.Text);
            otzuri = pay - Convert.ToDouble(lblTotal.Text);
            tboxReturn.Text = otzuri.ToString();
        }
        catch 
        {
            otzuri = 0;
            tboxReturn.Text = "";
        }
    }
    protected void btnEnd_Click(object sender, EventArgs e)
    {
        (Session["order"] as List<COrders>).Clear();
    }
}