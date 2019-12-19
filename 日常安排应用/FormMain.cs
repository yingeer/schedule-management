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
using System.Globalization;
using CCWin;


namespace 日常安排应用
{
    public partial class FormMain : Skin_DevExpress
    {
        public string userName = "ying";
        public int power = 1;
        private DateTime Today = DateTime.Now.Date;
        public int isFromSuperUser = 0;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = userName + "主页";
            if (this.power == 1)
            {
                this.ManagerToolStripMenuItem.Enabled = true;
            } 
            else
            {
                this.ManagerToolStripMenuItem.Enabled = false;
            }
            // 状态栏数据
            showStatusBar();
            // listView1展示
            string sql1 = "select * from tb_schedule where start_time='" + this.Today.ToLongDateString() + "' and user_id=(select id from tb_user where user_name='"+this.userName+"')" ;
            showTodayItem(this.listView1, sql1, 1);

            // listView2展示
            string sql2 = "select * from tb_schedule where accomplish = 0 and user_id=(select id from tb_user where user_name='"+this.userName+"')" ;
            showTodayItem2(this.listView2, sql2, 3);

            // listView3展示
            string sql3 = "select * from tb_schedule where accomplish = 1 and user_id=(select id from tb_user where user_name='" + this.userName + "')";
            showTodayItem2(this.listView3, sql3, 2);
        }

        private void showStatusBar()
        {
            // 状态栏数据
            this.toolStripStatusLabel2.Text = this.userName;
            this.toolStripStatusLabel8.Text = DateTime.Now.ToString();
            if (this.power == 1)
            {
                this.toolStripStatusLabel5.Text = "管理员";
            }
            else
            {
                this.toolStripStatusLabel5.Text = "普通用户";
            }
        }

        private void showTodayItem2(ListView listView, string sql, int imageIndex)
        {
            // 在listView中展示数据
            listView.Clear();

            SQLiteConnection conn = SqlHelper.CyCon();
            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataReader sdr = cmd.ExecuteReader();
            listView.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度
            
            while (sdr.Read())
            {
                // 日期比较
                DateTime endTime = dateConverter(sdr["end_time"].ToString().Trim());
                int compareRes = DateTime.Compare(this.Today, endTime);
                if (compareRes <= 0)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageIndex = imageIndex;
                    lvi.Text = "事项" + sdr["id"].ToString() + "\n" + sdr["description"].ToString() + "...";
                   
                    listView.Items.Add(lvi);
                }
            }

