using System;
using System.Drawing;
using System.Windows.Forms;

namespace JBA_BizSupport
{
    public partial class frmSeaPaymentDest : Form
    {
        public bool MultiSelection { get; set; }     //複数選択有無(false:なし true:あり)
        public string InputClientCD { get; set; }    //新しく入力された取引先コード
        public string InputClientName { get; set; }  //新しく入力された取引先名
        public string SearchClientName { get; set; } //検索取引先文字列
        public int SelectedClientRow { get; set; }   //選択行番号
        public int CorpoIndiID { get; set; }         //法人個人区分(1：法人、2：個人)

        public frmSeaPaymentDest()
        {
            InitializeComponent();
        }

        // 閉じるボタンクリック
        private void button6_Click(object sender, EventArgs e)
        {
            MultiSelection = false;
            this.Close();
        }

        // 設定ボタンクリック
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                InputClientCD = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                InputClientName = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                MultiSelection = true;
                SelectedClientRow = dataGridView1.CurrentCell.RowIndex;
                this.Close();
            }
        }

        // フォームロード
        private void frmSeaPaymentDest_Load(object sender, EventArgs e)
        {
            // 列ヘッダの背景色の変更
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.PeachPuff;

            textBox1.Text = SearchClientName;
            button1.PerformClick();
        }

        // 検索ボタンクリック
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 検索結果表示
                this.gAMA_CLIENTTableAdapter.FillByClientAndCorpIndiv(this.jBADBDataSet.GAMA_CLIENT, textBox1.Text, CorpoIndiID);
                SelectedClientRow = dataGridView1.CurrentCell.RowIndex;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
            finally
            {
                label3.Text = dataGridView1.BindingContext[dataGridView1.DataSource, dataGridView1.DataMember].Count.ToString() + "件";
                // 選択行までスクロール
                if (SelectedClientRow > 0)
                {
                    dataGridView1.Rows[SelectedClientRow].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = SelectedClientRow;
                }
            }
        }

        // データグリッドビューダブルクリック
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                InputClientCD = dataGridView1[0, e.RowIndex].Value.ToString();
                InputClientName = dataGridView1[1, e.RowIndex].Value.ToString();
                MultiSelection = true;
                SelectedClientRow = e.RowIndex;
                this.Close();
            }
        }

        // 検索窓内Enterキー押下
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button1.PerformClick();
            }
        }

        // データグリッド内Enterキー押下
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button2.PerformClick();
            }
        }
    }
}
