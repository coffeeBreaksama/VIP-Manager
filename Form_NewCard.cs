using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysCard.DAL.Waiter;
using SysCard.DAL.Manager;
using SysCard.DAL.Data;
namespace SysCard
{
    public partial class Form_NewCard : Form
    {

        static public string path;

        public Form_NewCard()
        {
            InitializeComponent();
            this.CenterToScreen();
            //this.FormBorderStyle = FormBorderStyle.None;
            this.Show();
            //this.timer1.Enabled = true;
        }       

        private void BtnNewCard_Click(object sender, EventArgs e)
        {
            try
            {
                path = ControCenter.SelectPath();
                ControCenter.GetDataOfExcel(path);
                DataService.FillPriceOfDs();
                dataGridView1.DataSource = DataService.GetListFormDs();
            }
            catch
            {
                MessageBox.Show("打开文件失败。请确保文件格式正确");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataService.DsCoverToExcel(path);
            }
            catch
            {
                MessageBox.Show("生成表格失败，请删除目录下的上一个已生成表格，再重新尝试");
            }
        }




    }
}
