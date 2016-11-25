using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysCard.DAL;
using SysCard.Models;

namespace SysCard
{
    public partial class Form_BuyBK : Form
    {
        public List<BuyFz> list = new List<BuyFz>();
        public List<string> list1 = new List<string>();
        public List<ProductInfo> plist;
        public List<BuyProduct> buyList;
        public int num;
        public float price;
        public Form_BuyBK()
        {
            InitializeComponent();
            CenterToParent();
            this.labtt.Text = "";
            this.textBox1.Focus();
            list1.Add("asdf");
            list1.Add("asdf");
            list1.Add("asdf");
            list1.Add("asdf");
            list1.Add("asdf");
            

        

        }

        private void Form_BuyBK_Load(object sender, EventArgs e)
        {
           
          
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
          //  MessageBox.Show(e.KeyValue.ToString());
            if (e.KeyValue == 13)
            {
                
              //  list1.Add(this.textBox1.Text);
             //   this.dataGridView1.DataSource = list1;
                /*
                this.labtt.Text = this.textBox1.Text;
                this.textBox1.Text = "";

*/          
            //    databind();
               

             
              //  MessageBox.Show(this.textBox1.Text);
                databind(this.textBox1.Text);
            }
            if(e.KeyValue == 113)
            {

                Form_Pay f = new Form_Pay(float.Parse(this.jine.Text), this,list);
                f.ShowInTaskbar = false;
                f.Show();
                
            }
            if (e.KeyValue == 112)
            {
                Form_payFor f = new Form_payFor(float.Parse(this.jine.Text), this,list);
                f.ShowInTaskbar = false;
                f.Show();
            }
        }
        public void databind(string text)
        {
            try
            {
                ProductInfo product = ProductServices.GetProductByNum(text)[0];
                if (product.Productnum != null)
                {
                   
                    BuyFz bk = new BuyFz();
                    bk.Pid = product.Productnum;
                    bk.Pname = product.Productname;
                    bk.Price = product.Productprice;
                    bk.Count = int.Parse(this.textBox2.Text);
                    bk.Num = num;
                    bk.Cardnum = product.Productnum;
                    num++;
                    list.Add(bk);
                  //  plist.Add(product);
                    BuyProduct buypro = new BuyProduct();
                   // buypro.BuyForm = text;
            
                    this.labtt.Text = "";
                    this.jine.Text = float.Parse(this.jine.Text) + bk.Price * float.Parse(textBox2.Text)+"";

                    


                    this.dataGridView1.DataSource = list1;
                    this.dataGridView1.DataSource = list;

                    //this.dataGridView1.Update();
                    // this.dataGridView1.databin;

                    this.textBox1.Text = "";
                    this.textBox1.Focus();
                }
                else
                {
                    this.labtt.Text = "此商品不存在！！";
                    this.textBox1.Focus();
                }
            }
            catch
            {
                this.labtt.Text = "此商品不存在！！";
                
                this.textBox1.Focus();
                this.textBox1.Text = "";
            }
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = list;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
           // DataGridViewRow dr = new DataGridViewRow();
          //  DataGridViewCell dc = new DataGridViewCell();
          //  dr.Cells.Add(dc);
        
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //formclea();
            Form_payFor f = new Form_payFor( float.Parse( this.jine.Text),this,list);
            f.ShowInTaskbar = false;
            f.Show();

        }

        public void formclea()
        {
            price = 0;
            list.Clear();
            this.dataGridView1.DataSource = list1;
            this.dataGridView1.DataSource = list;
            this.jine.Text = "0";
            this.textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Pay f = new Form_Pay(float.Parse(this.jine.Text),this,list);
            f.ShowInTaskbar = false;
            f.Show();
            
        }

        private void Form_BuyBK_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

         //   List<DataGridViewRow> dr = this.dataGridView1.SelectedRows;
            List<BuyFz> dk = new List<BuyFz>();
            if (dataGridView1.SelectedRows.Count > 0)
            {                
                for(int i=0;i<dataGridView1.SelectedRows.Count;i++)
                {
                    string str = this.dataGridView1.SelectedRows[i].Cells[1].Value.ToString();
                    for (int j = 0; j < list.Count; j++)
                    {
                        BuyFz d = list[j];
                        if (d.Num == int.Parse(str))
                        {
                            float temp = float.Parse(this.jine.Text) - list[j].Price;
                            dk.Add(list[j]);
                            this.jine.Text = temp.ToString("0.00");
                          
                            break;
                        }
                    }

                  
                }
                for (int j = 0; j < dk.Count; j++)
                {
                    list.Remove(dk[j]);
                }

                this.dataGridView1.DataSource = list1;
                this.dataGridView1.DataSource = list;

            }
            this.textBox1.Select();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.textBox1.Select();
            }
        }

      
    }
}