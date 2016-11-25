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
    public partial class FormUpdate : Form
    {
        public AdminInfo admin;
        public FormUpdate()
        {
            InitializeComponent();
        }
        public FormUpdate(AdminInfo adminfor)
        {
            InitializeComponent();
            admin = adminfor;
            this.tex_name.Text = admin.Adminname;
            this.tex_pwd.Text = admin.Userpwd;
            this.tex_user.Text = admin.Username;//5&1&a&s&p&x
            this.CenterToParent();
            this.tex_name.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            admin.Userpwd = this.tex_pwd.Text;
            int ret = AdminServices.UpdataAdmin(admin);
            
            if (ret > 0)
            {
                MessageBox.Show("操作成功");                
            }
            
        }
    }
}