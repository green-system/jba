using System;
using System.Drawing;
using System.Windows.Forms;

namespace JBA_BizSupport
{
    public partial class frmSearchBank : Form
    {
        public string OldBankCD { get; set; }     // もともと入っていた銀行コード
        public string OldBank { get; set; }       // もともと入っていた銀行名
        public string OldBranchCD { get; set; }   // もともと入っていた支店コード
        public string OldBranch { get; set; }     // もともと入っていた支店名
        public string TextBankCD { get; set; }    // 新しく入力された銀行コード
        public string TextBank { get; set; }      // 新しく入力された銀行名
        public string TextBranchCD { get; set; }  // 新しく入力された支店コード
        public string TextBranch { get; set; }    // 新しく入力された支店名
        public bool isBankCanceled { get; set; }  // 銀行および支店を選択しなかったときtrue、選択したときfalse

        public frmSearchBank()
        {
            InitializeComponent();
        }

        // フォームロード
        private void frmSearchBank_Load(object sender, EventArgs e)
        {
            // 列ヘッダの背景色の変更
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.PeachPuff;

            // 検索結果（全件）表示
            this.gAMA_BANKTableAdapter.FillByBankKana(this.jBADBDataSet.GAMA_BANK, "","");
            label3.Text = dataGridView1.BindingContext[dataGridView1.DataSource, dataGridView1.DataMember].Count.ToString() + "件";
        }

        // データグリッドビューダブルクリック
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                using (frmSearchBranch frm2 = new frmSearchBranch())
                {
                    frm2.InputBankCD = dataGridView1[0, e.RowIndex].Value.ToString();
                    frm2.InputBank = dataGridView1[3, e.RowIndex].Value.ToString();
                    frm2.InputBranchCD = OldBranchCD;
                    frm2.InputBranch = OldBranch;
                    isBankCanceled = false;
                    frm2.isBranchCanceled = true;
                    frm2.StartPosition = FormStartPosition.CenterParent;
                    frm2.ShowDialog(this);
                    this.textBox2.Text = frm2.InputBankCD;
                    TextBankCD = frm2.InputBankCD;
                    this.textBox3.Text = frm2.InputBank;
                    TextBank = frm2.InputBank;
                    this.textBox4.Text = frm2.InputBranchCD;
                    TextBranchCD = frm2.InputBranchCD;
                    this.textBox5.Text = frm2.InputBranch;
                    TextBranch = frm2.InputBranch;
                    this.textBox1.Focus();
                    if (frm2.isBranchCanceled == false)
                    {
                        this.Close();
                        this.Dispose();
                    }
                }
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

        // 検索ボタンクリック
        private void button1_Click(object sender, EventArgs e)
        {
            string convText = string.Empty;

            try
            {
                //テキストボックスに含まれる文字がすべてひらがなか調べる
                //テキストボックスが空の文字列の時は、falseを返す
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, @"^\p{IsHiragana}+$"))
                {
                    //小文字のひらがなを大文字に変換
                    convText = textBox1.Text.Replace("ぁ", "あ");
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
                this.gAMA_BANKTableAdapter.FillByBankKana(this.jBADBDataSet.GAMA_BANK, textBox1.Text, convText);

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

        // 検索窓Eneterキー押下
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button1.PerformClick();
            }
        }

        // 支店選択ボタンクリック
        private void button2_Click(object sender, EventArgs e)
        {
            using (frmSearchBranch frm2 = new frmSearchBranch())
            {
                if (dataGridView1.CurrentCell != null)
                {
                    frm2.InputBankCD = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    frm2.InputBank = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                }
                frm2.InputBranchCD = TextBranchCD;
                frm2.InputBranch = TextBranch;
                isBankCanceled = false;
                frm2.isBranchCanceled = true;
                frm2.StartPosition = FormStartPosition.CenterParent;
                frm2.ShowDialog(this);
                this.textBox2.Text = frm2.InputBankCD;
                TextBankCD = frm2.InputBankCD;
                this.textBox3.Text = frm2.InputBank;
                TextBank = frm2.InputBank;
                this.textBox4.Text = frm2.InputBranchCD;
                TextBranchCD = frm2.InputBranchCD;
                this.textBox5.Text = frm2.InputBranch;
                TextBranch = frm2.InputBranch;
                this.textBox1.Focus();
                if (frm2.isBranchCanceled == false)
                {
                    this.Close();
                    this.Dispose();
                }
            }
        }

        // 閉じるボタンクリック
        private void button6_Click(object sender, EventArgs e)
        {
            isBankCanceled = true;
            this.Close();
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
