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

       

        private void button6_Click(object sender, EventArgs e)
        {
            employeeInfo newEmp = new employeeInfo();
            newEmp.Name = this.tex_user.Text;
            newEmp.Password = this.tex_pwd.Text;
            if (this.checkBox1.Checked == true)
            {
                newEmp.Type = "管理员";
            }
            else
            {
                newEmp.Type = "员工";
            }
            int ret = DataService.AddEmployee(newEmp);
            if (ret > 0)
            {
                MessageBox.Show("操作成功！");
            }
            else
            {
                MessageBox.Show("操作失败！");
            }
            this.dataGridView2.DataSource = PdServices.getallpd();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.dataGridView2.DataSource = PdServices.getallpd();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string str = MessageBox.Show("你确定要删除选中项目吗？", "警告", MessageBoxButtons.YesNo).ToString();
            if (str == "Yes")
            {


                employeeInfo admin = new employeeInfo();



                if (this.dataGridView2.SelectedRows.Count > 0)
                {

                    for (int i = 0; i < dataGridView2.SelectedRows.Count; i++)
                    {
                        DataGridViewRow dr = dataGridView2.SelectedRows[i];

                        admin.Id = uint.Parse(dr.Cells[0].Value.ToString());
                        int ret = PdServices.DlePd(admin);
                        if (ret > 0)
                        {

                        }
                        else
                        {
                            //MessageBox.Show(string.Format("第{0}条删除失败！", i + 1));
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

                 admin.Id = uint.Parse(dr.Cells[0].Value.ToString());
                    // MessageBox.Show(pd.Pdid.ToString());
                    int ret = PdServices.DlePd(admin);
                    if (ret > 0)
                    {
                        MessageBox.Show("操作成功！");
                    }
                    else
                    {
                        MessageBox.Show("操作失败！");
                    }
               
                }


                
                this.dataGridView2.DataSource = PdServices.getallpd();


            }
        }
    }
}