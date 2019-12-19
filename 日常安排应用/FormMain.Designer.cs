namespace 日常安排应用
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("事项1", "已完成事项.png");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("事项2", 3);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.今天ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.昨天ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.过去一周ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.过去一个月ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.未来安排ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.指定时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日历ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看该事项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新添事项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除事项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.标记完成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.完成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.未完成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView2 = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8});
            this.statusStrip1.Location = new System.Drawing.Point(0, 585);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(861, 31);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(100, 24);
            this.toolStripStatusLabel1.Text = "登录用户：";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(42, 24);
            this.toolStripStatusLabel2.Text = "****";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(15, 24);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(64, 24);
            this.toolStripStatusLabel4.Text = "权限：";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(42, 24);
            this.toolStripStatusLabel5.Text = "****";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(15, 24);
            this.toolStripStatusLabel6.Text = "|";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(100, 24);
            this.toolStripStatusLabel7.Text = "登录时间：";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(42, 24);
            this.toolStripStatusLabel8.Text = "****";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看ToolStripMenuItem,
            this.修改信息ToolStripMenuItem,
            this.ManagerToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.工具ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.今天ToolStripMenuItem,
            this.昨天ToolStripMenuItem,
            this.过去一周ToolStripMenuItem,
            this.过去一个月ToolStripMenuItem,
            this.未来安排ToolStripMenuItem,
            this.指定时间ToolStripMenuItem});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.查看ToolStripMenuItem.Text = "查看事项";
            // 
            // 今天ToolStripMenuItem
            // 
            this.今天ToolStripMenuItem.Name = "今天ToolStripMenuItem";
            this.今天ToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.今天ToolStripMenuItem.Text = "今天(默认)";
            this.今天ToolStripMenuItem.Click += new System.EventHandler(this.今天ToolStripMenuItem_Click);
            // 
            // 昨天ToolStripMenuItem
            // 
            this.昨天ToolStripMenuItem.Name = "昨天ToolStripMenuItem";
            this.昨天ToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.昨天ToolStripMenuItem.Text = "昨天";
            this.昨天ToolStripMenuItem.Click += new System.EventHandler(this.昨天ToolStripMenuItem_Click);
            // 
            // 过去一周ToolStripMenuItem
            // 
            this.过去一周ToolStripMenuItem.Name = "过去一周ToolStripMenuItem";
            this.过去一周ToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.过去一周ToolStripMenuItem.Text = "过去一周";
            this.过去一周ToolStripMenuItem.Click += new System.EventHandler(this.过去一周ToolStripMenuItem_Click);
            // 
            // 过去一个月ToolStripMenuItem
            // 
            this.过去一个月ToolStripMenuItem.Name = "过去一个月ToolStripMenuItem";
            this.过去一个月ToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.过去一个月ToolStripMenuItem.Text = "过去一个月";
            this.过去一个月ToolStripMenuItem.Click += new System.EventHandler(this.过去一个月ToolStripMenuItem_Click);
            // 
            // 未来安排ToolStripMenuItem
            // 
            this.未来安排ToolStripMenuItem.Name = "未来安排ToolStripMenuItem";
            this.未来安排ToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.未来安排ToolStripMenuItem.Text = "未来安排";
            this.未来安排ToolStripMenuItem.Click += new System.EventHandler(this.未来安排ToolStripMenuItem_Click);
            // 
            // 指定时间ToolStripMenuItem
            // 
            this.指定时间ToolStripMenuItem.Name = "指定时间ToolStripMenuItem";
            this.指定时间ToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.指定时间ToolStripMenuItem.Text = "指定时间";
            this.指定时间ToolStripMenuItem.Click += new System.EventHandler(this.指定时间ToolStripMenuItem_Click);
            // 
            // 修改信息ToolStripMenuItem
            // 
            this.修改信息ToolStripMenuItem.Name = "修改信息ToolStripMenuItem";
            this.修改信息ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.修改信息ToolStripMenuItem.Text = "修改信息";
            this.修改信息ToolStripMenuItem.Click += new System.EventHandler(this.修改信息ToolStripMenuItem_Click);
            // 
            // ManagerToolStripMenuItem
            // 
            this.ManagerToolStripMenuItem.Name = "ManagerToolStripMenuItem";
            this.ManagerToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
            this.ManagerToolStripMenuItem.Text = "管理员";
            this.ManagerToolStripMenuItem.Click += new System.EventHandler(this.管理员选项ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.日历ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 日历ToolStripMenuItem
            // 
            this.日历ToolStripMenuItem.Name = "日历ToolStripMenuItem";
            this.日历ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.日历ToolStripMenuItem.Text = "日历";
            this.日历ToolStripMenuItem.Click += new System.EventHandler(this.日历ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "今日待办事项：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "未完成的事项：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "今天开始的事项：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.HideSelection = false;
            listViewItem2.IndentCount = 5;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(76, 162);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(314, 136);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看该事项ToolStripMenuItem,
            this.新添事项ToolStripMenuItem,
            this.删除事项ToolStripMenuItem,
            this.标记完成ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 124);
            // 
            // 查看该事项ToolStripMenuItem
            // 
            this.查看该事项ToolStripMenuItem.Name = "查看该事项ToolStripMenuItem";
            this.查看该事项ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.查看该事项ToolStripMenuItem.Text = "查看该事项";
            this.查看该事项ToolStripMenuItem.Click += new System.EventHandler(this.查看该事项ToolStripMenuItem_Click);
            // 
            // 新添事项ToolStripMenuItem
            // 
            this.新添事项ToolStripMenuItem.Name = "新添事项ToolStripMenuItem";
            this.新添事项ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.新添事项ToolStripMenuItem.Text = "新添事项";
            this.新添事项ToolStripMenuItem.Click += new System.EventHandler(this.新添事项ToolStripMenuItem_Click);
            // 
            // 删除事项ToolStripMenuItem
            // 
            this.删除事项ToolStripMenuItem.Name = "删除事项ToolStripMenuItem";
            this.删除事项ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.删除事项ToolStripMenuItem.Text = "删除该事项";
            this.删除事项ToolStripMenuItem.Click += new System.EventHandler(this.删除事项ToolStripMenuItem_Click);
            // 
            // 标记完成ToolStripMenuItem
            // 
            this.标记完成ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.完成ToolStripMenuItem,
            this.未完成ToolStripMenuItem});
            this.标记完成ToolStripMenuItem.Name = "标记完成ToolStripMenuItem";
            this.标记完成ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.标记完成ToolStripMenuItem.Text = "标记";
            // 
            // 完成ToolStripMenuItem
            // 
            this.完成ToolStripMenuItem.Name = "完成ToolStripMenuItem";
            this.完成ToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.完成ToolStripMenuItem.Text = "完成";
            this.完成ToolStripMenuItem.Click += new System.EventHandler(this.完成ToolStripMenuItem_Click);
            // 
            // 未完成ToolStripMenuItem
            // 
            this.未完成ToolStripMenuItem.Name = "未完成ToolStripMenuItem";
            this.未完成ToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.未完成ToolStripMenuItem.Text = "未完成";
            this.未完成ToolStripMenuItem.Click += new System.EventHandler(this.未完成ToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "过期事项.png");
            this.imageList1.Images.SetKeyName(1, "即将开始事项.png");
            this.imageList1.Images.SetKeyName(2, "已完成事项.png");
            this.imageList1.Images.SetKeyName(3, "正在进行事项.png");
            // 
            // listView2
            // 
            this.listView2.ContextMenuStrip = this.contextMenuStrip1;
            this.listView2.HideSelection = false;
            this.listView2.LargeImageList = this.imageList1;
            this.listView2.Location = new System.Drawing.Point(76, 384);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(707, 150);
            this.listView2.SmallImageList = this.imageList1;
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "今天已完成的事项：";
            // 
            // listView3
            // 
            this.listView3.ContextMenuStrip = this.contextMenuStrip1;
            this.listView3.HideSelection = false;
            this.listView3.LargeImageList = this.imageList1;
            this.listView3.Location = new System.Drawing.Point(469, 162);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(314, 136);
            this.listView3.SmallImageList = this.imageList1;
            this.listView3.TabIndex = 9;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 616);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "主页";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.DoubleClick += new System.EventHandler(this.FormMain_DoubleClick);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 今天ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 过去一周ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 过去一个月ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 指定时间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日历ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 昨天ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 未来安排ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看该事项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新添事项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除事项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 标记完成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 完成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 未完成ToolStripMenuItem;
    }
}