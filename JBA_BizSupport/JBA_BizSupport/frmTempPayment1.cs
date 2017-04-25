using System;
using System.Drawing;
using System.Windows.Forms;

namespace JBA_BizSupport
{
    public partial class frmTempPayment1 : Form
    {
        ToolTip ToolTip1;                                   // 振込元口座ツールチップ表示用

        public string ListButtonFLG { get; set; }           // 仮払い一覧画面からの遷移方法
        public string TextTmpPayNum { get; set; }           // 仮払番号
        public string TextReqPersonName { get; set; }       // 依頼者氏名
        public string TextBizCD { get; set; }               // 事業コード
        public string TextBizName { get; set; }             // 事業名称
        public int IntBillID { get; set; }                  // 会計区分
        public string TextTmpPayPurpose { get; set; }       // 目的
        public string TextClientCD { get; set; }            // 支払先コード（取引先コード）
        public string TextClientName { get; set; }          // 取引先名
        public string TextTmpPayOL { get; set; }            // 摘要
        public int IntTmpPayType { get; set; }              // 支払方法種別
        public int IntTmpPayPrice { get; set; }             // 仮払金額
        public DateTime DateTmpPayDay { get; set; }         // 仮払日付
        public string TextBankCD { get; set; }              // 振込先銀行コード
        public string TextBankName { get; set; }            // 振込先銀行名
        public string TextBranchCD { get; set; }            // 振込先支店コード
        public string TextBranchName { get; set; }          // 振込先支店名
        public string TextAccountHolderKANA { get; set; }   // 振込先口座名義名カナ
        public int IntAccountType { get; set; }             // 振込先口座種別
        public string TextAccountNum { get; set; }          // 振込先口座番号
        public int IntRecNumber { get; set; }               // 振込元銀行口座連番

        public frmTempPayment1()
        {
            InitializeComponent();
        }

