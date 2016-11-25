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
    public partial class Form_NewVip : Form
    {

        public static VipInfo vip = new VipInfo();
        public Form_NewVip()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.timer1.Enabled = true;
            this.comboBox1.Items.Add("男");
            this.comboBox1.Items.Add("女");
            this.comboBox1.SelectedItem = this.comboBox1.Items[0];
            //this.FormBorderStyle = FormBorderStyle.None;
            this.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tex_time_MouseClick(object sender, MouseEventArgs e)
        {
            this.tex_time.Focus();
            this.monthCalendar1.Show();
        }

        private void monthCalendar1_MouseLeave(object sender, EventArgs e)
        {
            this.monthCalendar1.Visible = false;
        }

        private void monthCalendar1_MouseDown(object sender, MouseEventArgs e)
        {
            this.tex_time.Text = this.monthCalendar1.SelectionEnd.ToString().Substring(0, 10);

            if (this.tex_time.Text.Length > 0)
            {
                this.monthCalendar1.SelectionStart = DateTime.Parse(this.tex_time.Text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.TCardNum.Text = waiter.GetPortCardNum();
            this.CardBalanceNum.Text = waiter.GetCardBalanceNum(this.TCardNum.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vip.Name = this.tex_name.Text;
            vip.Birthday = this.tex_time.Text;
            vip.Phone = this.tex_phone.Text;
            vip.Sex = this.comboBox1.Text;
            waiter.AddNewViper(vip, this.TCardNum.Text);
        }
    }
}
