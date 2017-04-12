using System;
using System.Drawing;
using System.Windows.Forms;

namespace JBA_BizSupport
{
    public partial class frmSeaBusinessName : Form
    {
        public string InputBusinessCD { get; set; }    //事業コード
        public string InputBusinessName { get; set; }  //事業名称
        public string InputBillCD { get; set; }        //会計区分
        public string SearchBusinessName { get; set; } //検索事業名文字列
        public int SelectedBusinessRow { get; set; }   //選択行番号

        public frmSeaBusinessName()
        {
            InitializeComponent();
        }
        
        // フォームロード
        private void frmSeaBusinessName_Load(object sender, EventArgs e)
        {
            // 列ヘッダの背景色の変更
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.PeachPuff;

            textBox1.Text = SearchBusinessName;
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
                InputBusinessCD = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                InputBusinessName = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                InputBillCD = dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                SelectedBusinessRow = dataGridView1.CurrentCell.RowIndex;
                this.Close();
            }
        }

        // 検索ボタンクリック
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 検索結果表示
                this.gAMA_BUSINESSTableAdapter.FillByBusinessName(this.jBADBDataSet.GAMA_BUSINESS, textBox1.Text);
                SelectedBusinessRow = dataGridView1.CurrentCell.RowIndex;
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
                if (SelectedBusinessRow > 0)
                {
                    dataGridView1.Rows[SelectedBusinessRow].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = SelectedBusinessRow;
                }
            }
        }

        // 検索窓Enterキー押下
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button1.PerformClick();
            }
        }

        // データグリッドビューダブルクリック
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                InputBusinessCD = dataGridView1[0, e.RowIndex].Value.ToString();
                InputBusinessName = dataGridView1[1, e.RowIndex].Value.ToString();
                InputBillCD = dataGridView1[7, e.RowIndex].Value.ToString();
                this.Close();
            }
        }

        // データグリッドビュー内Enterキー押下
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button2.PerformClick();
            }
        }

    }
}
