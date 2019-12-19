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
    
    public partial class FormModify : Skin_DevExpress
    {
        public string userName = "";
        public FormModify()
        {
            InitializeComponent();
        }

        private void FormModify_Load(object sender, EventArgs e)
        {
            this.textBoxName.Text = this.userName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("确定退出", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // 检查密码一致
            if (this.textBoxPassWd.Text != this.textBoxCheckPassWd.Text)
            {
                MessageBox.Show("密码不一致", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                SQLiteConnection conn = SqlHelper.CyCon();
                try
                {
                    conn.Open();
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update tb_user set user_name=@userName,passwd=@passwd where user_name=@origin_name";
                    cmd.Parameters.Add("@userName", DbType.String);
                    cmd.Parameters.Add("@passwd", DbType.String);
                    cmd.Parameters.Add("@origin_name", DbType.String);
                    cmd.Parameters["@userName"].Value = this.textBoxName.Text;
                    cmd.Parameters["@passwd"].Value = textBoxPassWd.Text;
                    cmd.Parameters["@origin_name"].Value = this.userName;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("修改密码成功呦");
                }
                catch (Exception)
                {
                    MessageBox.Show("修改密码失败");
                }
                finally
                {
                    conn.Close();
                }
            }
            

            
        }

        private void textBoxPassWd_TextChanged(object sender, EventArgs e)
        {
            if(this.checkBox1.Checked)
            {
                this.textBoxPassWd.PasswordChar = (char)0;
            }
            else
            {
                this.textBoxPassWd.PasswordChar = '*';
            }
        }

        private void textBoxCheckPassWd_TextChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.textBoxCheckPassWd.PasswordChar = '\0';
            }
            else
            {
                this.textBoxPassWd.PasswordChar = '*';
            }
        }
    }
}
