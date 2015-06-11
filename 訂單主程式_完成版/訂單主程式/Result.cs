using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 訂單主程式
{
    public partial class Result : Form
    {
        SqlConnectionStringBuilder scsb;
        public Result()
        {
            InitializeComponent();
        }
        public Form2 f2 = null;
        private void Result_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"NTHIGH\SQLEXPRESS";
            scsb.InitialCatalog = "Mid";
            scsb.IntegratedSecurity = true;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = scsb.ToString();
            cn.Open();
            DataSet ds2 = new DataSet();
            string OD = "select * from ODetail where orderid = '" + f2.orderid + "'";
            SqlDataAdapter odDa2 = new SqlDataAdapter(OD, cn);
            odDa2.Fill(ds2, "OrderDetail");
            dataGridView1.DataSource = ds2;
            dataGridView1.DataMember = "OrderDetail";
            string selectshopcmd = "select * from shop where shopName = '" + f2.cbox店名.Text + "'";
            SqlCommand shopcmd = new SqlCommand(selectshopcmd, cn);
            SqlDataReader shopdr = shopcmd.ExecuteReader();
            if (shopdr.Read())
            {
                string shopid = shopdr["shopid"].ToString();
                SqlDataAdapter daproduct = new SqlDataAdapter("select * from products where shopid = '" + shopid + "'", cn);
                shopdr.Close();
                string pPhone = "select * from shop where shopid = '" + shopid + "'";
                SqlCommand pPhonecmd = new SqlCommand(pPhone, cn);
                SqlDataReader pPhonedr = pPhonecmd.ExecuteReader();
                if (pPhonedr.Read())
                {
                    string phone = pPhonedr["tel"].ToString();
                    pPhonedr.Close();
                    lblPhone.Text = phone;
                }
            }
            
           
            lbl班級.Text = f2.lblClass.Text;            
            lbl店名.Text = f2.cbox店名.Text;
            lbl總金額.Text = f2.tbox總金額.Text+"元";
            lbl總數量.Text = f2.tbox總數量.Text+" 個";
            lblUsr2.Text = f2.lblUser.Text;
            lblUsr.Visible = false;
            lblUsr.Text = f2.lblUser.Text;
            
            cn.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)//無法訂購
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = scsb.ToString();
            cn.Open();
            string selectOrderid = "select Max(orderid) from Orders";
            SqlCommand selectOidcmd = new SqlCommand(selectOrderid,cn);            
            string orderid = selectOidcmd.ExecuteScalar().ToString();                
            string deleteOrderDetail = "delete from ODetail where  orderid = @orderid";
            SqlCommand deleteODcmd = new SqlCommand(deleteOrderDetail,cn);
            deleteODcmd.Parameters.AddWithValue("@orderid",orderid);
            deleteODcmd.ExecuteNonQuery();
            string deleteOrders = "delete from Orders where  orderid = @orderid ";
            SqlCommand deleteOScmd = new SqlCommand(deleteOrders,cn);
            deleteOScmd.Parameters.AddWithValue("@orderid",orderid);
            deleteOScmd.ExecuteNonQuery();            
            cn.Close();
            returnResult R2 = new returnResult();
            R2.r1 = this;
            this.Hide();
            R2.ShowDialog();            
            
            
        }

        private void btn訂購完成_Click(object sender, EventArgs e)
        {
            MessageBox.Show("訂購成功!!","訂購結果",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
