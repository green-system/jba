using System;
using System.Windows.Forms;

namespace JBA_BizSupport
{
    public partial class frmTempSave : Form
    {
        public string TmpSaveFlg { get; set; }

        public frmTempSave()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TmpSaveFlg = "list";
            this.Close();
        }
    }
}
