﻿using System;
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
    public partial class Form_FirstGuild : Form
    {
        public Form_FirstGuild()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.textBox1.Text = ControCenter.GetFeatureCode();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ControCenter.CertifyCDK(this.textBox2.Text))
            {
                this.Close();
                Form_log Log = new Form_log();
            }
            else
            {
                MessageBox.Show("激活码错误！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_log Log = new Form_log();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            waiter.ProjectForm.Close();
        }
    }
}
