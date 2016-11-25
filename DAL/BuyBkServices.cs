using System;
using System.Collections.Generic;
using System.Text;
using SysCard.Models;
using System.Data;
using System.Data.OleDb;
namespace SysCard.DAL
{
   public class BuyBkServices
    {
       public static int AddByBk(BuyBk bk)
       {
           string sql = string.Format("insert into buy_bk(Buy_product,Buy_Price,Buy_Time,Buy_Count,buy_from) values('{0}','{1}','{2}','{3}','{4}')",bk.Buyproduct,bk.Buyprice,bk.Buytime,bk.Count,bk.BuyFrom);
           return Dbhelper.ExecuteNonQuery(sql); 
       }
       public static List<BuyBk> GetAllBuyBk()
       {
           string sql = "select * from buy_bk";
           OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
           List<BuyBk> list = new List<BuyBk>();
           while (dr.Read())
           {
               BuyBk by = new BuyBk();
               by.Buyid = int.Parse(dr[0].ToString());
               by.Buyproduct = dr[1].ToString();
               by.Buyprice = dr[2].ToString();
               by.Buytime = dr[3].ToString();
               by.Count = int.Parse(dr[4].ToString());
               by.BuyFrom = dr[5].ToString();
               list.Add(by);

           }
           dr.Close();
           return list;
       }
       public static List<BuyBk> GetAllBuyBkByTime(string begintime,string endtime)
       {
           string sql =  string.Format( "select * from buy_bk where buy_time between #{0}# and #{1}#",begintime,endtime);
           OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
           List<BuyBk> list = new List<BuyBk>();
           while (dr.Read())
           {
               BuyBk by = new BuyBk();
               by.Buyid = int.Parse(dr[0].ToString());
               by.Buyproduct = dr[1].ToString();
               by.Buyprice = dr[2].ToString();
               by.Buytime = dr[3].ToString();
               by.Count = int.Parse(dr[4].ToString());
               by.BuyFrom = dr[5].ToString();
               list.Add(by);

           }
           dr.Close();
           return list;
       }
       public static float GetAllBuyBkByUser(string username)
       {
           string sql = string.Format("select sum(buy_price) from buy_bk where buy_from='{0}'" ,username);
           OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
           if (dr.Read())
           {
               try
               {
                   return float.Parse(dr[0].ToString());
               }
               catch
               {
                   return 0f;
               }
           }
           dr.Close();
           return 0f;
       }
    }
}

