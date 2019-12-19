using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace 日常安排应用
{
    class SqlHelper
    {
        public static SQLiteConnection CyCon()
        {
            string fileName = "./DB/schedule.db";
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + fileName);
            return conn;
        }

        public static void sqlExecute(string sql, string message1, string message2)
        {
            SQLiteConnection conn = SqlHelper.CyCon();
            try
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(message1);
            }
            catch (Exception)
            {
                MessageBox.Show(message2);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
