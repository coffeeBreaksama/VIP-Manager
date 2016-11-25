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
    public partial class Form_Pay : Form
    {
        private float price;
        private Form_BuyBK fc;
        private UserInfo user;
        private List<BuyBk> blist = new List<BuyBk>();
        public Form_Pay()
        {
            InitializeComponent();
        
        }   
        public Form_Pay(float p,Form_BuyBK f)
        {
            InitializeComponent();
            price = p;
            CenterToParent();
            this.textBox1.Select();
            fc = f;
            this.tex_in.Text = p.ToString("0.00");
        }
        public Form_Pay(float p, Form_BuyBK f,List<BuyFz> tlist)
        {
            InitializeComponent();
            price = p;
            CenterToParent();
            this.textBox1.Select();
            fc = f;
            this.tex_in.Text = p.ToString("0.00");
            for (int i = 0; i < tlist.Count; i++)
            {
                BuyBk bb = new BuyBk();
                bb.BuyFrom = "system";
                bb.Buyprice = tlist[i].Price.ToString();
                bb.Buyproduct = tlist[i].Pname;
                bb.Buytime = DateTime.Now.ToString();
                bb.Count = tlist[i].Count;
                blist.Add(bb);
            }


        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                 user = UserServices.GetUserInfoByCard(this.textBox1.Text);

                if (user != null)
                {

                    this.tex_tel.Text = user.Usertel;
                    this.tex_price.Text = user.Price.ToString();
                    this.tex_name.Text = user.Username;
                    this.button2.Focus();
                }
                else
                {
                    MessageBox.Show("没有此会员！");
                    this.Close();
                }

                
                    
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            if (user.Price < price)
            {
                MessageBox.Show("余额不足!!");
                this.Close();
            }
            else
            {
                float dp = user.Price - price;
                dp = float.Parse(dp.ToString("0.00"));
                int ret = UserServices.Pay_pro(dp, this.textBox1.Text);
                if (ret > 0)
                {
                    for (int i = 0; i < blist.Count; i++)
                    {
                        blist[i].BuyFrom = this.textBox1.Text;
                        BuyBkServices.AddByBk(blist[i]);
                    }


                    MessageBox.Show("支付成功，你的余额是" + dp.ToString("0.00") + "元");
                    this.Close();
                    fc.textBox1.Select();
                    fc.formclea();


                }
                else
                {
                    MessageBox.Show("支付失败！");
                    this.Close();
                }
        }
        }
    }
}