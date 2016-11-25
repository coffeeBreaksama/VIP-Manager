using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysCard.DAL;
using SysCard.Models;
namespace SysCard
{
    public partial class Form_dispPk : Form
    {
    //    public List<BuyBk> blist;
        public Form_dispPk()
        {
            InitializeComponent();
            CenterToParent();
            List<BuyBk> list = BuyBkServices.GetAllBuyBk();
            dataGridView1.DataSource = list;
          //  blist = list;
            float sun = 0f;
            float disp = 0f;
            float user = 0f;

            for (int i = 0; i < list.Count; i++)
            {
                sun += float.Parse(list[i].Buyprice);
                if (list[i].BuyFrom == "system")
                {
                    disp += float.Parse(list[i].Buyprice);
                }
                else
                {
                    user += float.Parse(list[i].Buyprice);
                }
            }
            this.lab_dis.Text = disp.ToString("0.00");
            this.lab_sun.Text = sun.ToString("0.00");
            this.lab_user.Text = user.ToString("0.00");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show();
            //0012582922
            if (this.tex_begin.Text.Length > 0 && this.tex_end.Text.Length>0)
            {
                List<BuyBk> list = BuyBkServices.GetAllBuyBkByTime(this.tex_begin.Text, this.tex_end.Text + " 23:59");
                dataGridView1.DataSource = list;
                float sun = 0f;
                float disp = 0f;
                float user = 0f;

                for (int i = 0; i < list.Count; i++)
                {
                    sun += float.Parse(list[i].Buyprice);
                    if (list[i].BuyFrom == "system")
                    {
                        disp += float.Parse(list[i].Buyprice);
                    }
                    else
                    {
                        user += float.Parse(list[i].Buyprice);
                    }
                }
                this.lab_dis.Text = disp.ToString("0.00");
                this.lab_sun.Text = sun.ToString("0.00");
                this.lab_user.Text = user.ToString("0.00");
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          

        }
    }
}