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
            InitializeComponent();
        }
        public FormUpdate(employeeInfo adminfor)
        {
            InitializeComponent();
            admin = adminfor;
            this.tex_name.Text = admin.Name;
            this.tex_pwd.Text = admin.Password;
            this.tex_user.Text = admin.Name;//5&1&a&s&p&x
            this.CenterToParent();
            this.tex_name.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            admin.Password = this.tex_pwd.Text;
            int ret = DataService.UpdataEmployee(admin);
            
            if (ret > 0)
            {
                MessageBox.Show("操作成功");                
            }
            
        }
    }
}