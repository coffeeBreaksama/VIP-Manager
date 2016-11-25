using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysCard.Models;
using SysCard.DAL;
using System.IO;

namespace SysCard
{
    public partial class Form_payFor : Form
    {
        private float price;
        private Form_BuyBK fd;
        private List<BuyBk> blist=new List<BuyBk>();
        public Form_payFor()
        {
            InitializeComponent();
        }
        public Form_payFor(float p,Form_BuyBK f)
        {
            InitializeComponent();
            price = p;
            this.tex_int.Text = price.ToString("0.00");
            this.tex_in.Select();
            this.CenterToParent();
            fd = f;
        
        }

        /*    buypro.BuyTime = DateTime.Now.ToString();
                buypro.Productaddr = product.Productaddr;
                buypro.Productdru = product.Productdru;
                buypro.Productid = product.Productid;
                buypro.Productname = product.Productname;
                buypro.Productnum = product.Productnum;
                buypro.Productpd = product.Productpd;
                buypro.Productpprice = product.Productpprice;
                buypro.Productprice = product.Productprice;
                buypro.Productpristata = product.Productstata;
                buypro.Producttype = product.Producttype;
                buyList.Add(buypro);*/

        public Form_payFor(float p, Form_BuyBK f, List<BuyFz> tlist)
        {
            InitializeComponent();
            price = p;
            this.tex_int.Text = price.ToString("0.00");
            this.tex_in.Select();
            this.CenterToParent();
            fd = f;
            for (int i = 0; i < tlist.Count; i++)
            {
                BuyBk bb = new BuyBk();
                bb.BuyFrom = "system";
                bb.Buyprice = tlist[i].Price.ToString();
                bb.Buyproduct = tlist[i].Pname;
                bb.Buytime = DateTime.Now.ToString();
                bb.Count = tlist[i].Count;
                blist.Add(bb);
            }

        }

        private void tex_in_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                float pric = float.Parse(this.tex_in.Text)-float.Parse(this.tex_int.Text);

                this.tex_out.Text = pric.ToString("0.00");
                this.button1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (float.Parse(this.tex_out.Text) >= 0)
            {
                for (int i = 0; i < blist.Count; i++)
                {
                    BuyBkServices.AddByBk(blist[i]);
                }
                    MessageBox.Show("支付成功！");
                    try {
                        if(this.checkBox1.Checked)
                        this.printDocument1.Print();
                    }
                    catch
                    {
                        MessageBox.Show("打印机出现异常！！");
                    }
                    
                
                this.Close();

                fd.formclea();
            }
            else
            {
                MessageBox.Show("金额不足！");
                this.tex_out.Text = "";
                this.tex_in.Text = "";
                this.tex_in.Select();
            }

            try {
               
                //this.printDocument1.document
              //  printDocument1.Print();
                
            
            }
            catch { 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
    
          
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics cp = e.Graphics;
            Font f = fontDialog1.Font;
            SolidBrush br = new SolidBrush(Color.Black);
            int height = 15;
            cp.DrawString("商品名    单价  数量",f, br,new PointF());
            for (int i = 0; i < blist.Count; i++)
            {
                string str = getstr(7, blist[i].Buyproduct) + getstr(6, blist[i].Buyprice) + getstr(4,blist[i].Count.ToString());
                cp.DrawString(str, f, br, 0.0f, height, new StringFormat());
                height += 15;
            }
            cp.DrawString("--------------------", f, br, 0.0f, height, new StringFormat());
            height += 15;
        //    string str = getstr(10, blist[i].Buyproduct) + getstr(5, blist[i].Buyprice) + getstr(4, blist[i].Count.ToString());
            
            float sun = 0.00f;
            for (int i = 0; i < blist.Count; i++)
            {
                sun += float.Parse(blist[i].Buyprice);
            }

                cp.DrawString("总价：￥"+sun.ToString("0.00"), f, br, 0.0f, height, new StringFormat());
        }
        public string getstr(int cc, string str)
        {
            if (str.Length >= cc)
            {
                //str.Substring
                str = str.Substring(0, cc);

            }
            else
            {
                int temp = 0;
                temp = cc - str.Length;
                for (int i = 0; i < temp; i++)
                {
                    str += " ";
                }
            }
           return str;
        }
    }
}