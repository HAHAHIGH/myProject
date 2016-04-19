using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    List<CShoppingCart> shoppingCart = new List<CShoppingCart>();
    CBookFactory bookFactory = new CBookFactory();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["loginName"] != null)
            lblLoginName.Text = Session["loginName"].ToString();
        else
            Response.Redirect("login.aspx");
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        shoppingCart = Session["cart"] as List<CShoppingCart>;
        if (shoppingCart == null)
        {
            shoppingCart = new List<CShoppingCart>();
            Session["cart"] = shoppingCart;
        }
        
        string id = (sender as Button).ToolTip;
        int index = Convert.ToInt32(id.Substring(4,1));
        string count = ((DropDownList)ListView1.Controls[index].FindControl("DropDownList1")).Text;

        CBook book = bookFactory.getById(id);
        string price = book.bookPrice;
        string name = book.bookName;
        string subtotal = (Convert.ToDouble(price) * Convert.ToInt32(count)).ToString();

        shoppingCart.Add(new CShoppingCart() { 書名 = name, 單價 = price, 數量 = count, 小計 = subtotal, 訂購日期 = DateTime.Now.ToString("yyyy/MM/dd") });

        Response.Redirect("shoppingCart.aspx?bid="+id);
    }
}