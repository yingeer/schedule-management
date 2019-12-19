namespace 日常安排应用
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonSure = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassWd = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(339, 242);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(103, 48);
            this.buttonReturn.TabIndex = 0;
            this.buttonReturn.Text = "返回登录";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonSure
            // 
            this.buttonSure.Location = new System.Drawing.Point(135, 242);
            this.buttonSure.Name = "buttonSure";
            this.buttonSure.Size = new System.Drawing.Size(103, 48);
            this.buttonSure.TabIndex = 1;
            this.buttonSure.Text = "确定";
            this.buttonSure.UseVisualStyleBackColor = true;
            this.buttonSure.Click += new System.EventHandler(this.buttonSure_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码：";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(262, 68);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(166, 28);
            this.textBoxUserName.TabIndex = 4;
            // 
            // textBoxPassWd
            // 
            this.textBoxPassWd.Location = new System.Drawing.Point(262, 139);
            this.textBoxPassWd.Name = "textBoxPassWd";
            this.textBoxPassWd.Size = new System.Drawing.Size(166, 28);
            this.textBoxPassWd.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(262, 194);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 22);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "成为管理员";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 312);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxPassWd);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSure);
            this.Controls.Add(this.buttonReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegister";
            this.Text = "用户注册";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonSure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassWd;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}