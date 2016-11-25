namespace SysCard
{
    partial class Form_SearchVip
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Phone = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.tex_phone = new System.Windows.Forms.TextBox();
            this.tex_name = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.ReportLoss = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Card = new System.Windows.Forms.Label();
            this.CardNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Reissue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(788, 224);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Phone);
            this.groupBox2.Controls.Add(this.name);
            this.groupBox2.Controls.Add(this.tex_phone);
            this.groupBox2.Controls.Add(this.tex_name);
            this.groupBox2.Controls.Add(this.Search);
            this.groupBox2.Location = new System.Drawing.Point(25, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 65);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(188, 26);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(41, 12);
            this.Phone.TabIndex = 2;
            this.Phone.Text = "手机号";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(17, 26);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 12);
            this.name.TabIndex = 2;
            this.name.Text = "姓名";
            // 
            // tex_phone
            // 
            this.tex_phone.Location = new System.Drawing.Point(247, 23);
            this.tex_phone.Name = "tex_phone";
            this.tex_phone.Size = new System.Drawing.Size(100, 21);
            this.tex_phone.TabIndex = 1;
            // 
            // tex_name
            // 
            this.tex_name.Location = new System.Drawing.Point(76, 23);
            this.tex_name.Name = "tex_name";
            this.tex_name.Size = new System.Drawing.Size(100, 21);
            this.tex_name.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(369, 21);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 0;
            this.Search.Text = "查询";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReportLoss
            // 
            this.ReportLoss.Location = new System.Drawing.Point(221, 23);
            this.ReportLoss.Name = "ReportLoss";
            this.ReportLoss.Size = new System.Drawing.Size(75, 23);
            this.ReportLoss.TabIndex = 3;
            this.ReportLoss.Text = "挂失";
            this.ReportLoss.UseVisualStyleBackColor = true;
            this.ReportLoss.Click += new System.EventHandler(this.ReportLoss_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Reissue);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.Card);
            this.groupBox1.Controls.Add(this.CardNum);
            this.groupBox1.Controls.Add(this.ReportLoss);
            this.groupBox1.Location = new System.Drawing.Point(25, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 65);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Card
            // 
            this.Card.AutoSize = true;
            this.Card.Location = new System.Drawing.Point(17, 26);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(29, 12);
            this.Card.TabIndex = 2;
            this.Card.Text = "卡号";
            // 
            // CardNum
            // 
            this.CardNum.Location = new System.Drawing.Point(76, 23);
            this.CardNum.Name = "CardNum";
            this.CardNum.Size = new System.Drawing.Size(100, 21);
            this.CardNum.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "取消挂失";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(587, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "补卡";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Reissue
            // 
            this.Reissue.Location = new System.Drawing.Point(452, 25);
            this.Reissue.Name = "Reissue";
            this.Reissue.Size = new System.Drawing.Size(100, 21);
            this.Reissue.TabIndex = 6;
            // 
            // Form_SearchVip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 485);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_SearchVip";
            this.Text = "Form_SearchVip";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox tex_phone;
        private System.Windows.Forms.TextBox tex_name;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button ReportLoss;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Card;
        private System.Windows.Forms.TextBox CardNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Reissue;
    }
}