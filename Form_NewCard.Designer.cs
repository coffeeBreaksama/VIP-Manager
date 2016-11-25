namespace SysCard
{
    partial class Form_NewCard
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
            this.BtnNewCard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TCardNum = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BtnNewCard
            // 
            this.BtnNewCard.Font = new System.Drawing.Font("宋体", 35F);
            this.BtnNewCard.Location = new System.Drawing.Point(43, 142);
            this.BtnNewCard.Name = "BtnNewCard";
            this.BtnNewCard.Size = new System.Drawing.Size(284, 64);
            this.BtnNewCard.TabIndex = 0;
            this.BtnNewCard.Text = "发卡";
            this.BtnNewCard.UseVisualStyleBackColor = true;
            this.BtnNewCard.Click += new System.EventHandler(this.BtnNewCard_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "卡号：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TCardNum
            // 
            this.TCardNum.Font = new System.Drawing.Font("宋体", 20F);
            this.TCardNum.ForeColor = System.Drawing.Color.Red;
            this.TCardNum.Location = new System.Drawing.Point(116, 46);
            this.TCardNum.Name = "TCardNum";
            this.TCardNum.Size = new System.Drawing.Size(254, 40);
            this.TCardNum.TabIndex = 2;
            this.TCardNum.Text = "未读取到卡号";
            this.TCardNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_NewCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 254);
            this.Controls.Add(this.TCardNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNewCard);
            this.Name = "Form_NewCard";
            this.Text = "发卡";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNewCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TCardNum;
        private System.Windows.Forms.Timer timer1;
    }
}