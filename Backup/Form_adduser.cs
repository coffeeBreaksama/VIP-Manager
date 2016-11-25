using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysCard.DAL;
using SysCard.Models;

//源码下载 www.51aspx.com 
namespace SysCard
{
    public partial class Form_adduser : Form
    {
        public static string cardtk;
        public int key;
        public Form_adduser()
        {
            InitializeComponent();
            this.CenterToParent();
            this.comboBox1.Items.Add("男");
            this.comboBox1.Items.Add("女");
            this.comboBox1.SelectedItem = this.comboBox1.Items[0];
            //this.tex_card.Focus();
               
        }

        private void textBox7_MouseHover(object sender, EventArgs e)
        {
            this.tex_time.Focus();
            this.monthCalendar1.Show();
        }

        private void monthCalendar1_EnabledChanged(object sender, EventArgs e)
        {
          
        }

        private void monthCalendar1_MouseDown(object sender, MouseEventArgs e)
        {
            this.tex_time.Text = this.monthCalendar1.SelectionEnd.ToString().Substring(0,9);
        
            if (this.tex_time.Text.Length > 0)
            {
                this.monthCalendar1.SelectionStart = DateTime.Parse(this.tex_time.Text);
            }
           

        }

        private void monthCalendar1_MouseLeave(object sender, EventArgs e)
        {
            this.monthCalendar1.Visible = false;
        }

        private void tex_card_TextChanged(object sender, EventArgs e)
        {
            
         //   if(this.tex_card.Text.Length>=10)
           // this.tex_pwd.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserInfo user = new UserInfo();
            user.Carduser = tex_card.Text;
            user.Cardbak = this.tb_bk.Text;
            user.Cardpwd = this.tex_pwd.Text;
            user.Cardstata = this.cmb_stata.Checked ? "是" : "否";
            user.Cardtime = tex_time.Text;
            user.Useraddr = tex_addr.Text;
            user.Userbirth = tex_addr.Text;
            user.Userjob = tex_job.Text;
           // user.Userlove = tex_lo1
            user.Userlove = tex_love.Text;
            user.Username = tex_name.Text;
            user.Userphone = tex_phone.Text;
            user.Usersex = comboBox1.SelectedText;
            user.Usertel = tex_tel.Text;
            int ret = UserServices.AddUser(user);
            if (ret > 0)
            {
                MessageBox.Show("添加成功！！");
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败！！");
            }
        }

        private void tex_card_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==13)
            {
               cardtk =  this.tex_card.Text;
               // this.tex_pwd.Focus();
             //   this.tex_card.Enabled = false;
              //  this.tex_pwd.Text = this.tex_card.Text;
               key = e.KeyValue;

            }
        }

        private void tex_card_KeyUp(object sender, KeyEventArgs e)
        {
          //  MessageBox.Show(e.KeyValue.ToString());
            if (key == 13)
            {
                this.tex_card.Text = cardtk;
                this.tex_pwd.Focus();
                key = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

      

     
        
    }
}