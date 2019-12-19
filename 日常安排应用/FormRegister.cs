using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using CCWin;

namespace 日常安排应用
{
    public partial class FormRegister : Skin_DevExpress
    {
        public string userName;
        public Form pForm;
        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            
            this.pForm.Show();
            this.Close();

        }

        private void buttonSure_Click(object sender, EventArgs e)
        {
            string userName = this.textBoxUserName.Text.Trim();
            string passWd = this.textBoxPassWd.Text.Trim();
            // 检查用户名是否重复
            if (checkDuplcation(userName))
            {
                MessageBox.Show("用户名" + userName + "已存在");
            }
            else
            {
                SQLiteConnection conn = SqlHelper.CyCon();
                int super = 2;
                if (this.checkBox1.Checked)
                {
                    super = 1;
                }
                string sql = "insert into tb_user (user_name, passwd, power, is_remember_passwd) values ('" + userName + "', '" + passWd + "', " + super + ", " + 0 + ")";
                try
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("创建用户成功");

                }
                catch (Exception)
                {
                    MessageBox.Show("创建用户失败");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private bool checkDuplcation(string userName)
        {
            SQLiteDataReader sdr = null;
            SQLiteConnection conn = SqlHelper.CyCon();
            string sql = "select * from tb_user";
            bool flag = false;
            try
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                   if (sdr["user_name"].ToString().Trim() == userName)
                    {
                        flag = true;
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("查询发生错误");
            }
            finally
            {
                sdr.Close();
                conn.Close();
            }

            return flag;
        }
        private void FormRegister_Load(object sender, EventArgs e)
        {
            this.textBoxUserName.Text = this.userName;
        }
    }
}