        // フォームロード
        private void frmTempPayment1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'jBADBDataSet.GAMA_TRANSFER_FROM_BANK' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.gAMA_TRANSFER_FROM_BANKTableAdapter.Fill(this.jBADBDataSet.GAMA_TRANSFER_FROM_BANK);
            // データグリッドビューダブルクリック・選択ボタンクリックか新規作成ボタンクリックかで初期設定を変更
            if (ListButtonFLG == "GridDoubleClick" || ListButtonFLG == "ButtonClick")
            {
                // 初期表示設定
                textBox7.Text = TextTmpPayNum;
                textBox5.Text = TextReqPersonName;
                textBox6.Text = TextTmpPayPurpose;
                label2.Text = TextBizCD;
                label3.Text = TextBizName;
                switch (IntBillID)
                {
                    case 1:
                        label5.Text = "公益";
                        break;
                    case 2:
                        label5.Text = "事業";
                        break;
                    case 3:
                        label5.Text = "収益";
                        break;
                }
                label6.Text = TextClientCD;
                label8.Text = TextClientName;
                textBox1.ReadOnly = true;
                textBox1.BackColor = Color.FromKnownColor(KnownColor.Control);
                textBox1.Text = TextTmpPayOL;
                comboBox1.Visible = false;
                textBox16.Visible = true;
                textBox16.ReadOnly = true;
                textBox16.BackColor = Color.FromKnownColor(KnownColor.Control);
                switch (IntTmpPayType)
                {
                    case 1:
                        textBox16.Text = "現金";
                        //comboBox1.SelectedIndex = 1;
                        break;
                    case 2:
                        textBox16.Text = "振込";
                        //comboBox1.SelectedIndex = 0;
                        break;
                }
                textBox2.ReadOnly = true;
                textBox2.BackColor = Color.FromKnownColor(KnownColor.Control);
                textBox2.Text = IntTmpPayPrice.ToString("#,0");
                dateTimePicker1.Visible = false;
                textBox19.Visible = true;
                textBox19.Text = DateTmpPayDay.ToString("d");
                label14.Text = TextBankCD;
                label13.Text = TextBankName;
                label12.Text = TextBranchCD;
                label4.Text = TextBranchName;
                textBox4.Text = TextAccountHolderKANA;
                comboBox3.Visible = false;
                textBox20.Visible = true;
                switch (IntAccountType)
                {
                    case 0:
                        textBox20.Text = "";
                        break;
                    case 1:
                        textBox20.Text = "普通";
                        break;
                    case 2:
                        textBox20.Text = "当座";
                        break;
                    case 4:
                        textBox20.Text = "貯蓄";
                        break;
                }
                textBox3.Text = TextAccountNum;
                comboBox2.SelectedIndex = IntRecNumber;
                // 進捗ログ表示
                dataGridView1.GridColor = Color.Gray;
                this.progressLogTableAdapter.FillByProgressLog(this.jBADBDataSet.PROGRESS_LOG, TextTmpPayNum);
                // UserControl部分（PCA仕訳伝票番号）表示
                string TextPCADataNum = this.pCA_DATA_DETAILTableAdapter.ScalarQueryPCADataNumber(TextTmpPayNum).ToString();
                // GADA_PCA_DATA_DETAILテーブルのPCA仕訳伝票番号（第1引数）毎のタブ番号（第2引数）の存在有無（0：存在しない 1：存在する）
                byte TabNum = byte.Parse(this.pCA_DATA_DETAILTableAdapter.ScalarQueryTabNumber(TextPCADataNum, 1).ToString() ?? "0");
                userControl71.TmpPayNumber = TextTmpPayNum;
                userControl71.TabNumber = TabNum;
                userControl71.LabelText = TextPCADataNum + "-" + TabNum.ToString("D3");
            }
            else if (ListButtonFLG == "CreateNewClick")
            {
                // 初期表示設定
                dateTimePicker1.Visible = true;
                dateTimePicker1.Value = DateTime.Now;
                comboBox1.Visible = true;
                comboBox1.SelectedIndex = 0;
                comboBox3.Visible = true;
                comboBox3.SelectedIndex = -1;
                textBox20.Visible = false;
                textBox6.ReadOnly = false;
                textBox6.Top = 61;
                textBox6.BackColor = Color.FromKnownColor(KnownColor.Window);
                textBox6.BorderStyle = BorderStyle.Fixed3D;
                textBox6.Text = "";
                textBox19.Visible = false;
                textBox20.Visible = false;
                textBox16.Visible = false;
                textBox16.ReadOnly = false;
                textBox16.Top = 175;
                textBox16.BackColor = Color.FromKnownColor(KnownColor.Window);
                textBox16.BorderStyle = BorderStyle.Fixed3D;
                textBox1.ReadOnly = false;
                textBox1.Top = 175;
                textBox1.BackColor = Color.FromKnownColor(KnownColor.Window);
                textBox1.BorderStyle = BorderStyle.Fixed3D;
                textBox1.Text = "";
                textBox2.ReadOnly = false;
                textBox2.Top = 175;
                textBox2.BackColor = Color.FromKnownColor(KnownColor.Window);
                textBox2.BorderStyle = BorderStyle.Fixed3D;
                textBox2.Text = "";
                textBox5.Text = "";
                label2.Text = "";
                label3.Text = "";
                label5.Text = "";
                label6.Text = "";
                label8.Text = "";
                label14.Text = "";
                label13.Text = "";
                label12.Text = "";
                label4.Text = "";
                textBox4.Text = "";
                textBox3.Text = "";
                textBox7.Text = TextTmpPayNum;
                comboBox2.SelectedIndex = -1;
            }
        }

        // 事業選択ボタンクリック
        private void button5_Click_1(object sender, EventArgs e)
        {
            frmSeaBusinessName frm = new frmSeaBusinessName();
            frm.InputBusinessCD = label2.Text;
            frm.InputBusinessName = label3.Text;
            frm.InputBillCD = label5.Text;
            frm.SearchBusinessName = label3.Text;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
            label2.Text = frm.InputBusinessCD;
            label3.Text = frm.InputBusinessName;
            label5.Text = frm.InputBillCD;
        }

