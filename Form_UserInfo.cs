using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysCard.Models;
using SysCard.DAL;
using SysCard.DAL.Waiter;
using SysCard.DAL.Manager;
using SysCard.DAL.Data;

namespace SysCard
{
    public partial class Form_EditPrice : Form
    {
        static List<ObjInfo> data;
        static ObjInfo obj;

        public Form_EditPrice()
        {
            obj = new ObjInfo();
            InitializeComponent();
            CenterToParent();
            data = DataService.GetALLObjInfo();
            dataGridView1.DataSource = data;
            this.Show();
        }


        private void Form_Updata()
        {
 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            if (tex_id.Text == "")
            {
                id = -1;
            }
            else
                id = int.Parse(tex_id.Text);
            SearchData(tex_name.Text, id, textpara1.Text, textpara2.Text, textpara3.Text);
        }
        
        private void SearchData(string name, int id, string para1, string para2, string para3)
        {
            int a = ControCenter.ObjInfoData.Count;
            this.dataGridView1.DataSource = null;
            data.Clear();
            for (int i = 0; i < a; i++)
            {
                if ((name == "" || name == ControCenter.ObjInfoData[i].Name)
                    && (id < 0 || id == ControCenter.ObjInfoData[i].Index)
                    && (para1 == "" || para1 == ControCenter.ObjInfoData[i].Parameter1)
                    && (para1 == "" || para2 == ControCenter.ObjInfoData[i].Parameter2)
                    && (para1 == "" || para3 == ControCenter.ObjInfoData[i].Parameter3)
                    )
                {
                    data.Add(ControCenter.ObjInfoData[i]);
                }
            }
            this.dataGridView1.DataSource = data;


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

                        obj.Index = int.Parse(dr.Cells[1].Value.ToString());
                        int ret = DataService.EditObj("DEL", obj);

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
                    obj.Index = int.Parse(dr.Cells[1].Value.ToString());
                    int ret = DataService.EditObj("DEL", obj);
                    if (ret > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("操作失败！");
                    }


                }

                data.Clear();
                data = DataService.GetALLObjInfo();//刷新
                this.dataGridView1.DataSource = data;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("商品序号为自动分配，无法指定。若有编号需求请填写在参数框里。");
           // obj.Index = int.Parse(this.tex_id.Text);
            obj.Name = this.tex_name.Text;
            obj.Parameter1 = this.textpara1.Text;
            obj.Parameter2 = this.textpara2.Text;
            obj.Parameter3 = this.textpara3.Text;
            obj.BasePrice1 = this.textBox1.Text;
            obj.BasePrice2 = this.textBox2.Text;
            obj.BasePrice3 = this.textBox3.Text;
            DataService.EditObj("ADD",obj);
            data.Clear();
            data = DataService.GetALLObjInfo();//刷新
            this.dataGridView1.DataSource = data;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1:请按格式修改好表格再尝试导入。 /n2.当软件价格与此时导入的表冲突时，以导入的表格为准 /n3.当软件库中存在多个相同参数相同物品时，仅修改序号大的物品价格");
            try
            {
                string path = ControCenter.SelectPath();
                DataService.ImportExcelToAcess(path);
            }
            catch 
            {

                MessageBox.Show("导入失败，检查文件。");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = MessageBox.Show("你确定要修改选中项目吗？", "警告", MessageBoxButtons.YesNo).ToString();
            if (str == "Yes")
            {






                if (this.dataGridView1.SelectedRows.Count > 0)
                {

                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        DataGridViewRow dr = dataGridView1.SelectedRows[i];

                        obj.Index = int.Parse(dr.Cells[1].Value.ToString());
                        //MessageBox.Show("商品序号为自动分配，无法指定。若有编号需求请填写在参数框里。");
                       // obj.Index = int.Parse(this.tex_id.Text);
                        obj.Name = this.tex_name.Text;
                        obj.Parameter1 = this.textpara1.Text;
                        obj.Parameter2 = this.textpara2.Text;
                        obj.Parameter3 = this.textpara3.Text;
                        obj.BasePrice1 = this.textBox1.Text;
                        obj.BasePrice2 = this.textBox2.Text;
                        obj.BasePrice3 = this.textBox3.Text;


                        int ret = DataService.EditObj("CHANGE", obj);

                        if (ret > 0)
                        {

                        }
                        else
                        {
                            MessageBox.Show(string.Format("第{0}条修改失败！", i + 1));
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
                    obj.Index = int.Parse(dr.Cells[1].Value.ToString());
                     //MessageBox.Show("商品序号为自动分配，无法指定。若有编号需求请填写在参数框里。");
                     // obj.Index = int.Parse(this.tex_id.Text);
                     obj.Name = this.tex_name.Text;
                     obj.Parameter1 = this.textpara1.Text;
                     obj.Parameter2 = this.textpara2.Text;
                     obj.Parameter3 = this.textpara3.Text;
                     obj.BasePrice1 = this.textBox1.Text;
                     obj.BasePrice2 = this.textBox2.Text;
                     obj.BasePrice3 = this.textBox3.Text;
                    int ret = DataService.EditObj("CHANGE", obj);
                    if (ret > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("操作失败！");
                    }


                }



                data.Clear();
                data = DataService.GetALLObjInfo();//刷新
                this.dataGridView1.DataSource = data;
            }
        }
        
    }
}