using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace SysCard
{
    public partial class Form_TestForm : Form
    {
        public Form_TestForm()
        {
            InitializeComponent();


         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "aaaaaaaaaa";
            string s1 = "我我我我我我我我我我";
            MessageBox.Show(s+"\n"+s1);
            
         
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
         //   this.printDocument1.PrintPage += new ProgressChangedEventHandler(printDocument1_PrintPage_1);
        //    this.printPreviewDialog1.Document = printDocument1;
            this.printDocument1.Print();
          
        
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            
           
        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
          Graphics cp = e.Graphics;
          Font f = this.richTextBox1.Font;
            SolidBrush br = new SolidBrush(Color.Black);
            cp.DrawString("产品名    单价   件数",f, br,new PointF());//5*1*a*s*p*x
            cp.DrawString("电视机    1000   2", f, br,0.0f,15,new StringFormat());
           cp.DrawString("总价￥2000", f, br,0.0f,30,new StringFormat());
        //  cp.DrawString("测试成功...", , null, PointF);
          
            
            
        }
    }
}