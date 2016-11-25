using System;
using System.Collections.Generic;
using System.Text;
using SysCard.Models;
using System.Data;
using System.Data.OleDb;
namespace SysCard.DAL
{
   public class UserServices
    {
       public static int AddUser(UserInfo user)
       {     

           string sql = string.Format("insert into card_user (Card_User,Card_Pwd,User_Name,User_Job,User_Tel,User_Addr,User_Love,User_Phone,User_Sex,User_birth,Card_time,Card_bak,Card_Stata) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')",user.Carduser,user.Cardpwd,user.Username,user.Userjob,user.Usertel,user.Useraddr,user.Userlove,user.Userphone,user.Usersex,user.Userbirth,user.Cardtime,user.Cardbak,user.Cardstata);

           return Dbhelper.ExecuteNonQuery(sql);

       }
       public static List<UserInfo> GetAllInfo()
       {
           string sql = string.Format("select * from Card_User");
           OleDbDataReader dr = Dbhelper.ExecuteReader(sql);

           List<UserInfo> list = new List<UserInfo>();
           while(dr.Read())
           {
               UserInfo user = new UserInfo();
               user.Cardid = int.Parse(dr[0].ToString());
               user.Carduser = dr[1].ToString();
               user.Cardpwd = dr[2].ToString();
               user.Username = dr[3].ToString();
               user.Userjob = dr[4].ToString();
               user.Usertel = dr[5].ToString();
               user.Useraddr = dr[6].ToString();
               user.Userlove = dr[7].ToString();
               user.Userphone = dr[8].ToString();
               user.Usersex = dr[9].ToString();
               user.Userbirth = dr[10].ToString();
               user.Cardtime = dr[11].ToString();
               user.Cardbak = dr[12].ToString();
               user.Cardstata = dr[13].ToString();
               user.Price = float.Parse(dr[14].ToString());
               list.Add(user);
           }
           return list;
       }
       public static List<UserInfo> GetUserInfoBy(string card)
       {
           string sql = string.Format("select * from Card_User where Card_User like ('%{0}%')",card);
           OleDbDataReader dr = Dbhelper.ExecuteReader(sql);

           List<UserInfo> list = new List<UserInfo>();
           while (dr.Read())
           {
               UserInfo user = new UserInfo();
               user.Cardid = int.Parse(dr[0].ToString());
               user.Carduser = dr[1].ToString();
               user.Cardpwd = dr[2].ToString();
               user.Username = dr[3].ToString();
               user.Userjob = dr[4].ToString();
               user.Usertel = dr[5].ToString();
               user.Useraddr = dr[6].ToString();
               user.Userlove = dr[7].ToString();
               user.Userphone = dr[8].ToString();
               user.Usersex = dr[9].ToString();
               user.Userbirth = dr[10].ToString();
               user.Cardtime = dr[11].ToString();
               user.Cardbak = dr[12].ToString();
               user.Cardstata = dr[13].ToString();
               user.Price = float.Parse(dr[14].ToString());
               list.Add(user);
           }
           return list;
       }
       public static UserInfo GetUserInfoByCard(string card)
       {
           string sql = string.Format("select * from Card_User where Card_User ='{0}'", card);
           OleDbDataReader dr = Dbhelper.ExecuteReader(sql);

           //List<UserInfo> list = new List<UserInfo>();
           if (dr.Read())
           {
               UserInfo user = new UserInfo();
               user.Cardid = int.Parse(dr[0].ToString());
               user.Carduser = dr[1].ToString();
               user.Cardpwd = dr[2].ToString();
               user.Username = dr[3].ToString();
               user.Userjob = dr[4].ToString();
               user.Usertel = dr[5].ToString();
               user.Useraddr = dr[6].ToString();
               user.Userlove = dr[7].ToString();
               user.Userphone = dr[8].ToString();
               user.Usersex = dr[9].ToString();
               user.Userbirth = dr[10].ToString();
               user.Cardtime = dr[11].ToString();
               user.Cardbak = dr[12].ToString();
               user.Cardstata = dr[13].ToString();
               user.Price = float.Parse(dr[14].ToString());
           //    list.Add(user);
               return user;
           }
           return null;
       }
       public static int Pay_pro(float price,string card)
       {
           string sql = string.Format("update card_user set card_price='{0}' where card_user = '{1}'",price,card);
           return Dbhelper.ExecuteNonQuery(sql);

       }
       public static int DelUser(int id)
       {
           string sql = string.Format("delete from card_user where card_id={0}",id);
           return Dbhelper.ExecuteNonQuery(sql);

       }




    }
}
