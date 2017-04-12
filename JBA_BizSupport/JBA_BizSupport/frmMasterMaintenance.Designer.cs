namespace JBA_BizSupport
{
    partial class frmMasterMaintenance
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.userControl51 = new JBA_BizSupport.UserControl5();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.userControl61 = new JBA_BizSupport.UserControl6();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(300, 179);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.userControl51);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(292, 153);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "マスタ管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // userControl51
            // 
            this.userControl51.Location = new System.Drawing.Point(5, 5);
            this.userControl51.Name = "userControl51";
            this.userControl51.Size = new System.Drawing.Size(281, 143);
            this.userControl51.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.userControl61);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(292, 153);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "システム管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // userControl61
            // 
            this.userControl61.Location = new System.Drawing.Point(5, 5);
            this.userControl61.Name = "userControl61";
            this.userControl61.Size = new System.Drawing.Size(280, 125);
            this.userControl61.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(215, 193);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 37);
            this.button4.TabIndex = 2;
            this.button4.Text = "戻　る";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmMasterMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 239);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button4);
            this.Name = "frmMasterMaintenance";
            this.Text = "マスタメンテナンス";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button4;
        private UserControl5 userControl51;
        private UserControl6 userControl61;
    }
}