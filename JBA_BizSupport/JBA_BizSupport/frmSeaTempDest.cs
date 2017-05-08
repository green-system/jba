using System;
using System.Drawing;
using System.Windows.Forms;

namespace JBA_BizSupport
{
    public partial class frmSeaTempDest : Form
    {
        public string InputTmpPayNumber { get; set; } //新しく入力された仮払番号
        public string InputBizCD { get; set; }       //新しく入力された事業コード
        public string InputBizName { get; set; }     //新しく入力された事業名
        public string InputPurpose { get; set; }     //新しく入力された目的
        public string InputPrice { get; set; }       //新しく入力された金額
        public string InputTmpPayDay { get; set; }   //新しく入力された仮払日付
        public string InputClientCD { get; set; }    //新しく入力された支払先コード
        public string InputClientName { get; set; }  //新しく入力された支払先名
        public string SearchStrTmpPay { get; set; }  //検索仮払先文字列
        public int SelectedClientRow { get; set; }   //選択行番号

        public frmSeaTempDest()
        {
            InitializeComponent();
        }

        // フォームロード
        private void frmSeaTempDest_Load(object sender, EventArgs e)
        {
            // 列ヘッダの背景色の変更
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.PeachPuff;

            textBox1.Text = SearchStrTmpPay;
            button1.PerformClick();
        }

        // 閉じるボタンクリック
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 設定ボタンクリック
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                InputTmpPayNumber = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                InputBizCD = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                InputBizName = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                InputPurpose = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                InputPrice = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                InputTmpPayDay = DateTime.Parse(dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value.ToString()).ToString("d");
                InputClientCD = dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                InputClientName = dataGridView1[8, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                SelectedClientRow = dataGridView1.CurrentCell.RowIndex;
                this.Close();
            }
        }

        // 検索ボタンクリック
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 検索結果表示
                if(textBox1.Text == "")
                {
                    this.gADA_TEMP_PAYTableAdapter.FillByUnsettledEmpty(this.jBADBDataSet.GADA_TEMP_PAY);
                    SelectedClientRow = dataGridView1.CurrentCell.RowIndex;
                }
                else
                {
                    this.gADA_TEMP_PAYTableAdapter.FillByUnsettledSearch(this.jBADBDataSet.GADA_TEMP_PAY, textBox1.Text);
                    SelectedClientRow = dataGridView1.CurrentCell.RowIndex;
                }
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
                InputTmpPayNumber = dataGridView1[1, e.RowIndex].Value.ToString();
                InputBizCD = dataGridView1[2, e.RowIndex].Value.ToString();
                InputBizName = dataGridView1[3, e.RowIndex].Value.ToString();
                InputPurpose = dataGridView1[4, e.RowIndex].Value.ToString();
                InputPrice = dataGridView1[5, e.RowIndex].Value.ToString();
                InputTmpPayDay = DateTime.Parse(dataGridView1[6, e.RowIndex].Value.ToString()).ToString("d");
                InputClientCD = dataGridView1[7, e.RowIndex].Value.ToString();
                InputClientName = dataGridView1[8, e.RowIndex].Value.ToString();
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
