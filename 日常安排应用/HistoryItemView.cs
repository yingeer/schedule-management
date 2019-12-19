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
    public partial class HistoryItemView : Skin_DevExpress
    {
        public string startDate = "2019年12月18日";
        public string endDate = "2019年12月20日";
        private DateTime startDateTime;
        private DateTime endDateTime;
        public string userName = "ying";
        public HistoryItemView()
        {
            InitializeComponent();
        }

        private void HistoryItemView_Load(object sender, EventArgs e)
        {

            // 判断是否是查询未来事项

            bool isCheckFutureItems = checkFutureItems(this.startDate, this.endDate);
            if (isCheckFutureItems)
            {
                this.Text = "未来事项查看";
                this.listView2.Hide();
            }
            else
            {
                this.Text = startDate + "-" + endDate + "事项查看";
            }

            // 日期转换
            this.startDateTime = dateConverter(this.startDate);
            this.endDateTime = dateConverter(this.endDate);
            // 在listView中添加item
            listView1.Clear(); listView2.Clear(); listView3.Clear();
            addToListView();
        }

        private bool checkFutureItems(string dateTime1, string dateTime2)
        {
            if (dateTime1 == DateTime.Now.AddDays(1).ToLongDateString() && dateTime2 == "3000年12月12日")
            {
                return true;
            }
            return false;
        }
        
         private DateTime dateConverter(string date)
        {
            // date 格式 yyyy年M月d日
            string dateFormat = "yyyy年M月d日";
            System.Globalization.CultureInfo Culinfo = CultureInfo.GetCultureInfo("zh-cn");
            DateTime dt = DateTime.ParseExact(date, dateFormat, Culinfo);
            return dt;
        }

        private void addToListView() 
        {
            SQLiteConnection conn = SqlHelper.CyCon();
            conn.Open();
            string sql = "select * from tb_schedule where user_id=(select id from tb_user where user_name='"+this.userName+"')";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataReader sdr = cmd.ExecuteReader();
            listView1.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度

            
            while (sdr.Read())
            {
                DateTime itemStart = dateConverter(sdr["start_time"].ToString().Trim());
                DateTime itemEnd = dateConverter(sdr["end_time"].ToString().Trim());

                // 事项在给定区段  开始
                int i = DateTime.Compare(itemStart, this.startDateTime); // >=0    
                int j = DateTime.Compare(itemStart, this.endDateTime); // <=0
                if (i >=0 && j <= 0)
                {
                
                    addItemToListView(0, listView1, sdr);
                }

                // 事项在给定时间区段结束
                int k = DateTime.Compare(itemEnd, this.startDateTime); // >=0
                int l = DateTime.Compare(itemEnd, this.endDateTime); // <=0
                if (k>=0 && l <=0) 
                {
                   
                    addItemToListView(1, listView2, sdr);
                }

                // 事项尚未完成
                if (l>0)
                {
                    if (DateTime.Compare(DateTime.Now, itemEnd) < 0) // 超时
                    {
                      
                        addItemToListView(2, listView3, sdr);
                    }
                    else
                    {
                        addItemToListView(3, listView3, sdr);
                    }
                }
            }

            sdr.Close(); conn.Close();
            listView1.EndUpdate();
        }

        private void addItemToListView(int imageIndex, ListView listView, SQLiteDataReader sdr)
        {
            
            ListViewItem lvi = new ListViewItem();
            lvi.ImageIndex = imageIndex;
            lvi.Text = "事项" + sdr["id"].ToString() + "\n" + sdr["description"].ToString() + "...";
            listView.Items.Add(lvi);
        }

        private void 查看事项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0 && listView2.SelectedItems.Count == 0 && listView3.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择事项");
            }
            else if (listView1.SelectedItems.Count != 0)
            {
                createFormItemDetail(listView1);
            }
            else if (listView2.SelectedItems.Count != 0)
            {
                createFormItemDetail(listView2);
            }
            else if (listView3.SelectedItems.Count != 0)
            {
                createFormItemDetail(listView3);
            }
            HistoryItemView_Load(sender, e);
        }

        private void createFormItemDetail(ListView listView)
        {
            // 查看某个事项时，新打开一个窗体
            FormItemDetail formItemDetail = new FormItemDetail();
            int itemId = Utils.getItemId(listView);
            formItemDetail.itemId = itemId;
            formItemDetail.ShowDialog();
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
            HistoryItemView_Load(sender, e);
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


    }
}
