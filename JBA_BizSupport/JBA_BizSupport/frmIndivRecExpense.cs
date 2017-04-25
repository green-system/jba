using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JBA_BizSupport
{
    public partial class frmIndivRecExpense : Form
    {
        public frmIndivRecExpense()
        {
            InitializeComponent();
        }

        // フォームロード
        private void frmIndivRecExpense_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'jBADBDataSet.GADA_ADJUSTMENT' テーブルに読み込みます。
            // コマンドライン引数が入力設定されていない場合、非公開案件表示
            if (Program.Argument == "" || Program.Argument == "0")
            {
                this.gADA_ADJUSTMENTTableAdapter.FillByEmpty(this.jBADBDataSet.GADA_ADJUSTMENT);
            }
            // コマンドライン引数が1の場合、非公開案件非表示
            else if (Program.Argument == "1")
            {
                this.gADA_ADJUSTMENTTableAdapter.FillByPublicFlgEmpty(this.jBADBDataSet.GADA_ADJUSTMENT, false);
            }

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.PeachPuff;
            label3.Text = this.jBADBDataSet.GADA_ADJUSTMENT.Count.ToString() + "件";
            // 一部支払いが終わっていない精算番号の行を黄色にする
            PaintPartialAdjustment();
        }

        // メニューへ戻るボタンクリック
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        // 新規作成ボタンクリック
        private void button1_Click(object sender, EventArgs e)
        {
            using (frmIndivRecExpense1 frm2 = new frmIndivRecExpense1())
            {
                frm2.ListButtonFLG = "CreateNewClick";
                try
                {
                    // 新規精算番号採番
                    int tblAdjustmentSeq = int.Parse(this.gADA_ADJUSTMENTTableAdapter.ScalarQueryAdjustmentSeq().ToString()) + 1;
                    frm2.TextAdjustNum = "SK" + DateTime.Now.ToString("yyyy") + DateTime.Now.ToString("MM") + tblAdjustmentSeq.ToString("D4");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    throw;
                }
                frm2.StartPosition = FormStartPosition.CenterParent;
                frm2.ShowDialog(this);
            }
        }

        // 検索ボタンクリック
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // 指定したグループ内のラジオボタンでチェックされている物を取り出す
                var RadioButtonChecked = panel1.Controls.OfType<RadioButton>()
                    .SingleOrDefault(rb => rb.Checked == true);

                if (textBox1.Text == "")
                {
                    switch (RadioButtonChecked.Name)
                    {
                        case "radioButton1": // 全件
                            if (Program.Argument == "" || Program.Argument == "0")
                            {
                                this.gADA_ADJUSTMENTTableAdapter.FillByEmpty(this.jBADBDataSet.GADA_ADJUSTMENT);
                            }
                            // コマンドライン引数が1の場合、非公開案件非表示
                            else if (Program.Argument == "1")
                            {
                                this.gADA_ADJUSTMENTTableAdapter.FillByPublicFlgEmpty(this.jBADBDataSet.GADA_ADJUSTMENT, false);
                            }
                            break;
                        case "radioButton2": // 未精算
                            if (Program.Argument == "" || Program.Argument == "0")
                            {
                                this.gADA_ADJUSTMENTTableAdapter.FillByUnsettledEmpty(this.jBADBDataSet.GADA_ADJUSTMENT);
                            }
                            // コマンドライン引数が1の場合、非公開案件非表示
                            else if (Program.Argument == "1")
                            {
                                this.gADA_ADJUSTMENTTableAdapter.FillByUnsettledPublicFlgEmpty(this.jBADBDataSet.GADA_ADJUSTMENT, false);
                            }
                            break;
                        case "radioButton3": // 一部精算済み
                            if (Program.Argument == "" || Program.Argument == "0")
                            {
                                this.gADA_ADJUSTMENTTableAdapter.FillByPartialEmpty(this.jBADBDataSet.GADA_ADJUSTMENT);
                            }
                            // コマンドライン引数が1の場合、非公開案件非表示
                            else if (Program.Argument == "1")
                            {
                                this.gADA_ADJUSTMENTTableAdapter.FillByPartialPublicFlgEmpty(this.jBADBDataSet.GADA_ADJUSTMENT, false);
                            }
                            break;
                        case "radioButton5": // 一時保存
                            if (Program.Argument == "" || Program.Argument == "0")
                            {
                                //this.gADA_ADJUSTMENTTableAdapter.FillByTmpSaveEmpty(this.jBADBDataSet.GADA_TEMP_PAY);
                                //ダミー設定
                                this.gADA_ADJUSTMENTTableAdapter.FillByPartialPublicFlgEmpty(this.jBADBDataSet.GADA_ADJUSTMENT, false);
                            }
                            // コマンドライン引数が1の場合、非公開案件非表示
                            else if (Program.Argument == "1")
                            {
                            }
                            break;
                    }
                }
                else
                {
                    switch (RadioButtonChecked.Name)
                    {
                        case "radioButton1": // 全件
                            if (Program.Argument == "" || Program.Argument == "0")
                            {
                                this.gADA_ADJUSTMENTTableAdapter.Fill(this.jBADBDataSet.GADA_ADJUSTMENT, textBox1.Text);
                            }
                            // コマンドライン引数が1の場合、非公開案件非表示
                            else if (Program.Argument == "1")
                            {
                                this.gADA_ADJUSTMENTTableAdapter.FillByPublicFlg(this.jBADBDataSet.GADA_ADJUSTMENT, false, textBox1.Text);
                            }
                            break;
                        case "radioButton2": // 未精算
                            if (Program.Argument == "" || Program.Argument == "0")
                            {
                                this.gADA_ADJUSTMENTTableAdapter.FillByUnsettled(this.jBADBDataSet.GADA_ADJUSTMENT, textBox1.Text);
                            }
                            // コマンドライン引数が1の場合、非公開案件非表示
                            else if (Program.Argument == "1")
                            {
                                this.gADA_ADJUSTMENTTableAdapter.FillByUnsettledPublicFlg(this.jBADBDataSet.GADA_ADJUSTMENT, false, textBox1.Text);
                            }
                            break;
                        case "radioButton3": // 一部精算済み
                            if (Program.Argument == "" || Program.Argument == "0")
                            {
                                this.gADA_ADJUSTMENTTableAdapter.FillByPartial(this.jBADBDataSet.GADA_ADJUSTMENT, textBox1.Text);
                            }
                            // コマンドライン引数が1の場合、非公開案件非表示
                            else if (Program.Argument == "1")
                            {
                                this.gADA_ADJUSTMENTTableAdapter.FillByPartialPublicFlg(this.jBADBDataSet.GADA_ADJUSTMENT, false, textBox1.Text);
                            }
                            break;
                        case "radioButton5": // 一時保存
                            if (Program.Argument == "" || Program.Argument == "0")
                            {
                                //this.gADA_ADJUSTMENTTableAdapter.FillByTmpSave(this.jBADBDataSet.GADA_TEMP_PAY, textBox1.Text);
                                //ダミー設定
                                this.gADA_ADJUSTMENTTableAdapter.FillByPartialPublicFlgEmpty(this.jBADBDataSet.GADA_ADJUSTMENT, false);
                            }
                            // コマンドライン引数が1の場合、非公開案件非表示
                            else if (Program.Argument == "1")
                            {
                            }
                            break;
                    }
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                label3.Text = dataGridView1.BindingContext[dataGridView1.DataSource, dataGridView1.DataMember].Count.ToString() + "件";
                // 検索結果表示後に一部支払いが終わっていない精算番号の行を黄色にする
                PaintPartialAdjustment();
            }
        }

        // 選択ボタンクリック
        private void button4_Click(object sender, EventArgs e)
        {

        }

        // 列ヘッダークリック時ソート後
        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            // ソート後に一部支払いが終わっていない精算番号の行を黄色にする
            PaintPartialAdjustment();
        }

        // 一部支払いが終わっていない精算番号の行を黄色にする
        void PaintPartialAdjustment()
        {
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.BackColor = Color.Yellow;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                // 未精算の行数（payment_flg）が0ではなく、さらに同一精算番号の行数（adjustment_row_cnt）とも等しくないときに一部精算済みとなる
                int PaymentFlg = int.Parse(dataGridView1[0, i].Value.ToString());       // 未精算の行数
                int AdjustmentRowCnt = int.Parse(dataGridView1[1, i].Value.ToString()); // 同一精算番号の行数
                if (PaymentFlg != 0 && PaymentFlg != AdjustmentRowCnt)
                    dataGridView1.Rows[i].DefaultCellStyle = cellStyle;
            }
        }

        // 検索窓内Enterキー押下
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button2.PerformClick();
            }
        }

        // データグリッドダブルクリック
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                using (frmIndivRecExpense1 frm2 = new frmIndivRecExpense1())
                {
                    frm2.ListButtonFLG = "GridDoubleClick";
                    frm2.TextAdjustNum = dataGridView1[3, e.RowIndex].Value.ToString();
                    frm2.TextBizCDAdj = dataGridView1[4, e.RowIndex].Value.ToString();
                    frm2.TextBizItemName = dataGridView1[5, e.RowIndex].Value.ToString();
                    frm2.IntBillID = int.Parse(dataGridView1[6, e.RowIndex].Value.ToString());
                    frm2.TextTmpPayNum = dataGridView1[9, e.RowIndex].Value.ToString();
                    //frm2.TextBizCDTmp = dataGridView1[24, e.RowIndex].Value.ToString();
                    //frm2.TextBizNameTmp = dataGridView1[25, e.RowIndex].Value.ToString();
                    //frm2.TextTmpPayPurpose = dataGridView1[26, e.RowIndex].Value.ToString();
                    //frm2.IntTmpPayPrice = int.Parse(dataGridView1[27, e.RowIndex].Value.ToString());
                    //frm2.DateTmpPayDay = DateTime.Parse(dataGridView1[28, e.RowIndex].Value.ToString());
                    //frm2.TextClientCDTmp = dataGridView1[29, e.RowIndex].Value.ToString();
                    //frm2.TextClientNameTmp = dataGridView1[30, e.RowIndex].Value.ToString();
                    frm2.DateAdjustDay = DateTime.Parse(dataGridView1[10, e.RowIndex].Value.ToString());
                    //frm2.DateTransferDay = DateTime.Parse(dataGridView1[21, e.RowIndex].Value.ToString());
                    //frm2.DateJournalDay = DateTime.Parse(dataGridView1[22, e.RowIndex].Value.ToString());
                    frm2.DateTransferDay = DateTime.Now;    // ダミー
                    frm2.DateJournalDay = DateTime.Now;     // ダミー
                    frm2.DatePCAOutputDay = DateTime.Parse(dataGridView1[23, e.RowIndex].Value.ToString());
                    frm2.IntAdjPayType = int.Parse(dataGridView1[11, e.RowIndex].Value.ToString());
                    frm2.TextBankCD = dataGridView1[12, e.RowIndex].Value.ToString();
                    frm2.TextBankName = dataGridView1[24, e.RowIndex].Value.ToString();
                    frm2.TextBranchCD = dataGridView1[13, e.RowIndex].Value.ToString();
                    frm2.TextBranchName = dataGridView1[25, e.RowIndex].Value.ToString();
                    frm2.TextAccountHolderKANA = dataGridView1[15, e.RowIndex].Value.ToString();
                    if (dataGridView1[14, e.RowIndex].Value is DBNull)
                    {
                        frm2.IntAccountType = 0;
                    }
                    else
                    {
                        frm2.IntAccountType = int.Parse(dataGridView1[14, e.RowIndex].Value.ToString());
                    }
                    frm2.TextAccountNum = dataGridView1[16, e.RowIndex].Value.ToString();
                    if (dataGridView1[17, e.RowIndex].Value is DBNull)
                    {
                        frm2.IntRecNumber = -1;
                    }
                    else
                    {
                        frm2.IntRecNumber = int.Parse(dataGridView1[17, e.RowIndex].Value.ToString()) - 1;
                    }

                    frm2.StartPosition = FormStartPosition.CenterParent;
                    frm2.ShowDialog(this);
                }
            }
        }
    }
}
