using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI.WebControls;

/// <summary>
/// COrdersFactory 的摘要描述
/// </summary>
public class COrdersFactory
{
    List<COrders> bookList = new List<COrders>();
    string connectionString = WebConfigurationManager.OpenWebConfiguration("/booBooking").ConnectionStrings.ConnectionStrings["BookdbConnectionString"].ConnectionString;
    public string message;
    public COrdersFactory()
	{
        
	}

    public void insertOrder(COrders order)
    {
        try
        {
            SqlDataSource sds = new SqlDataSource();
            sds.ConnectionString = connectionString;
            sds.InsertCommand = "dbo.insertOrders";
            sds.InsertCommandType = SqlDataSourceCommandType.StoredProcedure;
            sds.InsertParameters.Add(new Parameter("book_id", DbType.Int32, order.book_id.ToString()));
            sds.InsertParameters.Add(new Parameter("bookPrice", DbType.Int32, order.bookPrice.ToString()));
            sds.InsertParameters.Add(new Parameter("count", DbType.Int32, order.count.ToString()));
            sds.InsertParameters.Add(new Parameter("subtotal", DbType.Int32, order.subtotal.ToString()));
            sds.InsertParameters.Add(new Parameter("orderDate", DbType.DateTime, order.orderDate.ToString()));
            sds.InsertParameters.Add(new Parameter("note", DbType.String, order.note));
            sds.Insert();

            message = "insert success";
        }
        catch (Exception ex)
        {
            message = ex.Message;
        }
    }
}