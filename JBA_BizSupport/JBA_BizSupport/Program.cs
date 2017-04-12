using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JBA_BizSupport
{
    static class Constants
    {
        // DB接続文字列
        public const string CONNECTIONSTRING = "Data Source=DNX31150\\SID1;Initial Catalog=JBADB;User ID=sa;Password=chib@pc2016";

    }
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmMain f1 = new frmMain();
            if (args.Length > 0)
            {
                f1.Argument = args[0];
            }
            else
            {
                f1.Argument = "";
            }
            Application.Run(f1);
        }
    }
}
