using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace 日常安排应用
{
    public class Utils
    {
        public  static int getItemId(ListView listView)
        {
            // 通过事项图标下方的Text获得事项Id
            int i = listView.SelectedItems[0].Text.IndexOf("项");
            int j = listView.SelectedItems[0].Text.IndexOf('\n');
            int itemId = int.Parse(listView.SelectedItems[0].Text.Substring(i + 1, j - i - 1));
            return itemId;
        }
    }
}
