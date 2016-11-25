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
namespace SysCard
{
    public partial class Form_main : Form
    {
        public static AdminInfo admin;
        public Form form;
        public Form_main()
        {
            InitializeComponent();
            this.CenterToParent();
            
        }
        public Form_main(AdminInfo adminfor,Form f)
        {
            InitializeComponent();
            this.CenterToParent();
            admin = adminfor;
            form = f;

            this.FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            //自做控件
            Bout b = new Bout();
         
            Bitmap bt = new Bitmap(this.Width,this.Height);
            Graphics grp = Graphics.FromImage(bt);
        //    _Graphcis.DrawImage(Image.FromStream(new MemoryStream(_ImageByte)), 0, 0, p_Width, p_Height);
          //  _Graphcis.Dispose();
           // return _Bitmap; 
            Image img = this.BackgroundImage;
            grp.DrawImage(img,0,0,this.Width,this.Height);
            this.BackgroundImage = img;


            Update();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_adduser f = new Form_adduser();//5~1~a~s~p~x
            f.ShowInTaskbar = false;
            f.ShowDialog();
          //  f.ShowDialog();
        }

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormUpdate f = new FormUpdate(admin);
            f.ShowInTaskbar = false;
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Config f = new Form_Config();
            f.ShowInTaskbar = false;
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Product f = new Form_Product();
            f.ShowInTaskbar = false;
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form_UserInfo f = new Form_UserInfo();
            f.ShowInTaskbar = false;
            f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            Form_BuyBK f = new Form_BuyBK();
        //    f.textBox1.Text = "test ok!!";
            f.textBox1.Select();
            f.textBox1.Focus();
            f.ShowInTaskbar = false;
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("设备错误,请重新插入!!");
          //  MessageBox.Show("设备错误,请重新连接设备!!");
            //For_AddPrice f = new For_AddPrice();
            //f.ShowInTaskbar = false;
            //f.ShowDialog();
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
            /*Form_Sco f = new Form_Sco();
            f.ShowInTaskbar = false;
            f.ShowDialog();*/
            MessageBox.Show("设备错误,请重新插入!!");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form_dispbk f = new Form_dispbk();
            f.ShowInTaskbar = false;
            f.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form_aboat f = new Form_aboat();
            f.ShowInTaskbar = false;
            f.ShowDialog();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Form_dispPk f = new Form_dispPk();
            f.ShowInTaskbar = false;
            f.ShowDialog();
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
    }
}