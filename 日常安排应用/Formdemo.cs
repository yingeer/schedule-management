using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace 日常安排应用
{
    public partial class Formdemo : Form
    {
        public Formdemo()
        {
            InitializeComponent();
        }

        private void Formdemo_Load(object sender, EventArgs e)
        {
            this.listView1.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度

            for (int i = 0; i < 10; i++)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.ImageIndex = 0;

                lvi.Text = "item" + i;

                this.listView1.Items.Add(lvi);
            }

            this.listView1.EndUpdate();  //结束数据处理，UI界面一次性绘制。
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 时间日期字符串(String)转换成Datetime的方法
             
System.Globalization.CultureInfo Culinfo = CultureInfo.GetCultureInfo("zh-cn");
            string dateString = "2019年12月18日";
            DateTime dt = DateTime.ParseExact(dateString, "yyyy年M月d日", Culinfo);
            
            this.textBox1.Text = DateTime.Compare(dt, DateTime.Now.Date).ToString();
        }
    }
}
