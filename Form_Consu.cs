using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysCard.DAL.Waiter;

namespace SysCard
{
    public partial class Form_Consu : Form
    {
        public Form_Consu()
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


        private void BtnNewCard_Click(object sender, EventArgs e)
        {
            waiter.Consume(this.TCardNum.Text, this.tex_BuyN.Text, this);
        }

        private void TCardNum_TextChanged(object sender, EventArgs e)
        {
            this.CardBalanceNum.Text = waiter.GetCardBalanceNum(this.TCardNum.Text);
        }

        private void BtnConsu_Click(object sender, EventArgs e)
        {
            waiter.Consume(this.TCardNum.Text, this.tex_BuyN.Text, this);
        }
    }

    }
