namespace 日常安排应用
{
    partial class FormModify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModify));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassWd = new System.Windows.Forms.TextBox();
            this.textBoxCheckPassWd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "新用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "确定新密码：";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(205, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(177, 28);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxPassWd
            // 
            this.textBoxPassWd.Location = new System.Drawing.Point(205, 104);
            this.textBoxPassWd.Name = "textBoxPassWd";
            this.textBoxPassWd.PasswordChar = '*';
            this.textBoxPassWd.Size = new System.Drawing.Size(177, 28);
            this.textBoxPassWd.TabIndex = 4;
            this.textBoxPassWd.TextChanged += new System.EventHandler(this.textBoxPassWd_TextChanged);
            // 
            // textBoxCheckPassWd
            // 
            this.textBoxCheckPassWd.Location = new System.Drawing.Point(205, 171);
            this.textBoxCheckPassWd.Name = "textBoxCheckPassWd";
            this.textBoxCheckPassWd.PasswordChar = '*';
            this.textBoxCheckPassWd.Size = new System.Drawing.Size(177, 28);
            this.textBoxCheckPassWd.TabIndex = 5;
            this.textBoxCheckPassWd.TextChanged += new System.EventHandler(this.textBoxCheckPassWd_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(433, 110);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 22);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "显示密码";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 282);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCheckPassWd);
            this.Controls.Add(this.textBoxPassWd);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModify";
            this.Text = "信息修改";
            this.Load += new System.EventHandler(this.FormModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPassWd;
        private System.Windows.Forms.TextBox textBoxCheckPassWd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}