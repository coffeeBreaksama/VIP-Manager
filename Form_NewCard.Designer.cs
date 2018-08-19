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
            this.BtnNewCard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TCardNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNewCard
            // 
            this.BtnNewCard.Font = new System.Drawing.Font("宋体", 35F);
            this.BtnNewCard.Location = new System.Drawing.Point(412, 452);
            this.BtnNewCard.Name = "BtnNewCard";
            this.BtnNewCard.Size = new System.Drawing.Size(284, 64);
            this.BtnNewCard.TabIndex = 0;
            this.BtnNewCard.Text = "选择文件";
            this.BtnNewCard.UseVisualStyleBackColor = true;
            this.BtnNewCard.Click += new System.EventHandler(this.BtnNewCard_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "使用说明：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TCardNum
            // 
            this.TCardNum.Font = new System.Drawing.Font("宋体", 20F);
            this.TCardNum.ForeColor = System.Drawing.Color.Red;
            this.TCardNum.Location = new System.Drawing.Point(33, 180);
            this.TCardNum.Name = "TCardNum";
            this.TCardNum.Size = new System.Drawing.Size(177, 123);
            this.TCardNum.TabIndex = 2;
            this.TCardNum.Text = "2.表格格式必须按照要求编写，具体参见表格格式；";
            this.TCardNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 20F);
            this.label2.Location = new System.Drawing.Point(33, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 120);
            this.label2.TabIndex = 3;
            this.label2.Text = "1：初期使用请仔细核对生成的结果";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 20F);
            this.label3.Location = new System.Drawing.Point(33, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 85);
            this.label3.TabIndex = 4;
            this.label3.Text = "3：生成的表格在同路径下";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(292, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1142, 387);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 35F);
            this.button1.Location = new System.Drawing.Point(1043, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 64);
            this.button1.TabIndex = 6;
            this.button1.Text = "生成表格";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 20F);
            this.label4.Location = new System.Drawing.Point(287, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 40);
            this.label4.TabIndex = 7;
            this.label4.Text = "生成预览：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_NewCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 519);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TCardNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNewCard);
            this.Name = "Form_NewCard";
            this.Text = "快速报价";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNewCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TCardNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}