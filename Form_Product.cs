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
    public partial class Form_Product : Form
    {
        public Form_Product()
        {
            InitializeComponent();
            List<employeeInfo> list = PdServices.getallpd();
            cmb_pd.DataSource = list;
            cmb_pd.DisplayMember = "pdname";
            cmb_pd.ValueMember = "pdid";
            this.dataGridView1.DataSource = ProductServices.GetAllProduct();
            this.CenterToParent();
            this.tex_pronum.Select();
            

        }

        private void cmb_pd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = this.cmb_pd.SelectedValue.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductInfo product = new ProductInfo();
            product.Productaddr = this.tex_productaddr.Text;
            product.Productdru = this.tex_productdru.Text;
            product.Productname = this.text_productname.Text;
            product.Productnum = this.tex_productnum.Text;
            product.Productpd = this.cmb_pd.SelectedText;
            product.Productpprice = float.Parse( this.tex_productpprice.Text);
            product.Productprice =float.Parse( this.tex_productprice.Text);
            if (this.chk_prista.Checked)
            {
                product.Productpristata = "是";
            }
            else
            {
                product.Productpristata = "否";
            }
            if (this.chk_psta.Checked)
            {
                product.Productstata = "是";
            }
            else
            {
                product.Productstata = "否";
            }
            product.Producttype = "无类型";

            //*做提交操作，*/

            int ret = ProductServices.AddProduct(product);
            if (ret > 0)
            {
                MessageBox.Show("添加成功！");
                this.dataGridView1.DataSource = ProductServices.GetAllProduct();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tex_productaddr.Text = "";
            this.tex_productdru.Text = "";
            this.tex_productnum.Text = "";
            this.tex_productpprice.Text = 0+"";
            this.tex_productprice.Text = 0+"";
            this.text_productname.Text = "";
            this.textBox2.Text = "d";
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = ProductServices.GetProductBy(this.textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
             string str = MessageBox.Show("你确定要删除选中项目吗？", "警告", MessageBoxButtons.YesNo).ToString();
            if (str == "Yes")
            {


               



                if (this.dataGridView1.SelectedRows.Count > 0)
                {

                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        DataGridViewRow dr = dataGridView1.SelectedRows[i];

                        
                       int ret =  ProductServices.DelProduct(int.Parse(dr.Cells[6].Value.ToString()));
                        
                        if (ret > 0)
                        {

                        }
                        else
                        {
                            MessageBox.Show(string.Format("第{0}条删除失败！", i + 1));
                        }
                      

                    }
                }
                else
                {

                    DataGridViewCell dc = this.dataGridView1.SelectedCells[0];
                    // DataGridViewRow dr = dc.RowNumber;
                    // dc = dr.Cells[0];
                    DataGridViewRow dr = dc.OwningRow;
                  //  MessageBox.Show(dr.Cells[0].Value.ToString());
                  //  MessageBox.Show(dr.Cells[6].Value.ToString());

                

                    // MessageBox.Show(pd.Pdid.ToString());
                    int ret = ProductServices.DelProduct(int.Parse(dr.Cells[6].Value.ToString()));
                    if (ret > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("操作失败！");
                    }
               
               
                }


                MessageBox.Show("操作成功！");
                this.dataGridView1.DataSource = ProductServices.GetAllProduct();


            }
        
        }

        private void tex_pronum_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = ProductServices.GetProductByNum(this.tex_pronum.Text);
        }

        private void tex_pronum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.tex_pronum.SelectAll();
            }
        }
    }
}