using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JBA_BizSupport
{
    public partial class frmCorpRecExpense : Form
    {
        public frmCorpRecExpense()
        {
            InitializeComponent();
        }

        private void frmCorpRecExpense_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'jBADBDataSet.GAMA_ADDRESS' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.gAMA_ADDRESSTableAdapter.Fill(this.jBADBDataSet.GAMA_ADDRESS);
            ////コントロールのサイズを適当に変更
            //button1.SetBounds(0, 0, 101, 101);
            ////多角形の頂点の位置を設定
            //Point[] points = {
            //    new Point(0, 0),
            //    new Point(50, 50),
            //    new Point(100, 50),
            //    new Point(50, 0)};
            //byte[] types =
            //    {(byte) System.Drawing.Drawing2D.PathPointType.Line,
            //    (byte) System.Drawing.Drawing2D.PathPointType.Line,
            //    (byte) System.Drawing.Drawing2D.PathPointType.Line,
            //    (byte) System.Drawing.Drawing2D.PathPointType.Line};
            ////GraphicsPathの作成
            //System.Drawing.Drawing2D.GraphicsPath path =
            //    new System.Drawing.Drawing2D.GraphicsPath(points, types);
            ////コントロールの形を変更
            //button1.Region = new Region(path);

            button1.SetBounds(805, 16, 30, 30, BoundsSpecified.Size);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            //丸を描く
            path.AddEllipse(new Rectangle(0, 0, 30, 30));
            button1.Region = new Region(path);

            // TODO: このコード行はデータを 'jBADBDataSet11.GAVA_ADDRESS' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.GAVA_ADDRESSTableAdapter.Fill(this.jBADBDataSet11.GAVA_ADDRESS);
            //this.dataGridView3.AutoGenerateColumns = false;

            //DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn();
            //textColumn.DataPropertyName = "Address";
            //textColumn.Name = "Address";
            //textColumn.HeaderText = "住所";
            //this.dataGridView3.Columns.Add(textColumn);

            // TODO: このコード行はデータを 'jBADBDataSet1.住所マスタ' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.住所マスタTableAdapter.Fill(this.jBADBDataSet1.住所マスタ);
            // TODO: このコード行はデータを 'jBADBDataSet.住所マスタ' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.住所マスタTableAdapter.Fill(this.jBADBDataSet.住所マスタ);
            // 列ヘッダの背景色の変更
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.PeachPuff;


            //Bitmap image1 = new Bitmap("C:\\Work\\temp\\delete.png");
            //DataGridViewErrorIconColumnを作成
            //DataGridViewErrorIconColumn iconColumn =
            //    new DataGridViewErrorIconColumn();
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.PeachPuff;
            // DataGridView にデータを追加 
            this.dataGridView1.Rows.Add("削除", "山田　太郎", 28, "振込");
            this.dataGridView1.Rows.Add("削除", "鈴木　衛", 47, "振込");
            this.dataGridView1.Rows.Add("削除", "斉藤　花子", 32, "振込");
            this.dataGridView1.Rows.Add("削除", "田中　美恵", 50, "現金");
            //dataGridView1["DelBtn", 0].Value = new Bitmap("C:\\Work\\temp\\delete.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void addressMasterBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            //DataGridViewRow[] rows = (from DataGridViewRow x in dataGridView3.Rows
            //                          where (string)x.Cells[0].Value == "1940003"
            //                          select x).ToArray();
            //DataGridViewRowCollection rowList = null;
            //rowList = dataGridView3.Rows.Cast<DataGridViewRow>().Select(Rows => Rows.Cells[0].Value.Equals("1940003"));

            //this.GAVA_ADDRESSTableAdapter.Fill(this.jBADBDataSet11.GAVA_ADDRESS);

            //string connectionString = "Data Source=DNX31150\\SID1;Initial Catalog=JBADB;User ID=sa;Password=chib@pc2016";
            //string sql = "SELECT * FROM dbo.GAVA_ADDRESS WHERE 郵便番号 LIKE '" + maskedTextBox1.Text.Replace("-","").TrimEnd() + "%'";
            //SqlConnection connection = new SqlConnection(connectionString);
            //SqlDataAdapter GAVA_ADDRESSTableAdapter = new SqlDataAdapter(sql, connection);
            //DataSet ds = new DataSet();
            //connection.Open();
            //GAVA_ADDRESSTableAdapter.Fill(ds, "GAVA_ADDRESS");
            //connection.Close();
            //dataGridView3.DataSource = ds;
            //dataGridView3.DataMember = "GAVA_ADDRESS";

            SqlConnection connection = null;
            DataSet ds = null;

            // 接続文字列の取得
            //string connectionString = ConfigurationManager.ConnectionStrings["JBADBConnectionString"].ConnectionString;
            string connectionString = Constants.CONNECTIONSTRING;

            try
            {
                // データベース接続の準備
                connection = new SqlConnection(connectionString);
                string sql = "SELECT * FROM dbo.GAVA_ADDRESS WHERE ZIP_CODE LIKE '" + maskedTextBox1.Text.Replace("-","").TrimEnd() + "%'";
                SqlDataAdapter GAMA_ADDRESSTableAdapter = new SqlDataAdapter(sql, connection);
                ds = new DataSet();

                // データベースの接続開始
                connection.Open();

                // SQLの実行
                GAMA_ADDRESSTableAdapter.Fill(ds, "GAMA_ADDRESS");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
            finally
            {
                // データベースの接続終了
                connection.Close();
                dataGridView3.DataSource = ds;
                dataGridView3.DataMember = "GAVA_ADDRESS";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 削除ボタン列かどうかを確認 
            if (e.ColumnIndex == this.dataGridView1.Columns["DelBtn"].Index && e.RowIndex != -1)
            {
                if (DialogResult.Yes == MessageBox.Show("削除しますか", "確認",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    // 削除 
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add("削除", "田中　美恵", 50, "現金");
            var cnt = this.dataGridView1.Rows.Count - 1;
            this.dataGridView1.Rows[cnt].Selected = true;
            this.dataGridView1.FirstDisplayedScrollingRowIndex = cnt;
        }
    }
}
