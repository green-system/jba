﻿using System;
using System.Windows.Forms;

namespace JBA_BizSupport
{
    public partial class frmExpenseManage : Form
    {
        public frmExpenseManage()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            frmMain frm = new frmMain();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void frmExpenseManage_Load(object sender, EventArgs e)
        {
//            this.Activate();
        }
    }
}
