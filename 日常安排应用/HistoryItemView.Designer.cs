namespace 日常安排应用
{
    partial class HistoryItemView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("hello", "即将开始事项.png");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryItemView));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("world", "已完成事项.png");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("miles", "正在进行事项.png");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("kwok", "过期事项.png");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看事项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除事项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "开始事项";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "完成事项";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "尚待完成";
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(44, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(317, 195);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "即将开始事项.png");
            this.imageList1.Images.SetKeyName(1, "已完成事项.png");
            this.imageList1.Images.SetKeyName(2, "正在进行事项.png");
            this.imageList1.Images.SetKeyName(3, "过期事项.png");
            // 
            // listView2
            // 
            this.listView2.ContextMenuStrip = this.contextMenuStrip1;
            this.listView2.HideSelection = false;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView2.LargeImageList = this.imageList1;
            this.listView2.Location = new System.Drawing.Point(461, 67);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(317, 195);
            this.listView2.SmallImageList = this.imageList1;
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            this.listView3.ContextMenuStrip = this.contextMenuStrip1;
            this.listView3.HideSelection = false;
            this.listView3.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listView3.LargeImageList = this.imageList1;
            this.listView3.Location = new System.Drawing.Point(44, 321);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(424, 121);
            this.listView3.SmallImageList = this.imageList1;
            this.listView3.TabIndex = 6;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看事项ToolStripMenuItem,
            this.删除事项ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 64);
            // 
            // 查看事项ToolStripMenuItem
            // 
            this.查看事项ToolStripMenuItem.Name = "查看事项ToolStripMenuItem";
            this.查看事项ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.查看事项ToolStripMenuItem.Text = "查看事项";
            this.查看事项ToolStripMenuItem.Click += new System.EventHandler(this.查看事项ToolStripMenuItem_Click);
            // 
            // 删除事项ToolStripMenuItem
            // 
            this.删除事项ToolStripMenuItem.Name = "删除事项ToolStripMenuItem";
            this.删除事项ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.删除事项ToolStripMenuItem.Text = "删除事项";
            this.删除事项ToolStripMenuItem.Click += new System.EventHandler(this.删除事项ToolStripMenuItem_Click);
            // 
            // HistoryItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 493);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistoryItemView";
            this.Text = "事项查看";
            this.Load += new System.EventHandler(this.HistoryItemView_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看事项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除事项ToolStripMenuItem;
    }
}