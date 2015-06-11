using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WfrmOrders : System.Web.UI.Page
{
    DrinkFactory factory = new DrinkFactory();
    List<COrders> order = new List<COrders>();
    static int count = 0;
    static double price = 0.0, subtotal=0.0;
    static string note = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        List<string> list = factory.getAllpname();
        if (!IsPostBack)
        {
            MenuItem itemHome1 = new MenuItem("茶類", "", "", "", "");
            MenuItem itemA1 = new MenuItem(list[0], list[0], "", "", "");
            MenuItem itemB1 = new MenuItem(list[1], list[1], "", "", "");
            MenuItem itemC1 = new MenuItem(list[2], list[2], "", "", "");
            MenuItem itemD1 = new MenuItem(list[3], list[6], "", "", "");
            MenuItem itemE1 = new MenuItem(list[4], list[4], "", "", "");
            MenuItem itemF1 = new MenuItem(list[5], list[5], "", "", "");
            itemHome1.ChildItems.Add(itemA1);
            itemHome1.ChildItems.Add(itemB1);
            itemHome1.ChildItems.Add(itemC1);
            itemHome1.ChildItems.Add(itemD1);
            itemHome1.ChildItems.Add(itemE1);
            itemHome1.ChildItems.Add(itemF1);
            Menu1.Items.Add(itemHome1);

            MenuItem itemHome2 = new MenuItem("特調類", "", "", "", "");
            MenuItem itemA2 = new MenuItem(list[6], list[6], "", "", "");
            MenuItem itemB2 = new MenuItem(list[7], list[7], "", "", "");
            itemHome2.ChildItems.Add(itemA2);
            itemHome2.ChildItems.Add(itemB2);
            Menu2.Items.Add(itemHome2);

            MenuItem itemHome3 = new MenuItem("果汁類", "", "", "", "");
            MenuItem itemA3 = new MenuItem(list[8], list[8], "", "", "");
            MenuItem itemB3 = new MenuItem(list[9], list[9], "", "", "");
            MenuItem itemC3 = new MenuItem(list[10], list[10], "", "", "");
            itemHome3.ChildItems.Add(itemA3);
            itemHome3.ChildItems.Add(itemB3);
            itemHome3.ChildItems.Add(itemC3);
            Menu3.Items.Add(itemHome3);
        }
    }
    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {
        lblPname.Text = (sender as Menu).SelectedValue;
        price = Convert.ToDouble(factory.getPrice(lblPname.Text));
    }
    //btnClick
    private void btn_Click(object sender, EventArgs e)
    {
        lblPname.Text = (sender as Button).Text;
    }
    protected void btn0_Click(object sender, EventArgs e)
    {
        tboxCup.Text += (sender as Button).Text;
        count = Convert.ToInt32(tboxCup.Text);
        subtotal = price * count;
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        tboxCup.Text = "";
        count = 0;
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        (Session["order"] as List<COrders>).Clear();
        refreshGridView();
        tboxCup.Text = "";
        lblPname.Text = "";
        DropDownList1.SelectedIndex = 4;
        DropDownList2.SelectedIndex = 3;
        count = 0;
    }
    protected void btnMiddle_Click(object sender, EventArgs e)
    {
        subtotal += count * 5;
        note = "中杯";
        btnMiddle.Enabled = false;
        btnBig.Enabled = false;
    }
    protected void btnBig_Click(object sender, EventArgs e)
    {
        subtotal += count * 10;
        note = "大杯";
        btnMiddle.Enabled = false;
        btnBig.Enabled = false;
    }
    protected void btnDiscount_Click(object sender, EventArgs e)
    {
        subtotal *= 0.9;
        btnDiscount.Enabled = false;
        note += ",\t打九折";
    }
    protected void btnCommit_Click(object sender, EventArgs e)
    {
        order = Session["order"] as List<COrders>;
        if (order == null)
        {
            order = new List<COrders>();
            Session["order"] = order;
        }
        
        if (lblPname.Text != "" && tboxCup.Text != "")
        {
            order.Add(new COrders() { 產品名稱 = lblPname.Text, 產品單價 = price, 購買數量 = Convert.ToInt32(tboxCup.Text), 小計 = subtotal, 日期 = DateTime.Now.ToString("yyyy/MM/dd"), 備註 = DropDownList1.Text + ",\t" + DropDownList2.Text + ",\t" + note });
            refreshGridView();
            count = 0;
            subtotal = 0;
            tboxCup.Text = "";
            note = "";
            btnDiscount.Enabled = true;
            btnMiddle.Enabled = true;
            btnBig.Enabled = true;
        }
        else
        {
            Response.Write("<Script language='JavaScript'>alert('有未填妥的欄位(飲料種類/數量)');</Script>");
        }
    }
    //method
    private void refreshGridView()
    {
       GridView1.DataSource = Session["order"]; ;
       GridView1.DataBind();
    }
    //Rowdeleting
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        (Session["order"] as List<COrders>).RemoveAt(e.RowIndex);
        refreshGridView();
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