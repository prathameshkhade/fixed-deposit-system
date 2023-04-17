using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Bank_FD_management
{
    static class Program
    {
        internal static frmLogin login = new frmLogin();

        internal static ErrorProvider err = new ErrorProvider();
        internal static string myConn = "Provider=Microsoft.ACE.Oledb.12.0; Data Source=../../../DB/Data.accdb";
        internal static OleDbConnection conn = new OleDbConnection(myConn);

        internal static void setConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(login);
        }
    }
}
