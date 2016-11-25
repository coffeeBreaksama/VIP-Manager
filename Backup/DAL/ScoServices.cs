using System;
using System.Collections.Generic;
using System.Text;
using SysCard.Models;
using System.Data;
using System.Data.OleDb;
namespace SysCard.DAL
{
  public  class ScoServices
    {
      public static int AddScor(ScoInfo1 sco)
      {
          string sql = string.Format("insert into card_sco (sco_user,sco_sco,sco_his) values('{0}','{1}','{2}')",sco.User,sco.Sco,sco.ScoHis);
          return Dbhelper.ExecuteNonQuery(sql); 
      }
      public static List<ScoInfo1> GetAllSco()
      {
          string sql = "select * form card_sco";
          OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
          List<ScoInfo1> list = new List<ScoInfo1>();
          while (dr.Read())
          {
              ScoInfo1 sco = new ScoInfo1();
              sco.Id = int.Parse(dr[0].ToString());
              sco.User = dr[1].ToString();
              sco.Sco = dr[2].ToString();
              sco.ScoHis = dr[3].ToString();
              list.Add(sco);
          }
          return list;
      }
      public static int UpdataSco(ScoInfo1 sco)
      {
          string sql = string.Format("update card_sco set sco_sco='{0}', sco_his='{1}' where sco_user='{2}'",sco.Sco,sco.ScoHis,sco.User);
          return Dbhelper.ExecuteNonQuery(sql);
      }
      public static int DelSco(ScoInfo1 sco)
      {
          string sql = string.Format("DELETE sci where sco_id = {0}", sco.Id);
          return Dbhelper.ExecuteNonQuery(sql);
      }
      public static ScoInfo1 GetScorByUser(string username)
      {
          string sql = string.Format("select * from card_sco where sco_user = '{0}'",username);
          OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
          if (dr.Read())
          {
              ScoInfo1 sco = new ScoInfo1();
              sco.Id = int.Parse(dr[0].ToString());
              sco.User = dr[1].ToString();
              sco.ScoHis = dr[3].ToString();
              sco.Sco = dr[2].ToString();
              return sco;
          }
          ScoInfo1 sco1 = new ScoInfo1();
          sco1.User = username;
          sco1.ScoHis = "0";
          sco1.Sco = "0";
          AddScor(sco1);
          return sco1;


      }
    }
}
