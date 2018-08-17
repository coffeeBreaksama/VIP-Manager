using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using SysCard.Models;
using SysCard.DAL.Data;
namespace SysCard.DAL
{
    public class PdServices
    {

        public static List<employeeInfo> getallpd()
        {
            string sql = "select * from EmployeeInfo";
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            List<employeeInfo> list = new List<employeeInfo>();
            if (dr != null)
            {
                while (dr.Read())
                {
                    employeeInfo pd = new employeeInfo();
                    pd.Name = dr[1].ToString();
                    pd.Id = uint.Parse(dr[0].ToString());
                    pd.CreateTime = DateTime.Parse(dr[3].ToString());
                    pd.Type = dr[4].ToString();

                    if(pd.Id > 9)
                        list.Add(pd);
                }
                dr.Close();
            }
            
            return list;
        }
        public static int UpdatePd(employeeInfo pd)
        {
            string sql = string.Format("update EmployeeInfo set EmployeeName='{0}' where Id={1}", pd.Name, pd.Id);
            return Dbhelper.ExecuteNonQuery(sql); 
        }
        public static int DlePd(employeeInfo pd)
        {
            string sql = string.Format("delete * from EmployeeInfo where Id={0}", pd.Id);
            return Dbhelper.ExecuteNonQuery(sql);            
        }
    }
}
