﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysCard.DAL.Waiter;
using SysCard.DAL.Data;

namespace SysCard
{
    public partial class Form_SearchCard : Form
    {
        public VipInfo vipinfo = new VipInfo(0);
        
        public Form_SearchCard()
        {
            InitializeComponent();
            this.CenterToScreen();
            //this.FormBorderStyle = FormBorderStyle.None;
            this.Show();
        }

        private void TCardNum_Click(object sender, EventArgs e)
        {
            
        }

        private void CardBalanceNum_Click(object sender, EventArgs e)
        {

        }
    }
}
