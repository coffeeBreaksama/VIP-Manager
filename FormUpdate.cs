using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysCard.Models;
using SysCard.DAL;
using SysCard.DAL.Data;
namespace SysCard
{
    public partial class FormUpdate : Form
    {
        public employeeInfo admin;
        public FormUpdate()
        {
            admin = new employeeInfo();
            InitializeComponent();
        }
        public FormUpdate(employeeInfo adminfor)
        {
            InitializeComponent();
            admin = adminfor;
            admin.Name = this.tex_user.Text;
            admin.Password = this.tex_pwd.Text;
            this.CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            admin.Name = this.tex_user.Text;
            admin.Password = this.tex_pwd.Text;
            if (DataService.LoginEmployee(admin.Name,admin.Password) != null && this.textBox1.Text != null)
            {
                admin.Password = this.textBox1.Text;//将密码改为新密码传入data里
                int ret = DataService.UpdataEmployee(admin);
                if (ret > 0)
                {
                    MessageBox.Show("操作成功");
                }
                else
                {
                    MessageBox.Show("操作失败，请核对密码");
                }
            }
           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}