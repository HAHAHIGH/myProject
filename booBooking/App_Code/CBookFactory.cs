using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// CBookFactory 的摘要描述
/// </summary>
public class CBookFactory
{
    List<CBook> bookList = new List<CBook>();
    string connectionString = WebConfigurationManager.OpenWebConfiguration("/booBooking").ConnectionStrings.ConnectionStrings["BookdbConnectionString"].ConnectionString;
    public CBookFactory()
	{
        loadData();
	}

    private void loadData()
    {
        SqlDataSource sds = new SqlDataSource();
        sds.ConnectionString = connectionString;
        sds.SelectCommand = "dbo.getbook";
        sds.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
        DataView dv = sds.Select(DataSourceSelectArguments.Empty) as DataView;

        if (dv.Count > 0)
        {
            for (int i = 0; i < dv.Count; i++)
            {
                CBook book = new CBook();
                book.id = (int)dv.Table.Rows[i]["book_id"];
                book.bookName = dv.Table.Rows[i]["bookName"].ToString();
                book.bookPrice = dv.Table.Rows[i]["bookPrice"].ToString();
                book.bookPhoto = dv.Table.Rows[i]["bookPhoto"].ToString();
                bookList.Add(book);
            }
        }
    }

    public List<CBook> getAll()
    {
        return bookList;
    }
}