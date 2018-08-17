namespace SysCard
{
    partial class Form_TopIn
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
            this.BtnNewCard = new System.Windows.Forms.Button();
            this.Buy = new System.Windows.Forms.Label();
            this.Free = new System.Windows.Forms.Label();
            this.FreeNum = new System.Windows.Forms.Label();
            this.tex_BuyN = new System.Windows.Forms.TextBox();
            this.CardBalance = new System.Windows.Forms.Label();
            this.CardBalanceNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Card
            // 
            this.Card.Font = new System.Drawing.Font("宋体", 20F);
            this.Card.Location = new System.Drawing.Point(143, 50);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(96, 40);
            this.Card.TabIndex = 2;
            this.Card.Text = "卡号：";
            this.Card.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TCardNum
            // 
            this.TCardNum.Font = new System.Drawing.Font("宋体", 20F);
            this.TCardNum.ForeColor = System.Drawing.Color.Red;
            this.TCardNum.Location = new System.Drawing.Point(228, 50);
            this.TCardNum.Name = "TCardNum";
            this.TCardNum.Size = new System.Drawing.Size(222, 40);
            this.TCardNum.TabIndex = 3;
            this.TCardNum.Text = "未读取到卡号";
            this.TCardNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TCardNum.TextChanged += new System.EventHandler(this.TCardNum_TextChanged);
            // 
            // BtnNewCard
            // 
            this.BtnNewCard.Font = new System.Drawing.Font("宋体", 35F);
            this.BtnNewCard.Location = new System.Drawing.Point(148, 310);
            this.BtnNewCard.Name = "BtnNewCard";
            this.BtnNewCard.Size = new System.Drawing.Size(284, 64);
            this.BtnNewCard.TabIndex = 4;
            this.BtnNewCard.Text = "充值";
            this.BtnNewCard.UseVisualStyleBackColor = true;
            this.BtnNewCard.Click += new System.EventHandler(this.BtnNewCard_Click);
            // 
            // Buy
            // 
            this.Buy.Font = new System.Drawing.Font("宋体", 20F);
            this.Buy.Location = new System.Drawing.Point(107, 165);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(153, 40);
            this.Buy.TabIndex = 6;
            this.Buy.Text = "充值金额：";
            this.Buy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Free
            // 
            this.Free.Font = new System.Drawing.Font("宋体", 20F);
            this.Free.Location = new System.Drawing.Point(107, 235);
            this.Free.Name = "Free";
            this.Free.Size = new System.Drawing.Size(153, 40);
            this.Free.TabIndex = 7;
            this.Free.Text = "赠送金额：";
            this.Free.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FreeNum
            // 
            this.FreeNum.Font = new System.Drawing.Font("宋体", 20F);
            this.FreeNum.ForeColor = System.Drawing.Color.Red;
            this.FreeNum.Location = new System.Drawing.Point(247, 235);
            this.FreeNum.Name = "FreeNum";
            this.FreeNum.Size = new System.Drawing.Size(203, 40);
            this.FreeNum.TabIndex = 8;
            this.FreeNum.Text = "0000";
            this.FreeNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tex_BuyN
            // 
            this.tex_BuyN.Location = new System.Drawing.Point(266, 168);
            this.tex_BuyN.MaxLength = 6;
            this.tex_BuyN.Multiline = true;
            this.tex_BuyN.Name = "tex_BuyN";
            this.tex_BuyN.Size = new System.Drawing.Size(166, 37);
            this.tex_BuyN.TabIndex = 9;
            this.tex_BuyN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_BuyN_KeyPress);
            // 
            // CardBalance
            // 
            this.CardBalance.Font = new System.Drawing.Font("宋体", 20F);
            this.CardBalance.Location = new System.Drawing.Point(143, 113);
            this.CardBalance.Name = "CardBalance";
            this.CardBalance.Size = new System.Drawing.Size(96, 40);
            this.CardBalance.TabIndex = 10;
            this.CardBalance.Text = "余额：";
            this.CardBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardBalanceNum
            // 
            this.CardBalanceNum.Font = new System.Drawing.Font("宋体", 20F);
            this.CardBalanceNum.ForeColor = System.Drawing.Color.Red;
            this.CardBalanceNum.Location = new System.Drawing.Point(245, 113);
            this.CardBalanceNum.Name = "CardBalanceNum";
            this.CardBalanceNum.Size = new System.Drawing.Size(203, 40);
            this.CardBalanceNum.TabIndex = 11;
            this.CardBalanceNum.Text = "0000";
            this.CardBalanceNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_TopIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 427);
            this.Controls.Add(this.CardBalanceNum);
            this.Controls.Add(this.CardBalance);
            this.Controls.Add(this.tex_BuyN);
            this.Controls.Add(this.FreeNum);
            this.Controls.Add(this.Free);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.BtnNewCard);
            this.Controls.Add(this.TCardNum);
            this.Controls.Add(this.Card);
            this.Name = "Form_TopIn";
            this.Text = "充值";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Card;
        private System.Windows.Forms.Label TCardNum;
        private System.Windows.Forms.Button BtnNewCard;
        private System.Windows.Forms.Label Buy;
        private System.Windows.Forms.Label Free;
        private System.Windows.Forms.Label FreeNum;
        private System.Windows.Forms.TextBox tex_BuyN;
        private System.Windows.Forms.Label CardBalance;
        private System.Windows.Forms.Label CardBalanceNum;
    }
}