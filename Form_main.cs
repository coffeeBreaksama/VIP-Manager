using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysCard.Models;
using SysCard.DAL;
using SysCard.Contor;
using System.IO;
using SysCard.DAL.Data;
using SysCard.DAL.Waiter;
using SysCard.DAL.Manager;

namespace SysCard
{
    public partial class Form_main : Form
    {

        public Form_main()
        {
            InitializeComponent();
            this.CenterToParent();


            //this.FormBorderStyle = FormBorderStyle.None;
            this.NowLogName.Text = NowLogName.Text + ControCenter.NowLogType + ControCenter.NowLogName;
            WindowState = FormWindowState.Maximized;
            //自做控件
            Bout b = new Bout();
         
            Bitmap bt = new Bitmap(this.Width,this.Height);
            Graphics grp = Graphics.FromImage(bt);
            //  _Graphcis.DrawImage(Image.FromStream(new MemoryStream(_ImageByte)), 0, 0, p_Width, p_Height);
            //  _Graphcis.Dispose();
            // return _Bitmap; 
            Image img = this.BackgroundImage;
            grp.DrawImage(img,0,0,this.Width,this.Height);
            this.BackgroundImage = img;


            this.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ControCenter.NowLogType == "员工")
            {
                MessageBox.Show("权限不足，请联系管理员");
            }
            else
            {
                Form_EditPrice f = new Form_EditPrice();
                f.ShowInTaskbar = false;
                f.ShowDialog();
            }
        }

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            waiter.EndProgram();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormUpdate f = new FormUpdate();
            f.ShowInTaskbar = false;
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ControCenter.NowLogType == "员工")
            {
                MessageBox.Show("权限不足，请联系管理员");
            }
            else
            {
                Form_Config f = new Form_Config();
                f.ShowInTaskbar = false;
                f.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_SearchVip searchVip = new Form_SearchVip();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form_NewCard newCard = new Form_NewCard();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            float a = 6.45455f;
           float b = float.Parse( a.ToString("0.00"));
           MessageBox.Show(b.ToString());
        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            waiter.EndProgram();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form_aboat f = new Form_aboat();
            f.ShowInTaskbar = false;
            f.ShowDialog();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
             /*Dim key As RegistryKey = Registry.LocalMachine
             Dim subKey = key.OpenSubKey("HARDWARE\DEVICEMAP\Scsi\Scsi Port 0\Scsi Bus 0\Target Id 0\Logical Unit Id 0")
             Dim bbb = subKey.GetValue("Identifier")*/
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string str = string.Format("今天是：{0}年{1}月{2}日  {3}:{4}:{5}",date.Year,date.Month,date.Day,date.Hour,date.Minute,date.Second);
            this.tool_lab.Text = str;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form_TestForm f = new Form_TestForm();
            f.Show();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {

        }

        private void Form_main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 9)
            {
                List<PictureBox> piclist= new List<PictureBox>();
                piclist.Add(this.pictureBox1);
                piclist.Add(this.pictureBox3);
                piclist.Add(this.pictureBox4);
                piclist.Add(this.pictureBox5);
                piclist.Add(this.pictureBox6);
                piclist.Add(this.pictureBox2);
                
            }
        }

        private void Form_main_Load(object sender, EventArgs e)
        {

        }


    }
}