            sdr.Close(); conn.Close();
            listView.EndUpdate();  //结束数据处理，UI界面一次

        }
        

        private DateTime dateConverter(string date)
        {
            // date 格式 yyyy年M月d日
            string dateFormat = "yyyy年M月d日";
            System.Globalization.CultureInfo Culinfo = CultureInfo.GetCultureInfo("zh-cn");
            DateTime dt = DateTime.ParseExact(date, dateFormat, Culinfo);
            return dt;
        }

        private void showTodayItem(ListView listView, string sql, int imageIndex)
        {
            // 在两个listView中展示数据
            listView.Clear();

            SQLiteConnection conn = SqlHelper.CyCon();
            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataReader sdr = cmd.ExecuteReader();
            listView.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度

            
            while(sdr.Read())
            {
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageIndex = imageIndex;
                    lvi.Text = "事项" + sdr["id"].ToString() + "\n" + sdr["description"].ToString() + "...";
                    
                    listView.Items.Add(lvi);
            }

            sdr.Close(); conn.Close();
            listView.EndUpdate();  //结束数据处理，UI界面一次

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void 管理员选项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager formManager = new FormManager();
            formManager.superUserName = this.userName;
            formManager.ShowDialog();
        }

        private void 修改信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModify f = new FormModify();
            f.userName = this.userName;
            f.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("确定退出", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        
        }

        private void 指定时间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChoiceDate formChoiceDate = new FormChoiceDate();
            formChoiceDate.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void 今天ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
        private void 昨天ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateMenuStrip(-1,"昨天");
        }
        private void 过去一周ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateMenuStrip(-7, "过去7天");
        }

        private void 过去一个月ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateMenuStrip(-30, "过去30天");
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();
        }

        private void 日历ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalendar formCalendar = new FormCalendar();
            formCalendar.ShowDialog();
        }

        private void DateMenuStrip(int timeDelta, string title)
        {
            // 传递时间，打开一个新窗口
            HistoryItemView historyItemView = new HistoryItemView();
            DateTime dt = DateTime.Now;
            historyItemView.startDate = dt.AddDays(timeDelta).ToLongDateString();
            historyItemView.endDate = dt.AddDays(-1).ToLongDateString();
            historyItemView.Text = title + "事项概览";
            historyItemView.userName = this.userName;
            historyItemView.ShowDialog();
        }

        private void 未来安排ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryItemView historyItemView = new HistoryItemView();
            DateTime dt = DateTime.Now;
            historyItemView.startDate = dt.AddDays(1).ToLongDateString();
            historyItemView.endDate = "3000年12月12日";
            historyItemView.Text = "未来事项概览";
            historyItemView.userName = this.userName;
            historyItemView.ShowDialog();

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.isFromSuperUser == 1)
            {
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
            
        }

        private void 查看该事项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0 && listView2.SelectedItems.Count == 0 && listView3.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择事项");
            } 
            else if(listView1.SelectedItems.Count != 0)
            {
                createFormItemDetail(listView1);
            }
            else if(listView2.SelectedItems.Count != 0)
            {
                createFormItemDetail(listView2);
            }
            else if(listView3.SelectedItems.Count != 0)
            {
                createFormItemDetail(listView3);
            }
            FormMain_Load(sender, e);
        }

        private void createFormItemDetail(ListView listView)
        {
            // 查看某个事项时，新打开一个窗体
            FormItemDetail formItemDetail = new FormItemDetail();
            int itemId = Utils.getItemId(listView);
            formItemDetail.itemId = itemId;
            formItemDetail.ShowDialog();
        }

    
        
        private void 新添事项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
                FormAddItem form = new FormAddItem();
                form.userName = this.userName;
                form.ShowDialog();
                FormMain_Load(sender, e);



        }

        private void 删除事项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0 && listView2.SelectedItems.Count == 0 && listView3.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择事项");
            }
            else if (listView1.SelectedItems.Count != 0)
            {
                this.deleteItem(listView1);
            }
            else if (listView2.SelectedItems.Count != 0)
            {
                this.deleteItem(listView2);
            }
            else if (listView3.SelectedItems.Count != 0)
            {
                this.deleteItem(listView3);
            }
            FormMain_Load(sender, e);
        }

        private void deleteItem(ListView listView)
        {
            // 删除事项
            int itemId = Utils.getItemId(listView);
            string sql = "delete from tb_schedule where id=" + itemId;
            DialogResult dialogResult = MessageBox.Show("确定删除", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SqlHelper.sqlExecute(sql, "删除成功", "删除失败");
            }
        }

        private void 完成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0 && listView2.SelectedItems.Count == 0 && listView3.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择事项");
            }
            else if (listView1.SelectedItems.Count != 0)
            {
                setComplete(listView1);
            }
            else if (listView2.SelectedItems.Count != 0)
            {
                setComplete(listView2);
            }
            else if (listView3.SelectedItems.Count != 0)
            {
                setComplete(listView3);
            }
            FormMain_Load(sender, e);
        }

        private void setComplete(ListView listView)
        {
            // 事项accomplish从0变为1
            int itemId = Utils.getItemId(listView);
            string sql = "update tb_schedule set accomplish=1 where id=" + itemId;
            SqlHelper.sqlExecute(sql, "设置完成", "设置失败");
        }

        

        private void 未完成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0 && listView2.SelectedItems.Count == 0 && listView3.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择事项");
            }
            else if (listView1.SelectedItems.Count != 0)
            {
                setNotComplete(listView1);
            }
            else if (listView2.SelectedItems.Count != 0)
            {
                setNotComplete(listView2);
            }
            else if (listView3.SelectedItems.Count != 0)
            {
                setNotComplete(listView3);
            }
            FormMain_Load(sender, e);
        }

        private void setNotComplete(ListView listView)
        {
            // 事项accomplish从1变为0
            int itemId = Utils.getItemId(listView);
            string sql = "update tb_schedule set accomplish=0 where id=" + itemId;
            SqlHelper.sqlExecute(sql, "设置完成", "设置失败");
        }

        private void FormMain_DoubleClick(object sender, EventArgs e)
        {
            查看该事项ToolStripMenuItem_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMain_Load(sender, e);
        }

        private void skinTextBox1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
