using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysCard.DAL;
using System.Data.OleDb;
namespace SysCard
{
    public partial class Form_loading : Form
    {
        public Form_loading()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.labload.Width = 0;
            CenterToScreen();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labload.Width += 3;
            if (labload.Width >= label1.Width)
            {
                this.timer1.Enabled = false;
                Form_log f = new Form_log(this);
                f.ShowInTaskbar = false;
                f.Show();
                this.Visible = false;
               

            }
            if (labload.Width > label1.Width/ 2&&labload.Width<label1.Width/3*2)
            {
                OleDbConnection conn = null;
                try
                {
                    conn = Dbhelper.GetOleDbConnection();
                    conn.Open();
                }
                catch
                {
                    this.timer1.Enabled = false;
                    MessageBox.Show("数据加载失败....");
                    this.Close();
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}