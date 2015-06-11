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
    public partial class Login_Form : Form
    {
        SqlConnectionStringBuilder scsb;
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"NTHIGH\SQLEXPRESS";
            scsb.InitialCatalog = "Mid";
            scsb.IntegratedSecurity = true;
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = scsb.ToString();
            cn.Open();

            string searchUsername = tboxUsername.Text;
            string selectUser = "select * from Username where Username = '" + searchUsername + "'";
            SqlCommand selectUsercmd = new SqlCommand(selectUser, cn);
            SqlDataReader selectUserdr = selectUsercmd.ExecuteReader();
            if (selectUserdr.Read())
            {
                string Userid = selectUserdr["ID"].ToString();
                selectUserdr.Close();
                string searchID = "select * from Password where ID = '" + Userid + "'";
                SqlCommand selectIDcmd = new SqlCommand(searchID, cn);
                SqlDataReader selectIDdr = selectIDcmd.ExecuteReader();
                if (selectIDdr.Read())
                {
                    string Password = selectIDdr["Password"].ToString();
                    selectIDdr.Close();
                    if (tboxPassword.Text == Password)
                    {

                        Form2 f2 = new Form2();
                        f2.f1 = this;
                        f2.Show();                        
                        this.Hide();
                    }
                    else
                    {
                        lblResult.Text = "密碼有誤!!";
                    }

                }
            }
            else
            {
                lblResult.Text = "輸入的帳號不正確!!";
            }
        }
        private void Form2_Closing(object sender, FormClosedEventArgs e)
        {}

        private void btn清除_Click(object sender, EventArgs e)
        {
            tboxUsername.Text = "";
            tboxPassword.Text = "";
            lblResult.Text = "請輸入帳號密碼";
        }
    }
}
