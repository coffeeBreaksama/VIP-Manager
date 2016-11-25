using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using SysCard.Models;
namespace SysCard.DAL
{
    public class PdServices
    {
        public static int AddPd(Pd_info pd)
        {
            string sql = string.Format("insert into pd_info (pd_name) values('{0}')",pd.Pdname);
            int ret = Dbhelper.ExecuteNonQuery(sql);
            return ret;
        }
        public static List<Pd_info> getallpd()
        {
            string sql = "select * from pd_info";
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            List<Pd_info> list = new List<Pd_info>();
            if (dr != null)
            {
                while (dr.Read())
                {
                    Pd_info pd = new Pd_info();
                    pd.Pdname = dr[1].ToString();
                    pd.Pdid = int.Parse(dr[0].ToString());
                    list.Add(pd);
                }
                dr.Close();
            }
            
            return list;
        }
        public static int UpdatePd(Pd_info pd)
        {
            string sql = string.Format("update pd_info set pd_name='{0}' where pd_id={1}",pd.Pdname,pd.Pdid);
            return Dbhelper.ExecuteNonQuery(sql); 
        }
        public static int DlePd(Pd_info pd)
        {
            string sql = string.Format("delete from pd_info where pd_id={0}",pd.Pdid);
            return Dbhelper.ExecuteNonQuery(sql);            
        }
    }
}
