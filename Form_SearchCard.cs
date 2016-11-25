using System;
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
            this.timer1.Enabled = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.Show();
        }

        private void TCardNum_Click(object sender, EventArgs e)
        {
            
        }

        private void CardBalanceNum_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.TCardNum.Text = waiter.GetPortCardNum();
            vipinfo = waiter.SearchVipInfo(this.TCardNum.Text,this.vipinfo);
            this.CardBalanceNum.Text = waiter.GetCardBalanceNum(this.TCardNum.Text);
            this.StatusStr.Text = waiter.GetCardStatus(this.TCardNum.Text);
            this.ConnVipId.Text = vipinfo.Name;
            this.PhoneNum.Text = vipinfo.Phone;
            this.SexStr.Text = vipinfo.Sex;
            this.BirthStr.Text = vipinfo.Birthday;
            this.LevelNum.Text = vipinfo.Level.ToString();
        }
    }
}
