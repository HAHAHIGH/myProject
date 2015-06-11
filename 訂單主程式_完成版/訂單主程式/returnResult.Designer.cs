namespace 訂單主程式
{
    partial class returnResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.btn送出 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "訂購失敗原因: ";
            // 
            // tboxResult
            // 
            this.tboxResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tboxResult.Location = new System.Drawing.Point(164, 56);
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.Size = new System.Drawing.Size(191, 34);
            this.tboxResult.TabIndex = 1;
            // 
            // btn送出
            // 
            this.btn送出.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn送出.Location = new System.Drawing.Point(312, 115);
            this.btn送出.Name = "btn送出";
            this.btn送出.Size = new System.Drawing.Size(91, 35);
            this.btn送出.TabIndex = 2;
            this.btn送出.Text = "送出";
            this.btn送出.UseVisualStyleBackColor = true;
            this.btn送出.Click += new System.EventHandler(this.btn送出_Click);
            // 
            // returnResult
            // 
            this.AcceptButton = this.btn送出;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 175);
            this.Controls.Add(this.btn送出);
            this.Controls.Add(this.tboxResult);
            this.Controls.Add(this.label1);
            this.Name = "returnResult";
            this.Text = "無法訂購";
            this.Load += new System.EventHandler(this.returnResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxResult;
        private System.Windows.Forms.Button btn送出;
    }
}