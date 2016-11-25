using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysCard.DAL;

namespace SysCard
{
    public partial class Form_dispbk : Form
    {
        public Form_dispbk()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = BuyBkServices.GetAllBuyBk();
            CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show();
            //0012582922
            dataGridView1.DataSource =  BuyBkServices.GetAllBuyBkByTime(this.tex_begin.Text,this.tex_end.Text);

        }
    }
}