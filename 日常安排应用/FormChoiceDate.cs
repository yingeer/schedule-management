using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
namespace 日常安排应用
{
    public partial class FormChoiceDate : Skin_DevExpress
    {
        public FormChoiceDate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HistoryItemView historyItemView = new HistoryItemView();
            historyItemView.startDate = this.dateTimePicker1.Text;
            historyItemView.endDate = this.dateTimePicker2.Text;
            this.Hide();
            historyItemView.ShowDialog();
            this.Close();
            
        }
    }
}
