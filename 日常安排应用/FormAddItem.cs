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
    public partial class FormAddItem : Skin_DevExpress
    {
        public string userName = "ying";
        public FormAddItem()
        {
            InitializeComponent();
        }

        private void FormAddItem_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet1.tb_schedule”中。您可以根据需要移动或删除它。
            this.tb_scheduleTableAdapter.Fill(this.dataSet1.tb_schedule);
            // TODO: 这行代码将数据加载到表“dataSet1.tb_schedule”中。您可以根据需要移动或删除它。
            this.tb_scheduleTableAdapter.Fill(this.dataSet1.tb_schedule);
            this.textBox1.Text = this.userName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show(this.userName + "是最棒的！！");
            }
            else
            {
                MessageBox.Show("难道" + this.userName + "不是最棒的吗？？");
            }
            int id = findUserId();
            string sql = "insert into tb_schedule (category, start_time, end_time, description, remark, accomplish, user_id) " +
                "values ('"+this.textBox1.Text+"', '"+this.dateTimePicker1.Value.ToLongDateString()+"', '"+this.dateTimePicker2.Value.ToLongDateString()+"',"+
                           "'"+this.richTextBox1.Text+"','"+this.richTextBox2.Text+"',"+0+","+id+ ")";
            SqlHelper.sqlExecute(sql, "保存成功", "保存失败");
        }

        private int findUserId()
        {
            string sql = "select id from tb_user where user_name='" + userName+"'";
            SQLiteConnection conn =  SqlHelper.CyCon();
            string userID = "";
            SQLiteDataReader sdr;
            try
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                sdr =  cmd.ExecuteReader(); sdr.Read();
                userID = sdr["id"].ToString().Trim();
                sdr.Close();
                conn.Close();
                return int.Parse(userID);
            }
            catch(Exception)
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
    }
}
