namespace SysCard
{
    partial class Form_SearchCard
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
            this.Card = new System.Windows.Forms.Label();
            this.TCardNum = new System.Windows.Forms.Label();
            this.CardBalance = new System.Windows.Forms.Label();
            this.CardBalanceNum = new System.Windows.Forms.Label();
            this.ConnVip = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Birth = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.ConnVipId = new System.Windows.Forms.Label();
            this.PhoneNum = new System.Windows.Forms.Label();
            this.SexStr = new System.Windows.Forms.Label();
            this.BirthStr = new System.Windows.Forms.Label();
            this.LevelNum = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.StatusStr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Card
            // 
            this.Card.Font = new System.Drawing.Font("宋体", 20F);
            this.Card.Location = new System.Drawing.Point(116, 27);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(96, 40);
            this.Card.TabIndex = 13;
            this.Card.Text = "卡号：";
            this.Card.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TCardNum
            // 
            this.TCardNum.Font = new System.Drawing.Font("宋体", 20F);
            this.TCardNum.ForeColor = System.Drawing.Color.Red;
            this.TCardNum.Location = new System.Drawing.Point(199, 27);
            this.TCardNum.Name = "TCardNum";
            this.TCardNum.Size = new System.Drawing.Size(222, 40);
            this.TCardNum.TabIndex = 14;
            this.TCardNum.Text = "未读取到卡号";
            this.TCardNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TCardNum.Click += new System.EventHandler(this.TCardNum_Click);
            // 
            // CardBalance
            // 
            this.CardBalance.Font = new System.Drawing.Font("宋体", 20F);
            this.CardBalance.Location = new System.Drawing.Point(116, 78);
            this.CardBalance.Name = "CardBalance";
            this.CardBalance.Size = new System.Drawing.Size(96, 40);
            this.CardBalance.TabIndex = 20;
            this.CardBalance.Text = "余额：";
            this.CardBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardBalanceNum
            // 
            this.CardBalanceNum.Font = new System.Drawing.Font("宋体", 20F);
            this.CardBalanceNum.ForeColor = System.Drawing.Color.Red;
            this.CardBalanceNum.Location = new System.Drawing.Point(211, 78);
            this.CardBalanceNum.Name = "CardBalanceNum";
            this.CardBalanceNum.Size = new System.Drawing.Size(203, 40);
            this.CardBalanceNum.TabIndex = 21;
            this.CardBalanceNum.Text = "0000";
            this.CardBalanceNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CardBalanceNum.Click += new System.EventHandler(this.CardBalanceNum_Click);
            // 
            // ConnVip
            // 
            this.ConnVip.Font = new System.Drawing.Font("宋体", 20F);
            this.ConnVip.Location = new System.Drawing.Point(90, 158);
            this.ConnVip.Name = "ConnVip";
            this.ConnVip.Size = new System.Drawing.Size(170, 40);
            this.ConnVip.TabIndex = 22;
            this.ConnVip.Text = "关联会员：";
            this.ConnVip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("宋体", 20F);
            this.Phone.Location = new System.Drawing.Point(90, 198);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(170, 40);
            this.Phone.TabIndex = 23;
            this.Phone.Text = "手机号：";
            this.Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Birth
            // 
            this.Birth.Font = new System.Drawing.Font("宋体", 20F);
            this.Birth.Location = new System.Drawing.Point(90, 278);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(170, 40);
            this.Birth.TabIndex = 24;
            this.Birth.Text = "会员生日：";
            this.Birth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Level
            // 
            this.Level.Font = new System.Drawing.Font("宋体", 20F);
            this.Level.Location = new System.Drawing.Point(90, 318);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(170, 40);
            this.Level.TabIndex = 25;
            this.Level.Text = "会员等级：";
            this.Level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sex
            // 
            this.Sex.Font = new System.Drawing.Font("宋体", 20F);
            this.Sex.Location = new System.Drawing.Point(90, 238);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(170, 40);
            this.Sex.TabIndex = 26;
            this.Sex.Text = "性别：";
            this.Sex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConnVipId
            // 
            this.ConnVipId.Font = new System.Drawing.Font("宋体", 20F);
            this.ConnVipId.Location = new System.Drawing.Point(243, 158);
            this.ConnVipId.Name = "ConnVipId";
            this.ConnVipId.Size = new System.Drawing.Size(170, 40);
            this.ConnVipId.TabIndex = 27;
            this.ConnVipId.Text = "关联会员：";
            this.ConnVipId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhoneNum
            // 
            this.PhoneNum.Font = new System.Drawing.Font("宋体", 20F);
            this.PhoneNum.Location = new System.Drawing.Point(231, 198);
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Size = new System.Drawing.Size(170, 40);
            this.PhoneNum.TabIndex = 28;
            this.PhoneNum.Text = "手机号：";
            this.PhoneNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SexStr
            // 
            this.SexStr.Font = new System.Drawing.Font("宋体", 20F);
            this.SexStr.Location = new System.Drawing.Point(243, 238);
            this.SexStr.Name = "SexStr";
            this.SexStr.Size = new System.Drawing.Size(170, 40);
            this.SexStr.TabIndex = 29;
            this.SexStr.Text = "性别：";
            this.SexStr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BirthStr
            // 
            this.BirthStr.Font = new System.Drawing.Font("宋体", 20F);
            this.BirthStr.Location = new System.Drawing.Point(243, 278);
            this.BirthStr.Name = "BirthStr";
            this.BirthStr.Size = new System.Drawing.Size(170, 40);
            this.BirthStr.TabIndex = 30;
            this.BirthStr.Text = "会员生日：";
            this.BirthStr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LevelNum
            // 
            this.LevelNum.Font = new System.Drawing.Font("宋体", 20F);
            this.LevelNum.Location = new System.Drawing.Point(243, 318);
            this.LevelNum.Name = "LevelNum";
            this.LevelNum.Size = new System.Drawing.Size(170, 40);
            this.LevelNum.TabIndex = 31;
            this.LevelNum.Text = "会员等级：";
            this.LevelNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("宋体", 20F);
            this.Status.Location = new System.Drawing.Point(116, 118);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(96, 40);
            this.Status.TabIndex = 32;
            this.Status.Text = "状态：";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusStr
            // 
            this.StatusStr.Font = new System.Drawing.Font("宋体", 20F);
            this.StatusStr.ForeColor = System.Drawing.Color.Red;
            this.StatusStr.Location = new System.Drawing.Point(210, 118);
            this.StatusStr.Name = "StatusStr";
            this.StatusStr.Size = new System.Drawing.Size(203, 40);
            this.StatusStr.TabIndex = 33;
            this.StatusStr.Text = "正常使用";
            this.StatusStr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_SearchCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 385);
            this.Controls.Add(this.StatusStr);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.LevelNum);
            this.Controls.Add(this.BirthStr);
            this.Controls.Add(this.SexStr);
            this.Controls.Add(this.PhoneNum);
            this.Controls.Add(this.ConnVipId);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.Birth);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.ConnVip);
            this.Controls.Add(this.CardBalanceNum);
            this.Controls.Add(this.CardBalance);
            this.Controls.Add(this.TCardNum);
            this.Controls.Add(this.Card);
            this.Name = "Form_SearchCard";
            this.Text = "查询会员";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Card;
        private System.Windows.Forms.Label TCardNum;
        private System.Windows.Forms.Label CardBalance;
        private System.Windows.Forms.Label CardBalanceNum;
        private System.Windows.Forms.Label ConnVip;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Birth;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.Label ConnVipId;
        private System.Windows.Forms.Label PhoneNum;
        private System.Windows.Forms.Label SexStr;
        private System.Windows.Forms.Label BirthStr;
        private System.Windows.Forms.Label LevelNum;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label StatusStr;
    }
}