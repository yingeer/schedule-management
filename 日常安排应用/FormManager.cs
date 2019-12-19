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
    public partial class FormManager : Skin_DevExpress
    {
        public string superUserName = "";
        public FormManager()
        {
            InitializeComponent();
        }

        private void FormManager_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel2.Text = this.superUserName;
          

            // 在listView中展示数据
            listView1.Clear();

            SQLiteConnection conn = SqlHelper.CyCon();
            conn.Open();
            string sql = "select * from tb_user";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataReader sdr = cmd.ExecuteReader();
            listView1.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度

            while (sdr.Read())
            {
               
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageIndex = 0;
                    lvi.Text = "用户" + sdr["id"].ToString() + "\n" + sdr["user_name"].ToString();
                    
                    listView1.Items.Add(lvi);
                
            }

            sdr.Close(); conn.Close();
            listView1.EndUpdate();  //结束数据处理，UI界面一次

        }

        private void 查看用户ToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            int i = this.listView1.SelectedItems[0].Text.IndexOf("户");
            int j = this.listView1.SelectedItems[0].Text.IndexOf('\n');
            int userId = int.Parse(this.listView1.SelectedItems[0].Text.Substring(i+1,j-i-1));
            SQLiteConnection conn = SqlHelper.CyCon();
            conn.Open();
            string sql = "select * from tb_user where id="+userId;
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataReader sdr = cmd.ExecuteReader();

            sdr.Read();

            
            FormMain formMain = new FormMain();
            formMain.userName = sdr["user_name"].ToString().Trim();
            formMain.isFromSuperUser = 1;
            sdr.Close(); conn.Close();
            this.Hide();
            formMain.ShowDialog();
            this.Show();
        }


        private void skinButton1_Click(object sender, EventArgs e)
        {
            string toFindUserName = this.textBox1.Text.Trim();
            SQLiteConnection conn = SqlHelper.CyCon();
            conn.Open();
            string sql = "select * from tb_user where user_name='" + toFindUserName + "'";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataReader sdr = null;
            try
            {
                sdr = cmd.ExecuteReader();
                sdr.Read();

                // listView1中展示用户数据
                listView1.Clear();
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = 0;
                lvi.Text = "用户" + sdr["id"].ToString() + "\n" + sdr["user_name"].ToString();
                listView1.Items.Add(lvi);
            }
            catch (Exception)
            {
                MessageBox.Show("未找到名为" + toFindUserName + "用户");
            }
            finally
            {
                sdr.Close(); conn.Close();
            }

        }
    }
}
