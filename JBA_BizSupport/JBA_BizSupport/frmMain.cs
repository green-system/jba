using System;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace JBA_BizSupport
{
    public partial class frmMain : Form
    {
        // Win32APIの GetPrivateProfileString を使う宣言
        [DllImport("KERNEL32.DLL")]
        public static extern uint
          GetPrivateProfileString(string lpAppName,
          string lpKeyName, string lpDefault,
          StringBuilder lpReturnedString, uint nSize,
          string lpFileName);

        public frmMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //// メインメソッドから設定されるメンバー
        //public string Argument; // コマンドライン引数の内容

        // フォームの起動時に実行されるイベントプロシージャ
        private void frmMain_Load(object sender, EventArgs e)
        {
                // iniファイル名を決める（実行ファイルが置かれたフォルダと同じ場所）
                string iniFileName = AppDomain.CurrentDomain.BaseDirectory + "jbabizsupport.ini";

                // iniファイルから文字列を取得
                StringBuilder sb = new StringBuilder(1024);
                GetPrivateProfileString(
                    "section_1",                    // セクション名
                    "argument",                     // キー名    
                    "ありません",                   // 値が取得できなかった場合に返される初期値
                    sb,                             // 格納先
                    Convert.ToUInt32(sb.Capacity),  // 格納先のキャパ
                    iniFileName);                   // iniファイル名
                    Program.Argument = sb.ToString();

            // コマンドライン引数が入力設定されていない場合
            if (Program.Argument == "" || Program.Argument == "0")
            {
                this.button3.Enabled = true;
            }
            // コマンドライン引数が1の場合
            else if (Program.Argument == "1")
            {
                this.button3.Enabled = false;
            }
            // コマンドライン引数が2の場合
            else if (Program.Argument == "2")
            {
                MessageBox.Show("利用者権限がないためシステムを利用できません。システム管理者に連絡して利用者登録を行ってください。", "警告");
                //CancelEventArgsオブジェクトの作成
                System.ComponentModel.CancelEventArgs cea =
                    new System.ComponentModel.CancelEventArgs();

                //アプリケーション終了
                Application.Exit(cea);

                //アプリケーションの終了がキャンセルされたか調べる
                if (cea.Cancel)
                {
                    Console.WriteLine("キャンセルされました");
                }
            }
            else
            {
                MessageBox.Show("引数が不適切です", "警告");
                //CancelEventArgsオブジェクトの作成
                System.ComponentModel.CancelEventArgs cea =
                    new System.ComponentModel.CancelEventArgs();

                //アプリケーション終了
                Application.Exit(cea);

                //アプリケーションの終了がキャンセルされたか調べる
                if (cea.Cancel)
                {
                    Console.WriteLine("キャンセルされました");
                }
            }
        }

        // 費用計上管理システムボタンクリック
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmExpenseManage frm = new frmExpenseManage();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        // 請求書発行管理システムボタンクリック
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInvoiceManage frm = new frmInvoiceManage();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        // マスタメンテナンスボタンクリック
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMasterMaintenance frm = new frmMasterMaintenance();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        // 終了ボタンクリック
        private void button4_Click(object sender, EventArgs e)
        {
            //CancelEventArgsオブジェクトの作成
            System.ComponentModel.CancelEventArgs cea =
                new System.ComponentModel.CancelEventArgs();

            //アプリケーション終了
            Application.Exit(cea);

            //アプリケーションの終了がキャンセルされたか調べる
            if (cea.Cancel)
            {
                Console.WriteLine("キャンセルされました");
            }
        }
        //フォームのFormClosingイベントハンドラ
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exitではアプリケーションを終了できないようにする
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }
    }
}
