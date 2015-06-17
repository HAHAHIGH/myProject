using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class dbTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     //   HtmlMeta meta = new HtmlMeta();

     //meta.Attributes.Add("http-equiv", "REFRESH");

     //meta.Content = "3; URL=http://www.google.com.tw"; // 前為秒數，後為欲轉向何處

     //this.Header.Controls.Add(meta);

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        COrdersFactory factory = new COrdersFactory();
        COrders order = new COrders() { book_id = 10002, bookPrice = 1200, count = 2, subtotal = 2400, orderDate = Convert.ToDateTime("2015/6/17"), note = "test" };
        factory.insertOrder(order);
    }
}