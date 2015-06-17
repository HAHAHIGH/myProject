using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// CUsersFactory 的摘要描述
/// </summary>
public class CUsersFactory
{
    List<CUsers> userList = new List<CUsers>();
    string connectionString = WebConfigurationManager.OpenWebConfiguration("/booBooking").ConnectionStrings.ConnectionStrings["BookdbConnectionString"].ConnectionString;
    public string message;
    public CUsersFactory()
	{
        loadData();
	}

    private void loadData()
    {
        SqlDataSource sds = new SqlDataSource();
        sds.ConnectionString = connectionString;
        sds.SelectCommand = "dbo.getUser";
        sds.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
        DataView dv = sds.Select(DataSourceSelectArguments.Empty) as DataView;

        if (dv.Count > 0)
        {
            for (int i = 0; i < dv.Count; i++)
            {
                CUsers user = new CUsers();
                user.id = (int)dv.Table.Rows[i]["id"];
                user.account = dv.Table.Rows[i]["account"].ToString();
                user.password = dv.Table.Rows[i]["password"].ToString();
                user.name = dv.Table.Rows[i]["name"].ToString();
                user.phone = dv.Table.Rows[i]["phone"].ToString();
                user.email = dv.Table.Rows[i]["email"].ToString();
                user.address = dv.Table.Rows[i]["address"].ToString();
                userList.Add(user);
            }
        }
    }
    public List<CUsers> getAll()
    {
        return userList;
    }

    public CUsers getByAccount(string account)
    {
        for (int i = 0; i < userList.Count; i++)
        {
            if (userList[i].account == account)
                return userList[i];

        }
        return null;
    }

    public bool loginCheck(string account, string password)
    {
        if (this.getByAccount(account) != null)
        {
            if (password.Equals(this.getByAccount(account).password))
                return true;
            return false;
        }
        return false;
    }
}