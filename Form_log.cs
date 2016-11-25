using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysCard.DAL;
using SysCard.DAL.Data;
using SysCard.Models;
using SysCard.DAL.Waiter;
using SysCard.DAL.Manager;
using System.Data.SqlClient;


namespace SysCard
{   
    public partial class Form_log : Form
    {
        public Form_log()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.tex_pwd.PasswordChar = '*';
            this.tex_User.TabIndex = 0;
            this.tex_pwd.TabIndex = 1;
            this.btn_log.TabIndex = 2;
            this.btn_can.TabIndex = 3;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Show();
        }
   /*     public Form_log(Form f)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.tex_pwd.PasswordChar = '*';
            this.tex_User.TabIndex = 0;
            this.tex_pwd.TabIndex = 1;
            this.btn_log.TabIndex = 2;
            this.btn_can.TabIndex = 3;
            this.FormBorderStyle = FormBorderStyle.None;

        }
        
        /*private void log()
        {
            AdminType type;
            if (this.LogType.CheckState == CheckState.Checked)
            {
                type = AdminType.老板;
            }
            else
                type = AdminType.雇员;
            employeeInfo employee = DataService.LoginEmployee(this.tex_User.Text, this.tex_pwd.Text,type);
            //MessageBox.Show(admin.Adminname);
            try
            {
                if (employee.Name != null)
                {
                    Form_main f = new Form_main(ControCenter.NowLogAdmin, this);
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
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            waiter.EndProgram();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AdminType type;
            if (this.LogType.CheckState == CheckState.Checked)
            {
                type = AdminType.老板;
            }
            else
                type = AdminType.雇员;
            waiter.Log(this.tex_User.Text, this.tex_pwd.Text, type, this);

        }

    }
}