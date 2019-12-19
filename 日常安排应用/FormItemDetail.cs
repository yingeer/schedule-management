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
    public partial class FormItemDetail : Skin_DevExpress
    {

        public int itemId = 1;
        public string userName = "ying";
        public FormItemDetail()
        {
            InitializeComponent();
        }

        private void FormItemDetail_Load(object sender, EventArgs e)
        {
            this.Text = "事项" + itemId;

            string sql = "select * from tb_schedule where id="+itemId;
            SQLiteConnection conn = SqlHelper.CyCon();
            SQLiteDataReader sdr;
            try
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                sdr = cmd.ExecuteReader(); sdr.Read();
                this.richTextBox1.Text = sdr["description"].ToString().Trim();
                this.richTextBox2.Text = sdr["remark"].ToString().Trim();
                this.dateTimePicker1.Text = sdr["start_time"].ToString().Trim();
                this.dateTimePicker2.Text = sdr["end_time"].ToString().Trim();
                string ok = sdr["accomplish"].ToString().Trim();
                if (ok == "0")
                {
                    this.checkBox2.Checked = true;
                }
                else if (ok == "1")
                {
                    this.checkBox1.Checked = true;
                }
                sdr.Close();
                conn.Close();
            }
            catch (Exception)
            {
            }
        }

        private int findUserId()
        {
            string sql = "select id from tb_user where user_name='" + userName + "'";
            SQLiteConnection conn = SqlHelper.CyCon();
            string userID = "";
            SQLiteDataReader sdr;
            try
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                sdr = cmd.ExecuteReader(); sdr.Read();
                userID = sdr["id"].ToString().Trim();
                sdr.Close();
                conn.Close();
                return int.Parse(userID);
            }
            catch (Exception)
            {
                return 0;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出吗？小可爱");
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ac=0;
            if (this.checkBox1.Checked && this.checkBox2.Checked)
            {
                MessageBox.Show("请勾选其中一个");
                return;
            }
            if (this.checkBox1.Checked)
            {
                ac = 1;
            } 
            else if (this.checkBox2.Checked) {
                ac = 0;
            }

            string sql = "update tb_schedule set start_time='" + this.dateTimePicker1.Value.ToLongDateString() + "', " + "end_time='" + this.dateTimePicker2.Value.ToLongDateString() + "', " + "description='" + this.richTextBox1.Text + "'," + "remark='" + this.richTextBox2.Text + "'," + " accomplish=" + ac + " where id=" + this.itemId;
                
            SqlHelper.sqlExecute(sql, "保存成功", "保存失败");
        }
    }
}
