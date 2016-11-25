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
    public partial class Form_SearchVip : Form
    {

        static List<VipInfo> vip;
        public Form_SearchVip()
        {
            InitializeComponent();
            dataGridView1.DataSource = waiter.SearchAllVipInfo();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vip = waiter.SearchVipInfo(this.tex_name.Text, this.tex_phone.Text);
            dataGridView1.DataSource = vip;
            if (vip.Count > 0)
            {
                this.CardNum.Text = vip[0].ConnectCarNum;
            }
        }

        private void ReportLoss_Click(object sender, EventArgs e)
        {
            if (vip != null && vip.Count > 0)
            {
                waiter.ReportLoss(this.CardNum.Text, vip[0]);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (vip != null && vip.Count > 0)
            {
                waiter.CancelLoss(this.CardNum.Text, vip[0]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (vip != null && vip.Count > 0)
            {
                waiter.ReissueCard(vip[0],this.Reissue.Text);
            }
        }
    }
}
