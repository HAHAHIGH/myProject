using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class check : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<CShoppingCart> cartList = Session["cart"] as List<CShoppingCart>;
            CUsersFactory userFactory = new CUsersFactory();
            double dblPay = 0;
            int count = 0;
            foreach (CShoppingCart c in cartList)
            {
                dblPay += Convert.ToDouble(c.小計);
                count += Convert.ToInt32(c.數量);
            }
            dblPay += 100;
            lblTotal.Text = dblPay.ToString() + "元(含運費100)";
            lblTotalCont.Text = count.ToString() + "本";

            string account = Session["loginName"].ToString();
            CUsers user = userFactory.getByAccount(account);
            tboxName1.Text = user.name;
            tboxPhone1.Text = user.phone;
            tboxEmail1.Text = user.email;
            tboxAddress1.Text = user.address;
            tboxName2.Text = user.name;
            tboxPhone2.Text = user.phone;
            tboxEmail2.Text = user.email;
            tboxAddress2.Text = user.address;
        }
    }
    protected void btnCheck_Click(object sender, EventArgs e)
    {
        List<CShoppingCart> cartList = Session["cart"] as List<CShoppingCart>;
        CBookFactory bookfactory = new CBookFactory();
        COrdersFactory orderfactory = new COrdersFactory();
        int bookId, bookPrice, count, subtotal;
        DateTime orderDate;
        string note;
        try
        {
            foreach (CShoppingCart c in cartList)
            {
                bookId = bookfactory.getbookId(c.書名);
                bookPrice = Convert.ToInt32(c.單價);
                count = Convert.ToInt32(c.數量);
                subtotal = Convert.ToInt32(c.小計);
                orderDate = Convert.ToDateTime(c.訂購日期);
                note = "收件人姓名" + tboxName1.Text + "電話" + tboxPhone1.Text + "地址" + tboxAddress1.Text + "email" + tboxEmail1.Text +
                    "信用卡號碼" + tboxCardID.Text + "信用卡有效日期" + tboxCardMonth.Text + tboxCardYear.Text + "信用卡安全碼" + tboxSecurityID.Text;
                COrders order = new COrders() { book_id = bookId, bookPrice = bookPrice, count = count, subtotal = subtotal, orderDate = orderDate, note = note };
                orderfactory.insertOrder(order);
            }
        }
        catch (Exception)
        {
            Response.Write("<script>alert('" + orderfactory.message + "')</script>");
        }
        (Session["cart"] as List<CShoppingCart>).Clear();
        Response.Write("<script>alert('" + orderfactory.message + "')</script>");
        Response.Redirect("redirect.aspx");
    }
}