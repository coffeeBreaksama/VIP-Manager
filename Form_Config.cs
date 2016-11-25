using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysCard.DAL;
using SysCard.DAL.Data;
using SysCard.Models;

namespace SysCard
{
    public partial class Form_Config : Form
    {
        public Form_Config()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Pd_info pd = new Pd_info();
            pd.Pdname = this.tex_pd.Text;
            int ret = PdServices.AddPd(pd);
            if (ret > 0)
            {
                MessageBox.Show("添加成功!");
                this.dataGridView1.DataSource = PdServices.getallpd();
            }



        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = PdServices.getallpd();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            string str = MessageBox.Show("你确定要删除选中项目吗？", "警告", MessageBoxButtons.YesNo).ToString();
            if (str == "Yes")
            {


                Pd_info pd = new Pd_info();



                if (this.dataGridView1.SelectedRows.Count > 0)
                {

                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        DataGridViewRow dr = dataGridView1.SelectedRows[i];

                        pd.Pdid = int.Parse(dr.Cells[1].Value.ToString());
                        int ret = PdServices.DlePd(pd);
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

                    pd.Pdid = int.Parse(dr.Cells[1].Value.ToString());
                   // MessageBox.Show(pd.Pdid.ToString());
                    int ret = PdServices.DlePd(pd);
                    if (ret > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("操作失败！");
                    }
                }


                MessageBox.Show("操作成功！");
                this.dataGridView1.DataSource = PdServices.getallpd();


            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            employeeInfo newEmp = new employeeInfo();
            newEmp.Name = this.tex_user.Text;
            newEmp.Password = this.tex_username.Text;
            int ret = DataService.AddEmployee(newEmp);
            if (ret > 0)
            {
                MessageBox.Show("操作成功！");
            }
            else
            {
                MessageBox.Show("操作失败！");
            }
            this.dataGridView2.DataSource = AdminServices.GetALLAdmin();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.dataGridView2.DataSource = AdminServices.GetALLAdmin();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string str = MessageBox.Show("你确定要删除选中项目吗？", "警告", MessageBoxButtons.YesNo).ToString();
            if (str == "Yes")
            {


                AdminInfo admin = new AdminInfo();



                if (this.dataGridView2.SelectedRows.Count > 0)
                {

                    for (int i = 0; i < dataGridView2.SelectedRows.Count; i++)
                    {
                        DataGridViewRow dr = dataGridView2.SelectedRows[i];

                        admin.AdminId = int.Parse(dr.Cells[0].Value.ToString());
                        int ret = AdminServices.DelAdmin(admin);
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

                    DataGridViewCell dc = this.dataGridView2.SelectedCells[0];
                    // DataGridViewRow dr = dc.RowNumber;
                    // dc = dr.Cells[0];
                    DataGridViewRow dr = dc.OwningRow;
                  //  MessageBox.Show(dr.Cells[0].Value.ToString());

                 admin.AdminId = int.Parse(dr.Cells[0].Value.ToString());
                    // MessageBox.Show(pd.Pdid.ToString());
                    int ret = AdminServices.DelAdmin(admin);
                    if (ret > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("操作失败！");
                    }
               
                }


                MessageBox.Show("操作成功！");
                this.dataGridView2.DataSource = AdminServices.GetALLAdmin();


            }
        }
    }
}