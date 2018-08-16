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
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.TCardNum.Text = waiter.GetPortCardNum();
        }

        private void BtnNewCard_Click(object sender, EventArgs e)
        {
            path = ControCenter.SelectPath();
            ControCenter.GetDataOfExcel(path);
            DataService.FillPriceOfDs();
        }
    }
}
