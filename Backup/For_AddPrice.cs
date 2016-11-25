using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysCard.Models;
using SysCard.DAL;

namespace SysCard
{
    public partial class For_AddPrice : Form
    {
        public For_AddPrice()
        {
            InitializeComponent();
            CenterToParent();
            this.textBox1.Select();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                UserInfo user = UserServices.GetUserInfoByCard(this.textBox1.Text);
                if (user == null)
                {
                    MessageBox.Show("用户不存在！！");
                    this.Close();
                }
                else
                {
                  //  textBox1.Text = "";
                    this.tex_tel.Text = user.Usertel;
                    this.tex_phone.Text = user.Userphone;
                    this.tex_name.Text = user.Username;
                    this.tex_addr.Text = user.Useraddr;
                    this.tex_job.Text = user.Userjob;
                    label6.Text = user.Price.ToString();
                    this.jine.Focus();

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void jine_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                float pri = float.Parse(this.jine.Text) + float.Parse(this.label6.Text);
                pri =float.Parse( pri.ToString("0.00"));
               int ret = UserServices.Pay_pro(pri,this.textBox1.Text);
               if (ret > 0)
               {
                   MessageBox.Show("充值成功！！");
                   this.textBox1.Text = "";
                   this.textBox1.Focus();
                   this.label6.Text = pri.ToString();
                   this.jine.Text = "0";
               }
               else
               {
                   MessageBox.Show("充值失败!!");
                   this.Close();
               }
                
            }
        }
    }
}