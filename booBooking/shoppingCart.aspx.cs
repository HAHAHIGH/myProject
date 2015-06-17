using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shoppingCart : System.Web.UI.Page
{
    List<CShoppingCart> cart = new List<CShoppingCart>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) 
        {
            cart = Session["cart"] as List<CShoppingCart>;
            GridView2.DataSource = cart;
            GridView2.DataBind();
        } 
    }
    protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        (Session["cart"] as List<CShoppingCart>).RemoveAt(e.RowIndex);
        refreshGridView();
    }
    private void refreshGridView()
    {
        GridView2.DataSource = Session["cart"];
        GridView2.DataBind();
    }
    protected void btnCheck_Click(object sender, EventArgs e)
    {
        Response.Redirect("check.aspx");
    }
    
}