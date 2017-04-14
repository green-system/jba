using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JBA_BizSupport
{
    public partial class frmIndivRecExpense1 : Form
    {
        ToolTip ToolTip1;

        public frmIndivRecExpense1()
        {
            InitializeComponent();
        }

        // フォームロード
        private void frmIndivRecExpense1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'jBADBDataSet.GAMA_HIMOKU' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.gAMA_HIMOKUTableAdapter.Fill(this.jBADBDataSet.GAMA_HIMOKU);
            // TODO: このコード行はデータを 'jBADBDataSet.GAMA_BUSINESS' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.gAMA_BUSINESSTableAdapter.Fill(this.jBADBDataSet.GAMA_BUSINESS);
            // 列ヘッダの背景色の変更
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.PeachPuff;
            // 精算方法のデフォルト値挿入
            comboBox16.Text = "振込";
            dataGridView1.Columns["PRICE"].ValueType = typeof(int);
            dataGridView1.Columns["DEPOSIT"].ValueType = typeof(int);
            textBox12.Text = "0";
            textBox13.Text = "0";
            dateTimePicker1.Value = DateTime.Now;
            label7.Text = "";
            label9.Text = "";

        }

        // 一覧へ戻るボタンクリック
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        // 仮払先選択ボタンクリック
        private void button6_Click(object sender, EventArgs e)
        {
            frmSeaTempDest1 frm1 = new frmSeaTempDest1();
            frm1.StartPosition = FormStartPosition.CenterParent;
            frm1.ShowDialog(this);
        }

        // 銀行選択ボタンクリック
        private void button7_Click(object sender, EventArgs e)
        {
            using (frmSearchBank frm = new frmSearchBank())
            {
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog(this);
                this.label6.Text = frm.TextBankCD;
                this.label7.Text = frm.TextBank;
                this.label8.Text = frm.TextBranchCD;
                this.label9.Text = frm.TextBranch;
                this.textBox9.Focus();
            }
        }

        // 住所検索ボタンクリック
        private void button10_Click(object sender, EventArgs e)
        {
            if (this.maskedTextBox1.Text.Replace("-", "").Replace(" ", "") != "")
            {
                using (frmSeaAddress frm2 = new frmSeaAddress())
                {
                    frm2.InputText = this.maskedTextBox1.Text;
                    frm2.InputAddress = this.textBox7.Text;
                    frm2.StartPosition = FormStartPosition.CenterParent;
                    frm2.ShowDialog(this);
                    this.maskedTextBox1.Text = frm2.InputText;
                    this.textBox7.Text = frm2.InputAddress;
                    this.textBox7.Focus();
                }
            }
        }

        //支払先選択ボタン
        private void button12_Click(object sender, EventArgs e)
        {
            frmSeaPaymentDest frm2 = new frmSeaPaymentDest();
            frm2.MultiSelection = false;
            frm2.CorpoIndiID = 2;
            if (textBox5.Text == "SearchClientName")
            {
                frm2.SearchClientName = "";
            }
            else
            {
                frm2.SearchClientName = textBox5.Text;
            }
            if (textBox11.Text == "SelectedClientRow")
            {
                frm2.SelectedClientRow = -1;
            }
            else
            {
                frm2.SelectedClientRow = int.Parse(textBox11.Text);
            }
            frm2.StartPosition = FormStartPosition.CenterParent;
            frm2.ShowDialog(this);
            // 支払先を複数選択する場合はfrm2.MultiSelectionにtrueが入る
            if (frm2.MultiSelection)
            {
                textBox5.Text = frm2.SearchClientName;
                textBox11.Text = frm2.SelectedClientRow.ToString();
                var cnt = this.dataGridView1.Rows.Count + 1;
                this.dataGridView1.Rows.Add("削除", cnt.ToString("D3"), "0001", "0001", frm2.InputClientCD, frm2.InputClientName, false, "0001", "", 0, "0001", 0, DateTime.Now);
                //// 金額列と内預り金列のフォーマット変更
                //dataGridView1[9,cnt - 1].Style.Format = "#,0";
                //dataGridView1[11,cnt - 1].Style.Format = "#,0";
                // 追加した行を選択状態にして、その行までスクロール
                this.dataGridView1.Rows[cnt-1].Selected = true;
                this.dataGridView1.FirstDisplayedScrollingRowIndex = cnt-1;
                button12.PerformClick();
            }
        }

        // PCA仕訳伝票タブクリック
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 選択されたタブの番号を取得
            int selectedIndex = tabControl1.SelectedIndex + 1;

            // 全タブページ数を取得
            int allIndexCnt = tabControl1.TabPages.Count;

            // 最後のタブが選択された場合タブ新規追加
            if (selectedIndex == allIndexCnt)
            {
                TabPage tab = new TabPage("+追加");
                tabControl1.TabPages.Add(tab);
                tabControl1.TabPages[selectedIndex - 1].Text = selectedIndex.ToString() + "回目";
                tabControl1.TabPages[selectedIndex - 1].Controls.Add(new UserControl8());
                // 「UserControl」を含むコントロールを検索
                Control target = null;
                foreach (Control c in tabControl1.TabPages[selectedIndex - 1].Controls)
                {
                    if (c.Name.IndexOf("UserControl") >= 0)
                    {
                        target = c;
                        break;
                    }
                }

                if (target != null)
                {
                    string ctl = target.Name;
                    tabControl1.TabPages[selectedIndex - 1].Controls[ctl].Location = new Point(-7, -9);
                }
            }
        }

        // 郵便番号テキストボックス内Enterキー押下
        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button10.PerformClick();
            }
        }

        // 一時保存ボタンクリック
        private void button17_Click(object sender, EventArgs e)
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

        // 銀行振込依頼・仮払金受領書発行ボタンクリック
        private void button8_Click(object sender, EventArgs e)
        {
            button17.Enabled = false;
        }

        // 精算方法コンボボックス変更
        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox16.SelectedIndex == 0)
            {
                button8.Text = "銀行振込依頼\r\nデータ作成";
                comboBox2.Enabled = true;
            }
            else if (comboBox16.SelectedIndex == 1)
            {
                button8.Text = "仮払い金受領書\r\n発行";
                comboBox2.Enabled = false;
            }
        }

        // 振込元口座マウスオーバー
        private void comboBox2_MouseHover(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                ToolTip1 = new ToolTip(this.components);
                ToolTip1.InitialDelay = 500;
                ToolTip1.ReshowDelay = 1000;
                ToolTip1.AutoPopDelay = 10000;
                ToolTip1.ShowAlways = true;
                ToolTip1.SetToolTip(comboBox2, comboBox2.SelectedItem.ToString());
            }
        }

        // 仮払い有無ラジオボタン変更
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                button6.Enabled = true;
            }
        }

        // 仮払い有無ラジオボタン変更
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                button6.Enabled = false;
            }
        }

        // データグリッドビュー内クリック
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 削除ボタン列かどうかを確認
            if (dataGridView1.Columns[e.ColumnIndex].Name == "DelBtn" && e.RowIndex != -1)
            {
                if (DialogResult.Yes == MessageBox.Show("削除しますか", "確認",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    // 削除
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                    // 項番振り直し
                    var cnt = 1;
                    foreach (var row in dataGridView1.Rows.Cast<DataGridViewRow>())
                    {
                        row.Cells[1].Value = cnt.ToString("D3");
                        cnt++;
                    }
                    // 金額合計再計算
                    var total = 0;
                    foreach (var row in dataGridView1.Rows.Cast<DataGridViewRow>())
                    {
                        total = total + int.Parse(row.Cells[9].Value.ToString());
                    }
                    textBox12.Text = total.ToString("#,0");
                    // 内預り金合計再計算
                    var subtotal = 0;
                    foreach (var row in dataGridView1.Rows.Cast<DataGridViewRow>())
                    {
                        subtotal = subtotal + int.Parse(row.Cells[11].Value.ToString());
                    }
                    textBox13.Text = subtotal.ToString("#,0");
                }
            }
            //// 適用列かどうかを確認
            //if (dataGridView1.Columns[e.ColumnIndex].Name == "APPLICATION" && e.RowIndex != -1)
            //{
            //    dataGridView1.ImeMode= ImeMode.On;
            //}
        }

        // データグリッドビュー行追加
        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.button12.PerformClick();
        }

        // データグリッドビュー内セル値変更
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // 事業名称列かどうかを確認
            if (dataGridView1.Columns[e.ColumnIndex].Name == "BUSINESS_NAME" && e.RowIndex != -1)
            {
                dataGridView1.Rows[e.RowIndex].Cells[2].Value = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            }
            try {
            // 金額列かどうかを確認
                if (dataGridView1.Columns[e.ColumnIndex].Name == "PRICE" && e.RowIndex != -1)
                {
                    // カンマ区切りフォーマット変更
                    //dataGridView1.Columns["PRICE"].DefaultCellStyle.Format = "#,0";
                    //dataGridView1[9, e.RowIndex].Style.Format = "#,0";
                    // 合計計算
                    var total = 0;
                    foreach (var row in dataGridView1.Rows.Cast<DataGridViewRow>())
                    {
                        //if (string.IsNullOrEmpty(row.Cells[9].Value as string))
                        //if (int.Parse(row.Cells[9].Value.ToString()) == 0)
                        if (row.Cells[9].Value == null || Convert.ToString(row.Cells[9].Value) == "")
                        {
                            row.Cells[9].Value = 0;
                        }
                        else
                        {
                            total = total + int.Parse(row.Cells[9].Value.ToString());
                            //total = total + int.Parse((string)row.Cells[9].Value);
                        }
                    }
                    textBox12.Text = total.ToString("#,0");
                }
                // 内預り金列かどうかを確認
                if (dataGridView1.Columns[e.ColumnIndex].Name == "DEPOSIT" && e.RowIndex != -1)
                {
                    // カンマ区切りフォーマット変更
                    //dataGridView1.Columns["DEPOSIT"].DefaultCellStyle.Format = "#,0";
                    //dataGridView1[11, e.RowIndex].Style.Format = "#,0";
                    // 合計計算
                    var subtotal = 0;
                    foreach (var row in dataGridView1.Rows.Cast<DataGridViewRow>())
                    {
                        //if (string.IsNullOrEmpty(row.Cells[11].Value as string))
                        if (row.Cells[11].Value == null || Convert.ToString(row.Cells[11].Value) == "")
                        {
                            row.Cells[11].Value = 0;
                        }
                        else
                        {
                            subtotal = subtotal + int.Parse(row.Cells[11].Value.ToString());
                            //subtotal = subtotal + int.Parse((string)row.Cells[11].Value);
                        }
                    }
                    textBox13.Text = subtotal.ToString("#,0");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("数値を入力してください。","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw;
            }
            //// 支払日列かどうかを確認
            //if (dataGridView1.Columns[e.ColumnIndex].Name == "PAYMENT_DATE" && e.RowIndex != -1)
            //{
            //    dataGridView1[12, e.RowIndex].Value = String.Format("{0:yyyy/MM/dd}", dataGridView1[12, e.RowIndex].Value);
            //}
        }

        // データグリッドビューCellDirtyState変更
        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
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
                if (dgv.CurrentCell.OwningColumn.Name == "PRICE" || dgv.CurrentCell.OwningColumn.Name == "DEPOSIT")
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

        // 精算依頼書からのインポートボタンンクリック
        private void button11_Click(object sender, EventArgs e)
        {

        }

        // 新規登録ボタンクリック
        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