        // 支払先選択ボタンクリック
        private void button6_Click(object sender, EventArgs e)
        {
            frmSeaPaymentDest frm2 = new frmSeaPaymentDest();
            frm2.MultiSelection = false;
            frm2.InputClientCD = label6.Text;
            frm2.InputClientName = label8.Text;
            frm2.CorpoIndiID = 2;
            frm2.SearchClientName = label8.Text;
            frm2.SelectedClientRow = -1;
            frm2.StartPosition = FormStartPosition.CenterParent;
            frm2.ShowDialog(this);
            label6.Text = frm2.InputClientCD;
            label8.Text = frm2.InputClientName;
        }

        // 銀行選択ボタンクリック
        private void button7_Click(object sender, EventArgs e)
        {
            using (frmSearchBank frm = new frmSearchBank())
            {
                frm.OldBankCD = this.label14.Text;
                frm.OldBank = this.label13.Text;
                frm.OldBranchCD = this.label12.Text;
                frm.OldBranch = this.label4.Text;
                frm.isBankCanceled = true;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog(this);
                if (frm.isBankCanceled)
                {
                    this.label14.Text = frm.OldBankCD;
                    this.label13.Text = frm.OldBank;
                    this.label12.Text = frm.OldBranchCD;
                    this.label4.Text = frm.OldBranch;
                }
                else
                {
                    this.label14.Text = frm.TextBankCD;
                    this.label13.Text = frm.TextBank;
                    this.label12.Text = frm.TextBranchCD;
                    this.label4.Text = frm.TextBranch;
                }
                this.textBox4.Focus();
            }
        }

        // 一覧へ戻るボタンクリック
        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        // 仕訳データ生成ボタンクリック
        private void button9_Click_1(object sender, EventArgs e)
        {
            //label1.Text = "0000000";
            //comboBox9.Text = "仮払い";
            //textBox9.Text = "1,500,000";
            ////label6.TextAlign=ContentAlignment.TopRight;
            //label7.Text = "1,500,000";
            ////label7.TextAlign = ContentAlignment.TopRight;
            //label15.Text = "1111111";
            //comboBox6.Text = "預金（三井住友）";
            //textBox12.Text = "1,500,000";
            ////label10.TextAlign = ContentAlignment.TopRight;
            //label11.Text = "1,500,000";
            ////label11.TextAlign = ContentAlignment.TopRight;
            //button10.Enabled = true;
        }

        // 仮払方法コンボボックス値変更
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                button8.Text = "銀行振込依頼\r\nデータ作成";
                button7.Enabled = true;
                textBox4.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                textBox3.Enabled = true;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                button8.Text = "仮払い金受領書\r\n発行";
                button7.Enabled = false;
                textBox4.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                textBox3.Enabled = false;
            }
        }

        // 一時保存ボタンクリック
        private void button1_Click(object sender, EventArgs e)
        {
            using (frmTempSave frm2 = new frmTempSave())
            {
                frm2.TmpSaveFlg = "";
                frm2.StartPosition = FormStartPosition.CenterParent;
                frm2.ShowDialog(this);
                if (frm2.TmpSaveFlg != "")
                {
                    this.Close();
                    this.Dispose();
                }
            }
        }

        // 銀行振込依頼データ作成・仮払い金受領書発行ボタンクリック
        private void button8_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        // 振込元口座コンボボックスマウスオーバー
        private void comboBox2_MouseHover(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                ToolTip1 = new ToolTip(this.components);
                ToolTip1.InitialDelay = 500;
                ToolTip1.ReshowDelay = 1000;
                ToolTip1.AutoPopDelay = 10000;
                ToolTip1.ShowAlways = true;
                ToolTip1.SetToolTip(comboBox2, comboBox2.SelectedValue.ToString());
            }
        }
    }
}
