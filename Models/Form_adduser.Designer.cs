namespace SysCard
{
    partial class Form_adduser
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tex_card = new System.Windows.Forms.TextBox();
            this.tex_time = new System.Windows.Forms.TextBox();
            this.tex_pwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tex_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tex_phone = new System.Windows.Forms.TextBox();
            this.tb_bk = new System.Windows.Forms.RichTextBox();
            this.cmb_stata = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labcard = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(210, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(335, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "卡号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "密码";
            // 
            // tex_card
            // 
            this.tex_card.Location = new System.Drawing.Point(67, 25);
            this.tex_card.Multiline = true;
            this.tex_card.Name = "tex_card";
            this.tex_card.Size = new System.Drawing.Size(118, 15);
            this.tex_card.TabIndex = 1;
            this.tex_card.TextChanged += new System.EventHandler(this.tex_card_TextChanged);
            this.tex_card.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex_card_KeyDown);
            this.tex_card.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tex_card_KeyUp);
            // 
            // tex_time
            // 
            this.tex_time.Location = new System.Drawing.Point(435, 23);
            this.tex_time.Multiline = true;
            this.tex_time.Name = "tex_time";
            this.tex_time.Size = new System.Drawing.Size(118, 15);
            this.tex_time.TabIndex = 8;
            this.tex_time.TextChanged += new System.EventHandler(this.tex_time_TextChanged);
            this.tex_time.MouseHover += new System.EventHandler(this.textBox7_MouseHover);
            // 
            // tex_pwd
            // 
            this.tex_pwd.Location = new System.Drawing.Point(67, 46);
            this.tex_pwd.Multiline = true;
            this.tex_pwd.Name = "tex_pwd";
            this.tex_pwd.Size = new System.Drawing.Size(118, 15);
            this.tex_pwd.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "姓名";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "出生年月";
            // 
            // tex_name
            // 
            this.tex_name.Location = new System.Drawing.Point(240, 23);
            this.tex_name.Multiline = true;
            this.tex_name.Name = "tex_name";
            this.tex_name.Size = new System.Drawing.Size(118, 15);
            this.tex_name.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "手机";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "备注";
            // 
            // tex_phone
            // 
            this.tex_phone.Location = new System.Drawing.Point(240, 49);
            this.tex_phone.Multiline = true;
            this.tex_phone.Name = "tex_phone";
            this.tex_phone.Size = new System.Drawing.Size(118, 15);
            this.tex_phone.TabIndex = 7;
            // 
            // tb_bk
            // 
            this.tb_bk.Location = new System.Drawing.Point(27, 140);
            this.tb_bk.Name = "tb_bk";
            this.tb_bk.Size = new System.Drawing.Size(552, 162);
            this.tb_bk.TabIndex = 12;
            this.tb_bk.Text = "";
            // 
            // cmb_stata
            // 
            this.cmb_stata.AutoSize = true;
            this.cmb_stata.Location = new System.Drawing.Point(378, 113);
            this.cmb_stata.Name = "cmb_stata";
            this.cmb_stata.Size = new System.Drawing.Size(72, 16);
            this.cmb_stata.TabIndex = 11;
            this.cmb_stata.Text = "是否激活";
            this.cmb_stata.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(435, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(376, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "姓　　别";
            // 
            // labcard
            // 
            this.labcard.AutoSize = true;
            this.labcard.Location = new System.Drawing.Point(65, 26);
            this.labcard.Name = "labcard";
            this.labcard.Size = new System.Drawing.Size(0, 12);
            this.labcard.TabIndex = 13;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(359, 81);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseDown);
            this.monthCalendar1.MouseLeave += new System.EventHandler(this.monthCalendar1_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.labcard);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.cmb_stata);
            this.groupBox1.Controls.Add(this.tb_bk);
            this.groupBox1.Controls.Add(this.tex_phone);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tex_name);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tex_pwd);
            this.groupBox1.Controls.Add(this.tex_time);
            this.groupBox1.Controls.Add(this.tex_card);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(31, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增会员卡";
            // 
            // Form_adduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 401);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Form_adduser";
            this.Text = "新增会员";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tex_card;
        private System.Windows.Forms.TextBox tex_time;
        private System.Windows.Forms.TextBox tex_pwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tex_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tex_phone;
        private System.Windows.Forms.RichTextBox tb_bk;
        private System.Windows.Forms.CheckBox cmb_stata;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labcard;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}