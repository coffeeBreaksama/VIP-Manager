namespace SysCard
{
    partial class Form_NewVip
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
            this.CardBalanceNum = new System.Windows.Forms.Label();
            this.CardBalance = new System.Windows.Forms.Label();
            this.TCardNum = new System.Windows.Forms.Label();
            this.Card = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.labcard = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmb_stata = new System.Windows.Forms.CheckBox();
            this.tb_bk = new System.Windows.Forms.RichTextBox();
            this.tex_phone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tex_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tex_pwd = new System.Windows.Forms.TextBox();
            this.tex_time = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CardBalanceNum
            // 
            this.CardBalanceNum.Font = new System.Drawing.Font("宋体", 20F);
            this.CardBalanceNum.ForeColor = System.Drawing.Color.Red;
            this.CardBalanceNum.Location = new System.Drawing.Point(264, 74);
            this.CardBalanceNum.Name = "CardBalanceNum";
            this.CardBalanceNum.Size = new System.Drawing.Size(203, 40);
            this.CardBalanceNum.TabIndex = 35;
            this.CardBalanceNum.Text = "0000";
            this.CardBalanceNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardBalance
            // 
            this.CardBalance.Font = new System.Drawing.Font("宋体", 20F);
            this.CardBalance.Location = new System.Drawing.Point(169, 74);
            this.CardBalance.Name = "CardBalance";
            this.CardBalance.Size = new System.Drawing.Size(96, 40);
            this.CardBalance.TabIndex = 34;
            this.CardBalance.Text = "余额：";
            this.CardBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TCardNum
            // 
            this.TCardNum.Font = new System.Drawing.Font("宋体", 20F);
            this.TCardNum.ForeColor = System.Drawing.Color.Red;
            this.TCardNum.Location = new System.Drawing.Point(252, 23);
            this.TCardNum.Name = "TCardNum";
            this.TCardNum.Size = new System.Drawing.Size(222, 40);
            this.TCardNum.TabIndex = 33;
            this.TCardNum.Text = "未读取到卡号";
            this.TCardNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Card
            // 
            this.Card.Font = new System.Drawing.Font("宋体", 20F);
            this.Card.Location = new System.Drawing.Point(169, 23);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(96, 40);
            this.Card.TabIndex = 32;
            this.Card.Text = "卡号：";
            this.Card.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(350, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(225, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(2, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 309);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增会员卡";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(370, 62);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseDown);
            this.monthCalendar1.MouseLeave += new System.EventHandler(this.monthCalendar1_MouseLeave);
            // 
            // labcard
            // 
            this.labcard.AutoSize = true;
            this.labcard.Location = new System.Drawing.Point(65, 26);
            this.labcard.Name = "labcard";
            this.labcard.Size = new System.Drawing.Size(0, 12);
            this.labcard.TabIndex = 13;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(435, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 9;
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
            // tb_bk
            // 
            this.tb_bk.Location = new System.Drawing.Point(27, 140);
            this.tb_bk.Name = "tb_bk";
            this.tb_bk.Size = new System.Drawing.Size(552, 162);
            this.tb_bk.TabIndex = 12;
            this.tb_bk.Text = "";
            // 
            // tex_phone
            // 
            this.tex_phone.Location = new System.Drawing.Point(240, 49);
            this.tex_phone.Multiline = true;
            this.tex_phone.Name = "tex_phone";
            this.tex_phone.Size = new System.Drawing.Size(118, 15);
            this.tex_phone.TabIndex = 7;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "手机";
            // 
            // tex_name
            // 
            this.tex_name.Location = new System.Drawing.Point(240, 23);
            this.tex_name.Multiline = true;
            this.tex_name.Name = "tex_name";
            this.tex_name.Size = new System.Drawing.Size(118, 15);
            this.tex_name.TabIndex = 5;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "姓名";
            // 
            // tex_pwd
            // 
            this.tex_pwd.Location = new System.Drawing.Point(67, 46);
            this.tex_pwd.Multiline = true;
            this.tex_pwd.Name = "tex_pwd";
            this.tex_pwd.Size = new System.Drawing.Size(118, 15);
            this.tex_pwd.TabIndex = 2;
            // 
            // tex_time
            // 
            this.tex_time.Location = new System.Drawing.Point(435, 23);
            this.tex_time.Multiline = true;
            this.tex_time.Name = "tex_time";
            this.tex_time.Size = new System.Drawing.Size(118, 15);
            this.tex_time.TabIndex = 8;
            this.tex_time.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tex_time_MouseClick);
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
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_NewVip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 493);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CardBalanceNum);
            this.Controls.Add(this.CardBalance);
            this.Controls.Add(this.TCardNum);
            this.Controls.Add(this.Card);
            this.Name = "Form_NewVip";
            this.Text = "新建会员";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label CardBalanceNum;
        private System.Windows.Forms.Label CardBalance;
        private System.Windows.Forms.Label TCardNum;
        private System.Windows.Forms.Label Card;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label labcard;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox cmb_stata;
        private System.Windows.Forms.RichTextBox tb_bk;
        private System.Windows.Forms.TextBox tex_phone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tex_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tex_pwd;
        private System.Windows.Forms.TextBox tex_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}