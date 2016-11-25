using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysCard.DAL.Waiter;
using SysCard.DAL.Manager;

namespace SysCard
{
    public partial class Form_TopIn : Form
    {
        public Form_TopIn()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.timer1.Enabled = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.Show();
        }

        private void tex_BuyN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//backspace
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//0-9
                {
                    e.Handled = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)//System.Data.OleDb.OleDbException错误防范
        {
            this.TCardNum.Text = waiter.GetPortCardNum();
        }

        private void BtnNewCard_Click(object sender, EventArgs e)
        {
            waiter.TopIn(this.TCardNum.Text, this.tex_BuyN.Text, this);
        }

        private void TCardNum_TextChanged(object sender, EventArgs e)
        {
            this.FreeNum.Text = waiter.GetTopInFreeNum(tex_BuyN.Text);
            this.CardBalanceNum.Text = waiter.GetCardBalanceNum(this.TCardNum.Text);
        }
    }
}
