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
    public partial class Form_log : Form
    {
        public static AdminInfo logadmin;
        public static Form ff;


        public Form_log()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.tex_pwd.PasswordChar = '*';
            this.tex_User.TabIndex = 0;
            this.tex_pwd.TabIndex = 1;
            this.btn_log.TabIndex = 2;
            this.btn_can.TabIndex = 3;
            
        }
        public Form_log(Form f)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.tex_pwd.PasswordChar = '*';
            this.tex_User.TabIndex = 0;
            this.tex_pwd.TabIndex = 1;
            this.btn_log.TabIndex = 2;
            this.btn_can.TabIndex = 3;
            ff = f;
            this.FormBorderStyle = FormBorderStyle.None;

        }
        
        private void log()
        {
            AdminInfo admin = AdminServices.LoginAdmin(this.tex_User.Text, this.tex_pwd.Text);
           // MessageBox.Show(admin.Adminname);
            try
            {
                if (admin.Adminname != null)
                {
                    Form_main f = new Form_main(admin,this);
                    f.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("用户名密码错误!!");
                    this.tex_pwd.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("系统发生不明错误，请联系管理员！！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.tex_User.Height = this.tex_pwd.Height;
                        log();
                      //  this.Visible = false;
            
        }

        private void btn_log_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void tex_pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                log(); ;
            }
           
         
        }
        private string std="";

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(std);

        }

        private void Form_log_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form_log_FormClosed(object sender, FormClosedEventArgs e)
        {
            ff.Close();
        }
    }
}