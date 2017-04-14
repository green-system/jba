using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JBA_BizSupport
{
    public partial class UserControl7 : UserControl
    {
        public string TmpPayNumber { get; set; }
        public int TabNumber { get; set; }
        public string LabelText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        VScrollBar vsBar;

        public UserControl7()
        {
            InitializeComponent();
        }

        private void UserControl7_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["BORROWED_PRICE"].ValueType = typeof(int);
            dataGridView1.Columns["LEND_PRICE"].ValueType = typeof(int);
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            byte cnt_tab = 1;
            do
            {
                this.gAMA_HIMOKUTableAdapter.Fill(this.jBADBDataSet.GAMA_HIMOKU);
                this.pCA_DATA_DETAILTableAdapter.FillByPatternNumber(this.jBADBDataSet.PCA_DATA_DETAIL, TmpPayNumber, cnt_tab);
                if (this.jBADBDataSet.PCA_DATA_DETAIL.Count == 0) { break; }
                var borrowed_total = 0;
                var lend_total = 0;
                for (byte cnt_line = 1; cnt_line <= this.jBADBDataSet.PCA_DATA_DETAIL.Count; ++cnt_line)
                {
                    // PCA仕訳伝票詳細データ表示
                    this.dataGridView1.Rows.Add(cnt_line.ToString(),                                 // No
                         jBADBDataSet.Tables["PCA_DATA_DETAIL"].Rows[cnt_line - 1][0].ToString(),    // 借方科目CODE
                         jBADBDataSet.Tables["PCA_DATA_DETAIL"].Rows[cnt_line - 1][0].ToString(),    // 借方科目名
                         jBADBDataSet.Tables["PCA_DATA_DETAIL"].Rows[cnt_line - 1][1],               // 借方金額
                         jBADBDataSet.Tables["PCA_DATA_DETAIL"].Rows[cnt_line - 1][2].ToString(),    // 貸方科目CODE
                         jBADBDataSet.Tables["PCA_DATA_DETAIL"].Rows[cnt_line - 1][2].ToString(),    // 貸方科目名
                         jBADBDataSet.Tables["PCA_DATA_DETAIL"].Rows[cnt_line - 1][3]);              // 貸方金額
                    // 借方金額合計計算
                    borrowed_total = borrowed_total + int.Parse(dataGridView1[3, cnt_line - 1].Value.ToString());
                    // 貸方金額合計計算
                    lend_total = lend_total + int.Parse(dataGridView1[6, cnt_line - 1].Value.ToString());
                }
                textBox1.Text = borrowed_total.ToString("#,0");
                textBox2.Text = lend_total.ToString("#,0");
                // 次のタブ番号へ移動
                cnt_tab++;
            } while (cnt_tab < this.jBADBDataSet.PCA_DATA_DETAIL.Count);
        }

        // データグリッドビュー縦スクロールバー表示イベント
        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            foreach (Control c in dataGridView1.Controls)
            {
                if (c is VScrollBar)
                {
                    vsBar = (VScrollBar)c;
                    vsBar.VisibleChanged += new EventHandler(vsBar_VisibleChanged);
                    dataGridView1.Columns["DummyForScrolBar"].Visible = vsBar.Visible;
                    dataGridView1.Columns["DummyForScrolBar"].Width = 18;
                }
            }
        }

        // データグリッドビュー幅調整
        void vsBar_VisibleChanged(object sender, EventArgs e)
        {
            if (vsBar.Visible)
            {
                dataGridView1.Width = 813;
            }
            if (!vsBar.Visible)
            {
                dataGridView1.Width = 795;
            }
            dataGridView1.Refresh();
        }

        // データグリッドビュー内のセルが編集中のとき
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //表示されているコントロールがDataGridViewTextBoxEditingControlか調べる
            if (e.Control is DataGridViewTextBoxEditingControl)
            {
                DataGridView dgv = (DataGridView)sender;

                //編集のために表示されているコントロールを取得
                DataGridViewTextBoxEditingControl tb = (DataGridViewTextBoxEditingControl)e.Control;

                //イベントハンドラを削除
                tb.KeyPress -= new KeyPressEventHandler(dataGridViewTextBox_KeyPress);

                //該当する列か調べる
                if (dgv.CurrentCell.OwningColumn.Name == "BORROWED_PRICE" || dgv.CurrentCell.OwningColumn.Name == "LEND_PRICE")
                {
                    //KeyPressイベントハンドラを追加
                    tb.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);
                }
            }
        }

        //DataGridViewに表示されているテキストボックスのKeyPressイベントハンドラ
        private void dataGridViewTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //数字しか入力できないようにする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        // データグリッドビューCellDirtyState変更
        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // データグリッドビュー内セル値変更
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // 科目名列かどうかを確認
            if (dataGridView1.Columns[e.ColumnIndex].Name == "himokuname1" && e.RowIndex != -1)
            {
                dataGridView1.Rows[e.RowIndex].Cells[1].Value = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "himokuname2" && e.RowIndex != -1)
            {
                dataGridView1.Rows[e.RowIndex].Cells[4].Value = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            }
            try
            {
                // 借方金額列かどうかを確認
                if (dataGridView1.Columns[e.ColumnIndex].Name == "BORROWED_PRICE" && e.RowIndex != -1)
                {
                    // 合計計算
                    var borrowed_total = 0;
                    foreach (var row in dataGridView1.Rows.Cast<DataGridViewRow>())
                    {
                        if (row.Cells[3].Value == null || Convert.ToString(row.Cells[3].Value) == "")
                        {
                            row.Cells[3].Value = 0;
                        }
                        else
                        {
                            borrowed_total = borrowed_total + int.Parse(row.Cells[3].Value.ToString());
                        }
                    }
                    textBox1.Text = borrowed_total.ToString("#,0");
                }
                // 貸方金額列かどうかを確認
                if (dataGridView1.Columns[e.ColumnIndex].Name == "LEND_PRICE" && e.RowIndex != -1)
                {
                    // 合計計算
                    var lend_total = 0;
                    foreach (var row in dataGridView1.Rows.Cast<DataGridViewRow>())
                    {
                        if (row.Cells[6].Value == null || Convert.ToString(row.Cells[6].Value) == "")
                        {
                            row.Cells[6].Value = 0;
                        }
                        else
                        {
                            lend_total = lend_total + int.Parse(row.Cells[6].Value.ToString());
                        }
                    }
                    textBox2.Text = lend_total.ToString("#,0");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

    }
}
