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
    public partial class FormLogin : Skin_DevExpress
    {
        public string userName = "";
        public int power = 2;
        public string passWord = "";
        private int isRememberPassWd = 0;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // 检查没有问题
            if (checkInfo(this.textBoxUserName.Text.ToString().Trim(), this.textBoxPassWord.Text.ToString().Trim()))
            {
                // 勾选 记住密码
                if (this.checkBox1.Checked)
                {
                    updateUserBindPassWd();
                }
                // 欢迎窗口
                MessageBox.Show("欢迎" + this.textBoxUserName.Text.ToString().Trim());
                // 跳转到FormMain
                FormMain formMain = new FormMain();
                formMain.power = power;
                formMain.userName = this.textBoxUserName.Text.Trim();
                this.Hide();
                formMain.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("请检查登录信息");
            }
        }

        private void updateUserBindPassWd()
        {
            SQLiteConnection conn = SqlHelper.CyCon();
            string sql = "update tb_user set is_remember_passwd=1";
            try
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("记住密码失败");
            }
            finally
            {
                conn.Close();
            }
        }
        private bool checkInfo(string userName, string passWord)
        {
            
            // userName  passWord数据检查
            if (this.isRememberPassWd == 0)
            {
                searchInfo(userName);
                if (this.passWord == passWord)
                {
                    
                    return true;
                }
                return false;
            } 
            else
            {
                return true;
            }
            
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void searchInfo(string userName)
        {
            SQLiteDataReader sdr = null;
            SQLiteConnection conn = SqlHelper.CyCon();
            string sql = "select * from tb_user";
            try
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    if (sdr["user_name"].ToString().Trim() == userName)
                    {
                        this.power = int.Parse(sdr["power"].ToString().Trim());
                        this.passWord = sdr["passwd"].ToString().Trim();
                        this.isRememberPassWd = int.Parse(sdr["is_remember_passwd"].ToString());
                    }
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("用户不存在"+ex);
            }
           finally
            {
                sdr.Close();
                conn.Close();
            }
        }

        private void textBoxUserName_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void textBoxUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 数据查找
                searchInfo(this.textBoxUserName.Text.ToString().Trim());
                if (this.isRememberPassWd == 1)
                {
                    this.textBoxPassWord.Text = this.passWord;
                }
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormRegister form =  new FormRegister();
            form.userName = this.textBoxUserName.Text.ToString().Trim();
            form.pForm = this;
            this.Hide();
            form.ShowDialog();
        }
    }
}
