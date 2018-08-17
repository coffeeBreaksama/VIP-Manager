using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SysCard
{
    public partial class Test : Form
    {

        private string input;
        private string output;
        public Test()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.checkBox1.CheckState == CheckState.Checked) this.checkBox1.CheckState = CheckState.Unchecked;
            if (this.timer1.Enabled == true)
                this.timer1.Enabled = false;
            else
                this.timer1.Enabled = true;
            this.BackColor = Color.DarkBlue;
            MessageBox.Show("1");
            
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Width -= 5;
            if (this.progressBar1.Width <= 0)
                this.progressBar1.Width = 200;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            output = this.textBox1.Text;
            input = output;
            this.textBox2.Text = input;
            //this.textBox2.AppendText(input);
            //this.textBox2.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
