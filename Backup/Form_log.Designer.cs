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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tex_User
            // 
            this.tex_User.Location = new System.Drawing.Point(236, 140);
            this.tex_User.Multiline = true;
            this.tex_User.Name = "tex_User";
            this.tex_User.Size = new System.Drawing.Size(111, 20);
            this.tex_User.TabIndex = 1;
            // 
            // tex_pwd
            // 
            this.tex_pwd.Location = new System.Drawing.Point(236, 165);
            this.tex_pwd.Multiline = true;
            this.tex_pwd.Name = "tex_pwd";
            this.tex_pwd.Size = new System.Drawing.Size(111, 18);
            this.tex_pwd.TabIndex = 1;
            this.tex_pwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex_pwd_KeyDown);
            // 
            // btn_log
            // 
            this.btn_log.Location = new System.Drawing.Point(241, 189);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(38, 23);
            this.btn_log.TabIndex = 2;
            this.btn_log.Text = "登陆";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.button1_Click);
            this.btn_log.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_log_KeyDown);
            // 
            // btn_can
            // 
            this.btn_can.Location = new System.Drawing.Point(294, 189);
            this.btn_can.Name = "btn_can";
            this.btn_can.Size = new System.Drawing.Size(37, 23);
            this.btn_can.TabIndex = 2;
            this.btn_can.Text = "取消";
            this.btn_can.UseVisualStyleBackColor = true;
            this.btn_can.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SysCard.Properties.Resources.pdlogin_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 233);
            this.Controls.Add(this.btn_can);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.tex_pwd);
            this.Controls.Add(this.tex_User);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_log";
            this.Text = "用户登陆";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_log_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_log_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tex_User;
        private System.Windows.Forms.TextBox tex_pwd;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Button btn_can;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

