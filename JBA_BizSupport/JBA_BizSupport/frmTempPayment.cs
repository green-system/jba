using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JBA_BizSupport
{
    public partial class frmTempPayment : Form
    {
        public frmTempPayment()
        {
            InitializeComponent();
        }

        // フォームロード
        private void frmTempPayment_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'jBADBDataSet.GADA_TEMP_PAY' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.gADA_TEMP_PAYTableAdapter.Fill(this.jBADBDataSet.GADA_TEMP_PAY);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.PeachPuff;
            dataGridView1.Columns["TEMP_PAY_PRICE"].ValueType = typeof(int);
            label3.Text = this.jBADBDataSet.GADA_TEMP_PAY.Count.ToString() + "件";

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
            using (frmTempPayment1 frm2 = new frmTempPayment1())
            {
                frm2.ListButtonFLG = "CreateNewClick";
                try
                {
                    // 新規仮払番号採番
                    int tblTmpPaySeq = int.Parse(this.gADA_TEMP_PAYTableAdapter.ScalarQueryTmpPaySeq().ToString()) + 1;
                    frm2.TextTmpPayNum = "KR" + DateTime.Now.ToString("yyyy") + DateTime.Now.ToString("MM") + tblTmpPaySeq.ToString("D4");
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

                switch (RadioButtonChecked.Name)
                {
                    case "radioButton1": // 全ての仮払
                        this.gADA_TEMP_PAYTableAdapter.Fill(this.jBADBDataSet.GADA_TEMP_PAY);
                        break;
                    case "radioButton2": // 未精算の仮払
                        this.gADA_TEMP_PAYTableAdapter.FillByUnsettled(this.jBADBDataSet.GADA_TEMP_PAY, textBox1.Text);
                        break;
                    case "radioButton3": // 振込の仮払
                        this.gADA_TEMP_PAYTableAdapter.FillByTmpPayTransfer(this.jBADBDataSet.GADA_TEMP_PAY, textBox1.Text);
                        break;
                    case "radioButton4": // 現金の仮払
                        this.gADA_TEMP_PAYTableAdapter.FillByTmpPayCash(this.jBADBDataSet.GADA_TEMP_PAY, textBox1.Text);
                        break;
                    case "radioButton5": // 一時保存
                        this.gADA_TEMP_PAYTableAdapter.FillByTmpSave(this.jBADBDataSet.GADA_TEMP_PAY, textBox1.Text);
                        break;
                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                label3.Text = dataGridView1.BindingContext[dataGridView1.DataSource, dataGridView1.DataMember].Count.ToString() + "件";
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

        // データグリッドダブルクリック
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                using (frmTempPayment1 frm2 = new frmTempPayment1())
                {
                    frm2.ListButtonFLG = "GridDoubleClick";
                    frm2.TextTmpPayNum = dataGridView1[1, e.RowIndex].Value.ToString();
                    frm2.TextReqPersonName = dataGridView1[0, e.RowIndex].Value.ToString();
                    frm2.TextBizCD = dataGridView1[2, e.RowIndex].Value.ToString();
                    frm2.TextBizName = dataGridView1[3, e.RowIndex].Value.ToString();
                    frm2.IntBillID = int.Parse(dataGridView1[27, e.RowIndex].Value.ToString());
                    frm2.TextTmpPayPurpose = dataGridView1[4, e.RowIndex].Value.ToString();
                    frm2.TextClientCD = dataGridView1[7, e.RowIndex].Value.ToString();
                    frm2.TextClientName = dataGridView1[25, e.RowIndex].Value.ToString();
                    frm2.TextTmpPayOL = dataGridView1[14, e.RowIndex].Value.ToString();
                    frm2.IntTmpPayType = int.Parse(dataGridView1[8, e.RowIndex].Value.ToString());
                    frm2.IntTmpPayPrice = int.Parse(dataGridView1[5, e.RowIndex].Value.ToString());
                    frm2.DateTmpPayDay = DateTime.Parse(dataGridView1[6, e.RowIndex].Value.ToString());
                    frm2.TextBankCD = dataGridView1[15, e.RowIndex].Value.ToString();
                    frm2.TextBankName = dataGridView1[28, e.RowIndex].Value.ToString();
                    frm2.TextBranchCD = dataGridView1[16, e.RowIndex].Value.ToString();
                    frm2.TextBranchName = dataGridView1[29, e.RowIndex].Value.ToString();
                    frm2.TextAccountHolderKANA = dataGridView1[18, e.RowIndex].Value.ToString();
                    if (dataGridView1[17, e.RowIndex].Value is DBNull)
                    {
                        frm2.IntAccountType = 0;
                    }
                    else
                    {
                        frm2.IntAccountType = int.Parse(dataGridView1[17, e.RowIndex].Value.ToString());
                    }
                    frm2.TextAccountNum = dataGridView1[19, e.RowIndex].Value.ToString();
                    if (dataGridView1[20, e.RowIndex].Value is DBNull)
                    {
                        frm2.IntRecNumber = -1;
                    }
                    else
                    {
                        frm2.IntRecNumber = int.Parse(dataGridView1[20, e.RowIndex].Value.ToString()) - 1;
                    }

                    frm2.StartPosition = FormStartPosition.CenterParent;
                    frm2.ShowDialog(this);
                }
            }
        }

        // 選択ボタンクリック
        private void button4_Click(object sender, EventArgs e)
        {
            using (frmTempPayment1 frm2 = new frmTempPayment1())
            {
                if (dataGridView1.CurrentCell != null)
                {
                    frm2.ListButtonFLG = "ButtonClick";
                    frm2.TextTmpPayNum = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    frm2.TextReqPersonName = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    frm2.TextBizCD = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    frm2.TextBizName = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    frm2.IntBillID = int.Parse(dataGridView1[27, dataGridView1.CurrentCell.RowIndex].Value.ToString());
                    frm2.TextTmpPayPurpose = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    frm2.TextClientCD = dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    frm2.TextClientName = dataGridView1[25, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    frm2.TextTmpPayOL = dataGridView1[14, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    frm2.IntTmpPayType = int.Parse(dataGridView1[8, dataGridView1.CurrentCell.RowIndex].Value.ToString());
                    frm2.IntTmpPayPrice = int.Parse(dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString());
                    frm2.DateTmpPayDay = DateTime.Parse(dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value.ToString());
                    frm2.TextBankCD = dataGridView1[15, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    frm2.TextBankName = dataGridView1[28, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    frm2.TextBranchCD = dataGridView1[16, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    frm2.TextBranchName = dataGridView1[29, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    frm2.TextAccountHolderKANA = dataGridView1[18, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    if (dataGridView1[17, dataGridView1.CurrentCell.RowIndex].Value is DBNull)
                    {
                        frm2.IntAccountType = 0;
                    }
                    else
                    {
                        frm2.IntAccountType = int.Parse(dataGridView1[17, dataGridView1.CurrentCell.RowIndex].Value.ToString());
                    }
                    frm2.TextAccountNum = dataGridView1[19, dataGridView1.CurrentCell.RowIndex].Value.ToString();

                    frm2.StartPosition = FormStartPosition.CenterParent;
                    frm2.ShowDialog(this);
                }
            }
        }

        // データグリッド内Enterキー押下
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button4.PerformClick();
            }
        }

    }
}
