namespace SysCard
{
    partial class Form_log
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_log));
            this.tex_User = new System.Windows.Forms.TextBox();
            this.tex_pwd = new System.Windows.Forms.TextBox();
            this.btn_log = new System.Windows.Forms.Button();
            this.btn_can = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lable5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tex_User
            // 
            this.tex_User.Location = new System.Drawing.Point(156, 83);
            this.tex_User.Multiline = true;
            this.tex_User.Name = "tex_User";
            this.tex_User.Size = new System.Drawing.Size(111, 20);
            this.tex_User.TabIndex = 1;
            // 
            // tex_pwd
            // 
            this.tex_pwd.Location = new System.Drawing.Point(156, 108);
            this.tex_pwd.Multiline = true;
            this.tex_pwd.Name = "tex_pwd";
            this.tex_pwd.Size = new System.Drawing.Size(111, 18);
            this.tex_pwd.TabIndex = 1;
            this.tex_pwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex_pwd_KeyDown);
            // 
            // btn_log
            // 
            this.btn_log.Location = new System.Drawing.Point(161, 132);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(38, 23);
            this.btn_log.TabIndex = 2;
            this.btn_log.Text = "登陆";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_can
            // 
            this.btn_can.Location = new System.Drawing.Point(214, 132);
            this.btn_can.Name = "btn_can";
            this.btn_can.Size = new System.Drawing.Size(37, 23);
            this.btn_can.TabIndex = 2;
            this.btn_can.Text = "取消";
            this.btn_can.UseVisualStyleBackColor = true;
            this.btn_can.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "密码";
            // 
            // Lable5
            // 
            this.Lable5.AutoSize = true;
            this.Lable5.Location = new System.Drawing.Point(42, 24);
            this.Lable5.Name = "Lable5";
            this.Lable5.Size = new System.Drawing.Size(323, 12);
            this.Lable5.TabIndex = 6;
            this.Lable5.Text = "若软件已成功激活,初始账户/密码皆为1，登陆后请尽快修改";
            // 
            // Form_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 233);
            this.Controls.Add(this.Lable5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_can);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.tex_pwd);
            this.Controls.Add(this.tex_User);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_log";
            this.Text = "用户登陆";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tex_User;
        private System.Windows.Forms.TextBox tex_pwd;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Button btn_can;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lable5;
    }
}

