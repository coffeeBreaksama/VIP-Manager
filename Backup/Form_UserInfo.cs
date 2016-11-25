using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysCard.Models;
using SysCard.DAL;

namespace SysCard
{
    public partial class Form_UserInfo : Form
    {
        public Form_UserInfo()
        {
            InitializeComponent();
            CenterToParent();
            this.textBox1.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = UserServices.GetAllInfo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = UserServices.GetUserInfoBy(this.textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = MessageBox.Show("你确定要删除选中项目吗？", "警告", MessageBoxButtons.YesNo).ToString();
            if (str == "Yes")
            {






                if (this.dataGridView1.SelectedRows.Count > 0)
                {

                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        DataGridViewRow dr = dataGridView1.SelectedRows[i];


                     int ret =UserServices.DelUser(int.Parse(dr.Cells[10].Value.ToString()));

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
                    int ret =UserServices.DelUser(int.Parse(dr.Cells[10].Value.ToString()));
                    if (ret > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("操作失败！");
                    }


                }



                this.dataGridView1.DataSource = UserServices.GetAllInfo();
            }
        }
    }
}