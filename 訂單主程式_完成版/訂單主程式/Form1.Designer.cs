namespace 訂單主程式
{
    partial class Form2
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox店名 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbox總數量 = new System.Windows.Forms.TextBox();
            this.tbox總金額 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl現在時間 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl結果 = new System.Windows.Forms.Label();
            this.lblTodayUser = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox小計1 = new System.Windows.Forms.TextBox();
            this.cbox品名 = new System.Windows.Forms.ComboBox();
            this.cbox數量 = new System.Windows.Forms.ComboBox();
            this.tbox單價1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.btn確認 = new System.Windows.Forms.Button();
            this.cboxName = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(60, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "店名 :";
            // 
            // cbox店名
            // 
            this.cbox店名.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox店名.FormattingEnabled = true;
            this.cbox店名.Location = new System.Drawing.Point(112, 48);
            this.cbox店名.Name = "cbox店名";
            this.cbox店名.Size = new System.Drawing.Size(110, 28);
            this.cbox店名.TabIndex = 2;
            this.cbox店名.DropDown += new System.EventHandler(this.cbox店名_DropDown);
            this.cbox店名.SelectedIndexChanged += new System.EventHandler(this.cbox店名_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(235, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "班級 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(71, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "總數量 : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(277, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "總金額 : ";
            // 
            // tbox總數量
            // 
            this.tbox總數量.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbox總數量.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbox總數量.Location = new System.Drawing.Point(142, 429);
            this.tbox總數量.Name = "tbox總數量";
            this.tbox總數量.ReadOnly = true;
            this.tbox總數量.Size = new System.Drawing.Size(116, 29);
            this.tbox總數量.TabIndex = 10;
            // 
            // tbox總金額
            // 
            this.tbox總金額.BackColor = System.Drawing.Color.Yellow;
            this.tbox總金額.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbox總金額.Location = new System.Drawing.Point(348, 429);
            this.tbox總金額.Name = "tbox總金額";
            this.tbox總金額.ReadOnly = true;
            this.tbox總金額.Size = new System.Drawing.Size(116, 29);
            this.tbox總金額.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(629, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "確定訂購";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.DarkViolet;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(421, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "訂購時間 :";
            // 
            // lbl現在時間
            // 
            this.lbl現在時間.BackColor = System.Drawing.Color.DarkViolet;
            this.lbl現在時間.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl現在時間.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl現在時間.Location = new System.Drawing.Point(519, 48);
            this.lbl現在時間.Name = "lbl現在時間";
            this.lbl現在時間.Size = new System.Drawing.Size(226, 20);
            this.lbl現在時間.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl結果
            // 
            this.lbl結果.BackColor = System.Drawing.Color.Yellow;
            this.lbl結果.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl結果.ForeColor = System.Drawing.Color.Red;
            this.lbl結果.Location = new System.Drawing.Point(512, 13);
            this.lbl結果.Name = "lbl結果";
            this.lbl結果.Size = new System.Drawing.Size(205, 23);
            this.lbl結果.TabIndex = 65;
            this.lbl結果.Text = "                 ";
            this.lbl結果.Visible = false;
            // 
            // lblTodayUser
            // 
            this.lblTodayUser.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTodayUser.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTodayUser.Location = new System.Drawing.Point(9, 16);
            this.lblTodayUser.Name = "lblTodayUser";
            this.lblTodayUser.Size = new System.Drawing.Size(100, 23);
            this.lblTodayUser.TabIndex = 68;
            this.lblTodayUser.Text = "今日負責人:";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUser.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblUser.Location = new System.Drawing.Point(110, 16);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 23);
            this.lblUser.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(574, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 106;
            this.label6.Text = "小計:";
            // 
            // tbox小計1
            // 
            this.tbox小計1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbox小計1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbox小計1.Location = new System.Drawing.Point(625, 96);
            this.tbox小計1.Name = "tbox小計1";
            this.tbox小計1.ReadOnly = true;
            this.tbox小計1.Size = new System.Drawing.Size(110, 29);
            this.tbox小計1.TabIndex = 105;
            // 
            // cbox品名
            // 
            this.cbox品名.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox品名.FormattingEnabled = true;
            this.cbox品名.Location = new System.Drawing.Point(285, 48);
            this.cbox品名.Name = "cbox品名";
            this.cbox品名.Size = new System.Drawing.Size(110, 28);
            this.cbox品名.TabIndex = 104;
            this.cbox品名.SelectedIndexChanged += new System.EventHandler(this.cbox品名_SelectedIndexChanged);
            // 
            // cbox數量
            // 
            this.cbox數量.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox數量.FormattingEnabled = true;
            this.cbox數量.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbox數量.Location = new System.Drawing.Point(112, 97);
            this.cbox數量.Name = "cbox數量";
            this.cbox數量.Size = new System.Drawing.Size(110, 28);
            this.cbox數量.TabIndex = 100;
            this.cbox數量.SelectedIndexChanged += new System.EventHandler(this.cbox數量_SelectedIndexChanged);
            // 
            // tbox單價1
            // 
            this.tbox單價1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbox單價1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbox單價1.Location = new System.Drawing.Point(283, 96);
            this.tbox單價1.Name = "tbox單價1";
            this.tbox單價1.ReadOnly = true;
            this.tbox單價1.Size = new System.Drawing.Size(110, 29);
            this.tbox單價1.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(402, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 99;
            this.label5.Text = "姓名:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(230, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 98;
            this.label4.Text = "單價:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(58, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 97;
            this.label3.Text = "數量:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(234, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 96;
            this.label2.Text = "品名:";
            // 
            // lblClass
            // 
            this.lblClass.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClass.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblClass.Location = new System.Drawing.Point(290, 16);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(100, 23);
            this.lblClass.TabIndex = 116;
            // 
            // btn確認
            // 
            this.btn確認.BackColor = System.Drawing.Color.DarkOrange;
            this.btn確認.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn確認.Location = new System.Drawing.Point(657, 152);
            this.btn確認.Name = "btn確認";
            this.btn確認.Size = new System.Drawing.Size(119, 34);
            this.btn確認.TabIndex = 117;
            this.btn確認.Text = "確認送出";
            this.btn確認.UseVisualStyleBackColor = false;
            this.btn確認.Click += new System.EventHandler(this.btn確認_Click);
            // 
            // cboxName
            // 
            this.cboxName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxName.FormattingEnabled = true;
            this.cboxName.Location = new System.Drawing.Point(454, 96);
            this.cboxName.Name = "cboxName";
            this.cboxName.Size = new System.Drawing.Size(110, 28);
            this.cboxName.TabIndex = 118;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(586, 241);
            this.dataGridView1.TabIndex = 120;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(788, 488);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboxName);
            this.Controls.Add(this.btn確認);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbox小計1);
            this.Controls.Add(this.cbox品名);
            this.Controls.Add(this.cbox數量);
            this.Controls.Add(this.tbox單價1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblTodayUser);
            this.Controls.Add(this.lbl結果);
            this.Controls.Add(this.lbl現在時間);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbox總數量);
            this.Controls.Add(this.tbox總金額);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbox店名);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "III訂便當系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl現在時間;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.ComboBox cbox店名;
        internal System.Windows.Forms.TextBox tbox總數量;
        internal System.Windows.Forms.TextBox tbox總金額;
        internal System.Windows.Forms.Label lbl結果;
        private System.Windows.Forms.Label lblTodayUser;
        internal System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox tbox小計1;
        internal System.Windows.Forms.ComboBox cbox品名;
        internal System.Windows.Forms.ComboBox cbox數量;
        internal System.Windows.Forms.TextBox tbox單價1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Button btn確認;
        internal System.Windows.Forms.ComboBox cboxName;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

