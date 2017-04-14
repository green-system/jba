using System;
using System.Windows.Forms;

namespace JBA_BizSupport
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTempPayment frm = new frmTempPayment();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmIndivRecExpense frm = new frmIndivRecExpense();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCorpRecExpense frm = new frmCorpRecExpense();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }
    }
}
