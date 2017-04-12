using System;
using System.Drawing;
using System.Windows.Forms;

namespace JBA_BizSupport
{
    public partial class frmSeaAddress : Form
    {
        public string InputText { get; set; }
        public string InputAddress { get; set; }

        public frmSeaAddress()
        {
            InitializeComponent();
        }

        // フォームロード
        private void frmSeaAddress_Load(object sender, EventArgs e)
        {
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.PeachPuff;
            try
            {
                // フォーム内表示用郵便番号文字列作成
                string zipcode = InputText.Replace(" ", "*");
                if (zipcode.Length < 8)
                {
                    zipcode = zipcode.PadRight(8, '*');
                }
                this.label3.Text = zipcode;
                // sql用郵便番号検索文字列作成
                zipcode = InputText.Replace("-", "");
                zipcode = zipcode.Replace(" ", "_");
                if (zipcode.Length > 7)
                {
                    zipcode = zipcode.Substring(0, 6);
                }
                // 検索結果表示
                this.gAMA_ADDRESSTableAdapter.FillByZipCode(this.jBADBDataSet.GAMA_ADDRESS, zipcode);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
            finally
            {
                // データ件数表示
                label4.Text = dataGridView3.BindingContext[dataGridView3.DataSource, dataGridView3.DataMember].Count.ToString() + "件";
            }
        }

        // データグリッドビューツールチップテキスト表示
        private void DataGridView3_CellToolTipTextNeeded(object sender,
            DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex != -1) {
                string ZipCode = dataGridView3[e.ColumnIndex - 1, e.RowIndex].Value.ToString();
                e.ToolTipText = ZipCode.Substring(0, 3) + "-" + ZipCode.Substring(3, 4);
            }
        }

        // データグリッドビューダブルクリック
        private void dataGridView3_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) {
                InputText = dataGridView3[e.ColumnIndex - 1, e.RowIndex].Value.ToString();
                InputAddress = dataGridView3[e.ColumnIndex, e.RowIndex].Value.ToString();
                this.Close();
            }
        }

        // データグリッドビュー内Enterキー押下
        private void dataGridView3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button1.PerformClick();
            }
        }

        // 設定ボタンクリック
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentCell != null)
            {
                InputText = dataGridView3.CurrentCell.ToolTipText;
                InputAddress = dataGridView3.CurrentCell.Value.ToString();
            }
            this.Close();
        }

        // 閉じるボタンクリック
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
