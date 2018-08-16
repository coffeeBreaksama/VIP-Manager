using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysCard.DAL.Waiter;
using SysCard.DAL.Manager;
using SysCard.DAL.Data;
using Microsoft.Win32;

namespace SysCard
{
    public partial class Form_SearchVip : Form
    {

        static List<VipInfo> vip;
        string path;
        static List<ObjInfo> data;
        
        public Form_SearchVip()
        {
            InitializeComponent();
            data=DataService.GetALLObjInfo();
            dataGridView1.DataSource = data;
            this.Show();
            
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
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            int id;
            if(tex_id.Text == "")
            {
                id = -1;
            }else
                id = int.Parse(tex_id.Text);
            SearchData(tex_name.Text,id,textpara1.Text,textpara2.Text,textpara3.Text);
        }


      
    }
}
