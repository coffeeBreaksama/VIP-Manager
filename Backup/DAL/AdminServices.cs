using System;
using System.Collections.Generic;
using System.Text;
using SysCard.Models;
using System.Data;
using System.Data.OleDb;

namespace SysCard.DAL
{
    public class AdminServices
    {
        /// <summary>
        /// 管理员登记
        /// </summary>
        /// <param name="admin">管理员信息</param>
        /// <returns>操作</returns>
        public static int AddAdmin(AdminInfo admin)
        {
            string sql = string.Format("insert into admin_info (admin_name,admin_user,admin_pwd) values('{0}','{1}','{2}')",admin.Adminname,admin.Username,admin.Userpwd);
            return Dbhelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="admin">管理员信息</param>
        /// <returns></returns>
        public static int UpdataAdmin(AdminInfo admin)
        {
            string sql = string.Format("update admin_info set admin_pwd='{0}' where admin_id={1}",admin.Userpwd,admin.AdminId);
            return Dbhelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 管理员登陆
        /// </summary>
        /// <param name="username">管理员用户名</param>
        /// <param name="userpwd">管理员密码</param>
        /// <returns>登陆管理员用户信</returns>
        public static AdminInfo LoginAdmin(string username,string userpwd)
        {
            string sql = string.Format("select * from admin_info where admin_user='{0}' and admin_pwd='{1}'",username,userpwd);
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            AdminInfo admin = new AdminInfo();
            if (dr.Read())
            {
                admin.AdminId = int.Parse(dr[0].ToString());
                admin.Adminname = dr[1].ToString();
                admin.Username = username;
                admin.Userpwd = userpwd;
            }
            return admin;
                
        }
        public static List<AdminInfo> GetALLAdmin()
        {
            string sql = "select * from admin_info";
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            List<AdminInfo> list = new List<AdminInfo>();
            while (dr.Read())
            {
                AdminInfo admin = new AdminInfo();
                admin.AdminId = int.Parse(dr[0].ToString());
                admin.Adminname = dr[1].ToString();
                admin.Username = dr[2].ToString();
                admin.Userpwd = dr[3].ToString();
                list.Add(admin);               
            }
            dr.Close();

            return list;
        }
        public static int DelAdmin(AdminInfo admin)
        {
            string sql = string.Format("delete from admin_info where admin_id = {0}",admin.AdminId);
            return Dbhelper.ExecuteNonQuery(sql);
        }
        public static void test()
        {
            string sql = string.Format("select * from admin_info");
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            while(dr.Read())
            {
            }
        }


    }
}
