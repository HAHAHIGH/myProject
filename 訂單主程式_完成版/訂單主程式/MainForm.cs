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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Show();
            f1.FormClosed += new FormClosedEventHandler(Form2_Closing);
            this.Hide();
        }
        private void Form2_Closing(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
