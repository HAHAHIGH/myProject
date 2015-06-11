using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 訂單主程式
{
    public partial class returnResult : Form
    {
        public returnResult()
        {
            InitializeComponent();
        }
        Form2 f2 =new Form2();
        public Result r1 = null;
        private void returnResult_Load(object sender, EventArgs e)
        {

        }

        private void btn送出_Click(object sender, EventArgs e)
        {
            try
            {
                f2.lbl結果.Visible = true;
                f2.lbl結果.Text = "訂購失敗!!!!!" + tboxResult.Text;
                f2.lblUser.Text = r1.lblUsr.Text;
                f2.lblClass.Text = r1.lbl班級.Text;
                this.Hide();
                f2.Show();
            }
            catch(Exception e2)
            { MessageBox.Show(e2.Message); }
        }
    }
}
