using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace JBA_BizSupport
{
    public partial class UserControl1 : UserControl
    {
        //------------------------------------------------------------------------
        // EventHandlers
        //------------------------------------------------------------------------
        //public delegate void EventExitHandler(object sender, EventArgs e);

        //------------------------------------------------------------------------
        // Events
        //------------------------------------------------------------------------
        //public event EventHandler openTempPayment;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmExpenseManage frm1 = new frmExpenseManage();
            //frm1.Close();
            //frm1.Dispose();
            //frmTempPayment frm = new frmTempPayment();
            //frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.Show();
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
