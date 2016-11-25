namespace SysCard
{
    partial class Form_Consu
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
            this.tex_BuyN = new System.Windows.Forms.TextBox();
            this.Buy = new System.Windows.Forms.Label();
            this.BtnConsu = new System.Windows.Forms.Button();
            this.TCardNum = new System.Windows.Forms.Label();
            this.Card = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CardBalanceNum
            // 
            this.CardBalanceNum.Font = new System.Drawing.Font("宋体", 20F);
            this.CardBalanceNum.ForeColor = System.Drawing.Color.Red;
            this.CardBalanceNum.Location = new System.Drawing.Point(236, 108);
            this.CardBalanceNum.Name = "CardBalanceNum";
            this.CardBalanceNum.Size = new System.Drawing.Size(203, 40);
            this.CardBalanceNum.TabIndex = 20;
            this.CardBalanceNum.Text = "0000";
            this.CardBalanceNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardBalance
            // 
            this.CardBalance.Font = new System.Drawing.Font("宋体", 20F);
            this.CardBalance.Location = new System.Drawing.Point(134, 108);
            this.CardBalance.Name = "CardBalance";
            this.CardBalance.Size = new System.Drawing.Size(96, 40);
            this.CardBalance.TabIndex = 19;
            this.CardBalance.Text = "余额：";
            this.CardBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tex_BuyN
            // 
            this.tex_BuyN.Location = new System.Drawing.Point(257, 163);
            this.tex_BuyN.MaxLength = 6;
            this.tex_BuyN.Multiline = true;
            this.tex_BuyN.Name = "tex_BuyN";
            this.tex_BuyN.Size = new System.Drawing.Size(166, 37);
            this.tex_BuyN.TabIndex = 18;
            // 
            // Buy
            // 
            this.Buy.Font = new System.Drawing.Font("宋体", 20F);
            this.Buy.Location = new System.Drawing.Point(98, 160);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(153, 40);
            this.Buy.TabIndex = 15;
            this.Buy.Text = "消费金额：";
            this.Buy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnConsu
            // 
            this.BtnConsu.Font = new System.Drawing.Font("宋体", 35F);
            this.BtnConsu.Location = new System.Drawing.Point(139, 249);
            this.BtnConsu.Name = "BtnConsu";
            this.BtnConsu.Size = new System.Drawing.Size(284, 64);
            this.BtnConsu.TabIndex = 14;
            this.BtnConsu.Text = "消费";
            this.BtnConsu.UseVisualStyleBackColor = true;
            this.BtnConsu.Click += new System.EventHandler(this.BtnConsu_Click);
            // 
            // TCardNum
            // 
            this.TCardNum.Font = new System.Drawing.Font("宋体", 20F);
            this.TCardNum.ForeColor = System.Drawing.Color.Red;
            this.TCardNum.Location = new System.Drawing.Point(219, 45);
            this.TCardNum.Name = "TCardNum";
            this.TCardNum.Size = new System.Drawing.Size(222, 40);
            this.TCardNum.TabIndex = 13;
            this.TCardNum.Text = "未读取到卡号";
            this.TCardNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TCardNum.TextChanged += new System.EventHandler(this.TCardNum_TextChanged);
            // 
            // Card
            // 
            this.Card.Font = new System.Drawing.Font("宋体", 20F);
            this.Card.Location = new System.Drawing.Point(134, 45);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(96, 40);
            this.Card.TabIndex = 12;
            this.Card.Text = "卡号：";
            this.Card.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_Consu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 362);
            this.Controls.Add(this.CardBalanceNum);
            this.Controls.Add(this.CardBalance);
            this.Controls.Add(this.tex_BuyN);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.BtnConsu);
            this.Controls.Add(this.TCardNum);
            this.Controls.Add(this.Card);
            this.Name = "Form_Consu";
            this.Text = "消费";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CardBalanceNum;
        private System.Windows.Forms.Label CardBalance;
        private System.Windows.Forms.TextBox tex_BuyN;
        private System.Windows.Forms.Label Buy;
        private System.Windows.Forms.Button BtnConsu;
        private System.Windows.Forms.Label TCardNum;
        private System.Windows.Forms.Label Card;
        private System.Windows.Forms.Timer timer1;
    }
}