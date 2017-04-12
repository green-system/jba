using System;
using System.Drawing;
using System.Windows.Forms;

namespace JBA_BizSupport
{
    public partial class frmSearchBranch : Form
    {
        public string InputBankCD { get; set; }     // 新しく入力された銀行コード
        public string InputBank { get; set; }       // 新しく入力された銀行名
        public string InputBranchCD { get; set; }   // 新しく入力された支店コード
        public string InputBranch { get; set; }     // 新しく入力された支店名
        public bool isBranchCanceled { get; set; }  // 支店を選択しなかったときtrue、選択したときfalse

        public frmSearchBranch()
        {
            InitializeComponent();
        }

        // 閉じるボタンクリック
        private void button6_Click(object sender, EventArgs e)
        {
            isBranchCanceled = true;
            this.Close();
        }

        // フォームロード
        private void frmSearchBranch_Load(object sender, EventArgs e)
        {
            label2.Text = InputBank + "(" + InputBankCD + ")";
            // 列ヘッダの背景色の変更
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.PeachPuff;

            // 検索結果（全支店）表示
            this.gAMA_BANKTableAdapter.FillByBranchKana(this.jBADBDataSet.GAMA_BANK,"","", InputBankCD);
            label3.Text = dataGridView1.BindingContext[dataGridView1.DataSource, dataGridView1.DataMember].Count.ToString() + "件";
            //this.button1.PerformClick();
        }

        // データグリッドビューダブルクリック
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                InputBranchCD = dataGridView1[1, e.RowIndex].Value.ToString();
                InputBranch = dataGridView1[2, e.RowIndex].Value.ToString();
                this.textBox1.Text = InputBranchCD;
                this.textBox2.Text = InputBranch;
                isBranchCanceled = false;
                this.Close();
                this.Dispose();
            }
        }

        // 検索ボタンクリック
        private void button1_Click(object sender, EventArgs e)
        {
            string convText = string.Empty;

            try
            {
                //テキストボックスに含まれる文字がすべてひらがなか調べる
                //テキストボックスが空の文字列の時は、falseを返す
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"^\p{IsHiragana}+$"))
                {
                    //小文字のひらがなを大文字に変換
                    convText = textBox2.Text.Replace("ぁ", "あ");
                    convText = convText.Replace("ぃ", "い");
                    convText = convText.Replace("ぅ", "う");
                    convText = convText.Replace("ぇ", "え");
                    convText = convText.Replace("ぉ", "お");
                    convText = convText.Replace("っ", "つ");
                    convText = convText.Replace("ゃ", "や");
                    convText = convText.Replace("ゅ", "ゆ");
                    convText = convText.Replace("ょ", "よ");
                    convText = convText.Replace("ゎ", "わ");
                    //半角カナに変換
                    convText = Microsoft.VisualBasic.Strings.StrConv(
                    convText,
                    Microsoft.VisualBasic.VbStrConv.Katakana | Microsoft.VisualBasic.VbStrConv.Narrow,
                    0x411);
                }
                // 検索結果表示
                this.gAMA_BANKTableAdapter.FillByBranchKana(this.jBADBDataSet.GAMA_BANK, textBox2.Text, convText, InputBankCD);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
            finally
            {
                label3.Text = dataGridView1.BindingContext[dataGridView1.DataSource, dataGridView1.DataMember].Count.ToString() + "件";
            }
        }

        // 検索窓Enterキー押下
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button1.PerformClick();
            }
        }

        // 設定ボタンクリック
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex != -1)
            {
                InputBranchCD = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                InputBranch = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                this.textBox1.Text = InputBranchCD;
                this.textBox2.Text = InputBranch;
                isBranchCanceled = false;
                this.Close();
                this.Dispose();
            }
        }

        // データグリッドビューEnterキー押下
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button2.PerformClick();
            }
        }

        // データグリッドビューツールチップテキスト表示
        private void dataGridView1_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                e.ToolTipText = dataGridView1[4, e.RowIndex].Value.ToString();
            }
        }
    }
}
