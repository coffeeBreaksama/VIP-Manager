using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SysCard.DAL;
using System.Data.OleDb;
using SysCard.DAL.Waiter;
using SysCard.DAL.Manager;
using SysCard.DAL.Data;

namespace SysCard
{
    public partial class Form_purchase : Form
    {
        public Form_purchase()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.textBox1.Text = ControCenter.GetXufeiCode();
            this.label4.Text = ControCenter.remainDays.ToString();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ControCenter.CertifyXufeiCode(this.textBox1.Text, this.textBox2.Text))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("激活码错误！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(this.label4.Text) < 0)
            {
                waiter.ProjectForm.Close();
            }
            else
                this.Close();
        }
    }
}
