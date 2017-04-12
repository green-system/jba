using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace JBA_BizSupport
{
    public partial class frmIndivRecExpense : Form
    {
        public frmIndivRecExpense()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmIndivRecExpense1 frm = new frmIndivRecExpense1();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            this.button1.PerformClick();
        }
    }
}
