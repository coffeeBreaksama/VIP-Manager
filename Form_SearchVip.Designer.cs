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
            this.textpara3 = new System.Windows.Forms.TextBox();
            this.textpara2 = new System.Windows.Forms.TextBox();
            this.textpara1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.tex_id = new System.Windows.Forms.TextBox();
            this.tex_name = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1267, 369);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textpara3);
            this.groupBox2.Controls.Add(this.textpara2);
            this.groupBox2.Controls.Add(this.textpara1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Phone);
            this.groupBox2.Controls.Add(this.name);
            this.groupBox2.Controls.Add(this.tex_id);
            this.groupBox2.Controls.Add(this.tex_name);
            this.groupBox2.Controls.Add(this.Search);
            this.groupBox2.Location = new System.Drawing.Point(25, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1254, 185);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // textBox3
            // 
            this.textpara3.Location = new System.Drawing.Point(878, 79);
            this.textpara3.Name = "textBox3";
            this.textpara3.Size = new System.Drawing.Size(100, 21);
            this.textpara3.TabIndex = 8;
            this.textpara3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textpara2.Location = new System.Drawing.Point(678, 81);
            this.textpara2.Name = "textBox2";
            this.textpara2.Size = new System.Drawing.Size(100, 21);
            this.textpara2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textpara1.Location = new System.Drawing.Point(450, 81);
            this.textpara1.Name = "textBox1";
            this.textpara1.Size = new System.Drawing.Size(100, 21);
            this.textpara1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(804, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "参数3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "参数2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "参数1";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(188, 84);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(29, 12);
            this.Phone.TabIndex = 2;
            this.Phone.Text = "序号";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(9, 84);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(53, 12);
            this.name.TabIndex = 2;
            this.name.Text = "物品名称";
            // 
            // tex_phone
            // 
            this.tex_id.Location = new System.Drawing.Point(239, 81);
            this.tex_id.Name = "tex_phone";
            this.tex_id.Size = new System.Drawing.Size(100, 21);
            this.tex_id.TabIndex = 1;
            // 
            // tex_name
            // 
            this.tex_name.Location = new System.Drawing.Point(68, 81);
            this.tex_name.Name = "tex_name";
            this.tex_name.Size = new System.Drawing.Size(100, 21);
            this.tex_name.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(1054, 79);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 0;
            this.Search.Text = "查询";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Form_SearchVip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 617);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_SearchVip";
            this.Text = "Form_SearchVip";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox tex_id;
        private System.Windows.Forms.TextBox tex_name;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textpara3;
        private System.Windows.Forms.TextBox textpara2;
        private System.Windows.Forms.TextBox textpara1;
    }
}