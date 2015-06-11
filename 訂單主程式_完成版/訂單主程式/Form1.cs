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
    
    public partial class Form2 : Form
    {
        SqlConnectionStringBuilder scsb;        
        public int count = -1;
        public double  qTotal = 0.0, mTotal = 0.0;
        public String shopid = "";
        public string classno = "";
        public string orderid = "";
        public Form2()
        {
            InitializeComponent();
        }
        public Login_Form f1 = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"NTHIGH\SQLEXPRESS";
            scsb.InitialCatalog = "Mid";
            scsb.IntegratedSecurity = true;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = scsb.ToString();
            cn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter daShop = new SqlDataAdapter("select * from shop", cn);
            SqlDataAdapter daClass = new SqlDataAdapter("select * from class", cn);

            daShop.Fill(ds, "shop");
            daClass.Fill(ds, "class");
            cbox店名.DataSource = ds.Tables["shop"];
            cbox店名.DisplayMember = "shopName";
            
            try
            {
                string User = "select * from Username where Username = '" + f1.tboxUsername.Text + "'";
                SqlCommand selectUser = new SqlCommand(User, cn);
                SqlDataReader selectUserdr = selectUser.ExecuteReader();
                if (selectUserdr.Read())
                {
                    string stuname = selectUserdr["stuname"].ToString();
                    classno = selectUserdr["classno"].ToString();
                    selectUserdr.Close();
                    lblUser.Text = stuname;
                    lblClass.Text = classno;
                }
            }
                        
            catch(Exception){
               
            }
            string name = "select * from student where classno = '" + classno + "'";
            SqlDataAdapter daName = new SqlDataAdapter(name, cn);
            daName.Fill(ds, "student");
            cboxName.DataSource = ds.Tables["student"];
            cboxName.DisplayMember = "stu_name";
            cn.Close();
              lbl現在時間.Text = String.Format("{0}", DateTime.Now);
              timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e){
            lbl現在時間.Text = String.Format("{0}", DateTime.Now);       }
        private void button1_Click(object sender, EventArgs e)//確定送出
        {

            Result r1 = new Result();
            r1.f2 = this;
            r1.ShowDialog();
            this.Hide();            
        }

        private void cbox店名_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchshopname = cbox店名.Text;
            getName(searchshopname);     
        }

        private void cbox店名_DropDown(object sender, EventArgs e)
        {
            MessageBox.Show("一旦選定後將不能更改!!","通知",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            cbox店名.Enabled = false;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = scsb.ToString();
            cn.Open();
            DataSet ds1 = new DataSet();
            if (cbox店名.Text != "")
            {
                DateTime orderdate = Convert.ToDateTime(lbl現在時間.Text);
                string searchshopname = cbox店名.Text;
                string selectshopcmd = "select * from shop where shopName = '" + searchshopname + "'";
                SqlCommand shopcmd = new SqlCommand(selectshopcmd, cn);
                SqlDataReader shopdr = shopcmd.ExecuteReader();
                if (shopdr.Read())
                {
                    String shopid = shopdr["shopid"].ToString();
                    shopdr.Close();
                    string insertOrderscmd = "Insert into Orders(classno,shopid,OrderDate) Values(@classno,@shopid,@OrderDate)";
                    SqlCommand insertshopcmd = new SqlCommand(insertOrderscmd, cn);
                    insertshopcmd.Parameters.AddWithValue("@classno", lblClass.Text);
                    insertshopcmd.Parameters.AddWithValue("@shopid", shopid);
                    insertshopcmd.Parameters.AddWithValue("@OrderDate", orderdate);
                    SqlDataReader insertOrders = insertshopcmd.ExecuteReader();
                    insertOrders.Close();
                }
            }
            string orderidcmd = "select top 1 * from Orders order by 1 desc ";
            SqlCommand selectorderid = new SqlCommand(orderidcmd, cn);
            SqlDataReader selectorderiddr = selectorderid.ExecuteReader();
            if (selectorderiddr.Read())
            {
                orderid = selectorderiddr["orderid"].ToString();
                selectorderiddr.Close();
                string OD = "select * from ODetail where orderid = '" + orderid + "'";
                SqlDataAdapter odDa = new SqlDataAdapter(OD, cn);
                odDa.Fill(ds1, "OrderDetail");
                dataGridView1.DataSource = ds1;
                dataGridView1.DataMember = "OrderDetail";
            }
        }
        public void getName(String s)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = scsb.ToString();
            cn.Open();
            
            DataSet ds = new DataSet();
            string selectshopcmd = "select * from shop where shopName = '" + s + "'";
            SqlCommand shopcmd = new SqlCommand(selectshopcmd, cn);
            SqlDataReader shopdr = shopcmd.ExecuteReader();
            if (shopdr.Read())
            {
                shopid = shopdr["shopid"].ToString();
                SqlDataAdapter daproduct = new SqlDataAdapter("select * from products where shopid = '" + shopid + "'", cn);
                shopdr.Close();
                
                daproduct.Fill(ds, "product" );
                cbox品名.DataSource = ds.Tables["product" ];
                cbox品名.DisplayMember = "productName";
                
            }
            cn.Close();
        }

        private void cbox品名_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = scsb.ToString();
            cn.Open();
            string searchPrice = cbox品名.Text;
            string selectPrice = "select * from products where productName = '" + searchPrice + "'";
            SqlCommand selectPricecmd = new SqlCommand(selectPrice, cn);
            SqlDataReader Pricedr = selectPricecmd.ExecuteReader();
            if (Pricedr.Read())
            {
                string price = Pricedr["price"].ToString();
                Pricedr.Close();
                tbox單價1.Text = price;

            }
            
            cn.Close();
        }

        private void cbox數量_SelectedIndexChanged(object sender, EventArgs e)
        {
            double q, subtotal = 0.0;
            double p;
            q = Convert.ToDouble(cbox數量.Text);
            p = Convert.ToDouble(tbox單價1.Text);
            subtotal = q * p;
            tbox小計1.Text = Convert.ToString(subtotal);
        }

        private void btn確認_Click(object sender, EventArgs e)
        {            
            try
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = scsb.ToString();
                    cn.Open();
                    string insert = "Insert into ODetail Values(@orderid,@姓名,@品名,@單價,@數量,@小計)";
                    SqlCommand insertcmd = new SqlCommand(insert, cn);
                    insertcmd.Parameters.AddWithValue("@orderid", orderid);
                    insertcmd.Parameters.AddWithValue("@姓名", cboxName.Text);
                    insertcmd.Parameters.AddWithValue("@品名", cbox品名.Text);
                    insertcmd.Parameters.AddWithValue("@單價", tbox單價1.Text);
                    insertcmd.Parameters.AddWithValue("@數量", cbox數量.Text);
                    insertcmd.Parameters.AddWithValue("@小計", tbox小計1.Text);
                    insertcmd.ExecuteNonQuery();
                    cn.Close();
                }
                SqlConnection cn1 = new SqlConnection();
                cn1.ConnectionString = scsb.ToString();
                cn1.Open();
                DataSet ds1 = new DataSet();
                string OD = "select * from ODetail where orderid = '" + orderid + "'";
                SqlDataAdapter odDa = new SqlDataAdapter(OD, cn1);
                odDa.Fill(ds1, "OrderDetail");
                dataGridView1.DataSource = ds1;
                dataGridView1.DataMember = "OrderDetail";
                cn1.Close();
                odDa.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            qTotal += Convert.ToDouble(cbox數量.Text);
            mTotal += Convert.ToDouble(tbox小計1.Text);

            tbox總數量.Text = qTotal + "";
            tbox總金額.Text = mTotal + "";
            
        }
        
        public void showData() 
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = scsb.ToString();
            cn.Open();
            DataSet ds1 = new DataSet();
            string OD = "select * from ODetail where orderid = '" + orderid + "'";
            SqlDataAdapter odDa = new SqlDataAdapter(OD, cn);
            odDa.Fill(ds1, "OrderDetail");
            dataGridView1.DataSource = ds1;
            dataGridView1.DataMember = "OrderDetail";
            cn.Close();
        }
        
    }
}
