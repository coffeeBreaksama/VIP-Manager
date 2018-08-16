using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysCard.DAL;
using System.Data.OleDb;
using SysCard.DAL.Waiter;
using SysCard.DAL.Manager;


namespace SysCard
{
    public partial class Form_loading : Form
    {
        public Form_loading()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.labload.Width = 0;
            CenterToScreen();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labload.Width += 3;
            if (labload.Width >= label1.Width)
            {
                this.timer1.Enabled = false;
                waiter.StartLog(this);

            }
        }
    }
}