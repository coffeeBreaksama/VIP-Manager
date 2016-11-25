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
    public partial class Form_Sco : Form
    {
        public Form_Sco()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
             
                 ScoInfo1 sco = ScoServices.GetScorByUser(this.tex_Card.Text);
                
                 float f = BuyBkServices.GetAllBuyBkByUser(this.tex_Card.Text);
                 if (f <= 0)
                 {
                     MessageBox.Show("此会员没有消费过！！");
                 }
                 else
                 {
                     this.tex_His.Text = sco.ScoHis;
                     this.tex_Sco.Text = sco.Sco;
                     f = f / 100 * 3;
                     f = f - float.Parse(this.tex_His.Text);
                     this.tex_scort.Text = f.ToString();
                 }
            
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScoInfo1 sco = new ScoInfo1();
            sco.User = this.tex_Card.Text;
            sco.ScoHis =int.Parse(this.tex_His.Text.ToString())+int.Parse(this.tex_input.Text)+"";
            sco.Sco =int.Parse(this.tex_input.Text)+int.Parse(this.tex_Sco.Text)+"";

            if (float.Parse(this.tex_input.Text) > float.Parse(this.tex_scort.Text))
                MessageBox.Show("没有积分可以兑换！！");
            else
            { ScoServices.UpdataSco(sco); MessageBox.Show("积分转换成功！！！"); }

            
        }
    }
}