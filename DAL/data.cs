using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using SysCard.DAL.Manager;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SysCard.DAL.Data
{

    public class DataService
    {
        public static DataSet ds;
        public static OleDbDataAdapter myCommand;
        public static string strConn;
        public static string strExcel;
        public static OleDbConnection conn;
        public static int excelTime = 0;


        public static string GetPermissionInfo()//获取授权信息，返回LOG表最后一条信息
        {
            string sql = " select * from  Log";
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            string remainDays = null;
            try
            {
                while(dr.Read())
                {
                    remainDays = dr[0].ToString() + ";" + dr[1].ToString() + ";" + dr[2].ToString() + ";" + dr[3].ToString() + ";";
                }
            }
            catch
            {
                MessageBox.Show("读取授权信息失败");
                return "0;0;0;0;" ;
            }
            
            return remainDays;

        }

        public static int UpdataPer(string featureCode,uint days)
        {
            string sql = string.Format(" update  Log set per='{4}'  where ID = {0} and CDK = '{1}' and Data= '{2}' and per='{3}'", 1, "coffee", "coffee", "coffee","Used");//修改第一LOG
            int val = Dbhelper.ExecuteNonQuery(sql);
            sql = string.Format("insert into Log (CDK,Data,per) values('{0}','{1}','{2}')", featureCode, System.DateTime.Now.ToString(), days.ToString());
            val = Dbhelper.ExecuteNonQuery(sql);
            return val;

        }

        public static bool IsFirstUse()
        {
            string sql = string.Format(" select * from  Log where ID = {0} and CDK = '{1}' and Data= '{2}' and per='{3}'", 1,"coffee","coffee","coffee");
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            try
            {
                if (dr.Read())
                {
                   // MessageBox.Show("true");
                    return true;
                }
                else
                    //MessageBox.Show("false");
                    return false;

            }
            catch
            {
                MessageBox.Show("false");
                return false;
            }
        }
        public static void ImportExcelToAcess(string path)//A1
        {
            OpenExcelToDs(path);//数据缓存至DataService.ds中。
            ObjInfo obj = new ObjInfo();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                obj.Name = ds.Tables[0].Rows[i][1].ToString();
                obj.Parameter1 = ds.Tables[0].Rows[i][2].ToString();
                obj.Parameter2 = ds.Tables[0].Rows[i][3].ToString();
                obj.Parameter3 = ds.Tables[0].Rows[i][4].ToString();
                obj.BasePrice1 = ds.Tables[0].Rows[i][5].ToString();
                obj.BasePrice2 = ds.Tables[0].Rows[i][6].ToString();
                obj.BasePrice3 = ds.Tables[0].Rows[i][7].ToString();
                obj.Comments = ds.Tables[0].Rows[i][8].ToString();

                obj.Index = IsExistInAcess(obj);
                if (obj.Index >= 0)
                {
                    
                    EditObj("CHANGE", obj);
                }
                else
                {
                    EditObj("ADD", obj);
                }
            }
            MessageBox.Show("导入数据成功！新的数据将在重启软件后生效");

        }

        public static int IsExistInAcess(ObjInfo obj)
        {
            string sql = string.Format(" select * from  PriceInfo where 物品名称 = '{0}' and 参数1 = '{1}' and 参数2= '{2}' and 参数3= '{3}'", obj.Name, obj.Parameter1, obj.Parameter2,
                    obj.Parameter3);
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            if (dr != null)
            {
                if (dr.Read())
                {
                    return int.Parse(dr[0].ToString());
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;//-1代表没有寻求到序号。
            }
            //return true;
        }
        public static employeeInfo LoginEmployee(string username, string userpwd)//验证密码是否正确
        {
            string sql = string.Format("select * from EmployeeInfo where EmployeeName='{0}' and EmployeePassword='{1}'", username, userpwd);
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            employeeInfo Employee = new employeeInfo();

            if (dr != null)
            {
                if (dr.Read())
                {
                    Employee.Id = uint.Parse(dr[0].ToString());
                    Employee.Name = dr[1].ToString();
                    Employee.Password = dr[2].ToString();
                    Employee.Type = dr[4].ToString();
                }
                return Employee;
            }
            else return null;
        }

        public static int EditObj(string cmd,ObjInfo obj)//编辑价格
        {
            if (cmd == "DEL")
            {
                string sql = string.Format("delete * from PriceInfo where 序号={0}",obj.Index);
                int val = Dbhelper.ExecuteNonQuery(sql);
                return val;
            }
            else if (cmd == "ADD")
            {
                string sql = string.Format("insert into PriceInfo (物品名称,参数1,参数2,参数3,价格1,价格2,价格3,备注) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", obj.Name, obj.Parameter1,obj.Parameter2,
                    obj.Parameter3,obj.BasePrice1,obj.BasePrice2,obj.BasePrice3,obj.Comments);
                int val = Dbhelper.ExecuteNonQuery(sql);
                return val;
            }
            else if (cmd == "CHANGE")//传进来的是带原ID的修改后obj
            {
                string sql = string.Format("update PriceInfo set 物品名称='{1}' , 参数1='{2}' , 参数2='{3}' , 参数3='{4}' , 价格1='{5}' , 价格2='{6}' , 价格3='{7}'  where 序号={0}"
                  ,obj.Index, obj.Name, obj.Parameter1, obj.Parameter2,
                    obj.Parameter3, obj.BasePrice1, obj.BasePrice2, obj.BasePrice3);
                int val = Dbhelper.ExecuteNonQuery(sql);
                return val;
            }
            ControCenter.ObjInfoData.Clear();
            ControCenter.ObjInfoData = GetALLObjInfo();//刷新控制中心的价格数据缓存。
            return 0;
        }

        public static List<ObjInfo> GetListFormDs()//从Dataset返回List obj列表
        {
            List<ObjInfo> viewList = new List<ObjInfo>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ObjInfo obj = new ObjInfo();
                obj.Index = int.Parse(ds.Tables[0].Rows[i][0].ToString());
                obj.Name = ds.Tables[0].Rows[i][1].ToString();
                obj.Parameter1 = ds.Tables[0].Rows[i][2].ToString();
                obj.Parameter2 = ds.Tables[0].Rows[i][3].ToString();
                obj.Parameter3 = ds.Tables[0].Rows[i][4].ToString();
                obj.BasePrice1 = ds.Tables[0].Rows[i][5].ToString();
                obj.BasePrice2 = ds.Tables[0].Rows[i][6].ToString();
                obj.BasePrice3 = ds.Tables[0].Rows[i][7].ToString();
                obj.Comments = ds.Tables[0].Rows[i][8].ToString();
                viewList.Add(obj);

            }
            return viewList;

        }

        public static bool DsCoverToExcel(string path)//将Dataset中的数据创建成新表格
        {
            string[] str = DateTime.Now.GetDateTimeFormats();
            string days = str[10];
            string time = str[146].Replace(":","点");
            conn.Close();
            String sConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=" + path + days + time + ".xls" +
            ";Extended Properties=Excel 8.0;";
            OleDbConnection cn = new OleDbConnection(sConnectionString);
            string sqlCreate = "CREATE TABLE 软件填充 ([序号] VarChar,[物品名称] VarChar,[参数1] VarChar,[参数2] VarChar,[参数3] VarChar,[价格1] VarChar,[价格2] VarChar,[价格3] VarChar,[备注2] VarChar)";
            OleDbCommand cmd = new OleDbCommand(sqlCreate, cn);
            cn.Open();
            //创建TestSheet工作表
            try
            {
                cmd.ExecuteNonQuery();
                //添加数据
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cmd.CommandText = string.Format("INSERT INTO 软件填充 VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", ds.Tables[0].Rows[i][0].ToString(), ds.Tables[0].Rows[i][1].ToString(), ds.Tables[0].Rows[i][2].ToString(),
                        ds.Tables[0].Rows[i][3].ToString(), ds.Tables[0].Rows[i][4].ToString(), ds.Tables[0].Rows[i][5].ToString(), ds.Tables[0].Rows[i][6].ToString(), ds.Tables[0].Rows[i][7].ToString(), ds.Tables[0].Rows[i][8].ToString());
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("生成表格成功，祝发财");
                //关闭连接
                cn.Close();
            }
            catch
            {
                MessageBox.Show("生成表格失败");
            }
            

            return true;
        }

        public static DataSet OpenExcelToDs(string Path)//打开excel文件，拷贝数据至Dataset
        {
  
            strConn = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Path + ";" + "Extended Properties=Excel 8.0;";//要更新支持xlsx格式
            conn = new OleDbConnection(strConn);
            conn.Open();
            strExcel = "";
            myCommand = null;
            ds = null;
            DataTable sheetsName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" }); //得到所有sheet的名字
            string firstSheetName = sheetsName.Rows[0][2].ToString(); //得到第一个sheet的名字
            strExcel = string.Format("SELECT * FROM [{0}]", firstSheetName); //查询字符串
            //strExcel = "select * from [PriceInfo]";
            myCommand = new OleDbDataAdapter(strExcel, strConn);
            ds = new DataSet(); myCommand.Fill(ds, "table1");
            conn.Close();
            return ds;
            
        }

        public static bool FillPriceOfDs()
        {
            ObjInfo obj = new ObjInfo();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                obj.Index = int.Parse(ds.Tables[0].Rows[i][0].ToString());
                obj.Name = ds.Tables[0].Rows[i][1].ToString();
                obj.Parameter1 = ds.Tables[0].Rows[i][2].ToString();
                obj.Parameter2 = ds.Tables[0].Rows[i][3].ToString();
                obj.Parameter3 = ds.Tables[0].Rows[i][4].ToString();
                obj.Comments = ds.Tables[0].Rows[i][8].ToString();
                obj = DataService.MatchExcelData(obj);
                ds.Tables[0].Rows[i][5] = obj.BasePrice1;
                ds.Tables[0].Rows[i][6] = obj.BasePrice2;
                ds.Tables[0].Rows[i][7] = obj.BasePrice3;
                ds.Tables[0].Rows[i][8] = obj.Comments;

            }
            //myCommand.Fill(ds, "table1");
            return true;
        }



        public static ObjInfo MatchExcelData(ObjInfo obj)//在数据库中查找匹配的价格
        {

            int time = 0;//匹配的数据个数
            //ControCenter.ObjInfoData = DataService.GetALLObjInfo();
            for (int i = 0; i < ControCenter.ObjInfoData.Count; i++)
            {
                if (obj.Name == ControCenter.ObjInfoData[i].Name &&
                   obj.Parameter1 == ControCenter.ObjInfoData[i].Parameter1 &&
                   obj.Parameter2 == ControCenter.ObjInfoData[i].Parameter2 &&
                   obj.Parameter3 == ControCenter.ObjInfoData[i].Parameter3)
                {
                    obj.BasePrice1 = ControCenter.ObjInfoData[i].BasePrice1;
                    obj.BasePrice2 = ControCenter.ObjInfoData[i].BasePrice2;
                    obj.BasePrice3 = ControCenter.ObjInfoData[i].BasePrice3;
                    time += 1;
                }

            }
            if (time > 1)
            {
                obj.Comments = "存在多个同参数产品，这里以最后一个的价格填充。请在报价查询界面核查";
                time = 0;
            }
            else if (time == 0)
            {
                obj.BasePrice1 = "没有符合要求的数据";
                obj.BasePrice2 = "没有符合要求的数据";
                obj.BasePrice3 = "没有符合要求的数据";
            }
            return obj;

        }
        public static int ChangeVipConnCard(string CardNum,VipInfo vip)
        {
            string OldBalance = GetCardBalance(vip.ConnectCarNum);//转移余额
            string sql = string.Format("update SentCardInfo set Balance='{0}' where CardNumber= '{1}' ", 0, vip.ConnectCarNum);
            int val = Dbhelper.ExecuteNonQuery(sql);
            sql = string.Format("update SentCardInfo set Balance='{0}' where CardNumber='{1}' ", uint.Parse(OldBalance), CardNum);
            val = Dbhelper.ExecuteNonQuery(sql);
            sql = string.Format("update VipInfo set CardNumber='{0}' where VipId= {1} ", CardNum,vip.VipId);
            //标准表达式中数据类型不匹配
            val = Dbhelper.ExecuteNonQuery(sql);
            sql = string.Format("update SentCardInfo set ConnectVipId='{0}' and Balance='{1}' where CardNumber='{2}' ", vip.VipId, uint.Parse(OldBalance), CardNum);
            val = val + Dbhelper.ExecuteNonQuery(sql);
            return val;
        }
        public static int ChangeCardStatus(string CardNum,SentCardInfo.CardStatus status)
        {
            string sql = string.Format("update SentCardInfo set CardStatus='{0}' where CardNumber='{1}' ", status.ToString(), CardNum);
            int val = Dbhelper.ExecuteNonQuery(sql);
            return val;
        }

        public static string GetCardStatus(string CardNum)
        {
            string sql = string.Format("select * from SentCardInfo where CardNumber = '{0}' ", CardNum);
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            if (dr.Read())
            {
                return dr[4].ToString();               
            }
            else return "未发的卡";
        }

        public static List<VipInfo> SearchVipInfo(string name, string phone,string CardNum)
        {
            string sql = string.Format("select * from VipInfo where VipName='{0}' and VipPhone='{1}' and CardNumber='{2}'", name, phone,CardNum);
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            List<VipInfo> list = new List<VipInfo>();
            while (dr.Read())
            {
                VipInfo vip = new VipInfo();
                vip.VipId = dr[0].ToString();
                vip.Name = dr[1].ToString();
                vip.Phone = dr[2].ToString();
                vip.Birthday = dr[3].ToString();
                vip.Level = uint.Parse(dr[4].ToString());
                vip.Sex = dr[5].ToString();
                vip.ConnectCarNum = dr[6].ToString();
                list.Add(vip);

            }
            dr.Close();
            return list;
        }
        public static List<VipInfo> SearchVipInfo(string name, string phone)
        {
            string sql = string.Format("select * from VipInfo where VipName='{0}' and VipPhone='{1}'", name,phone);
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            List<VipInfo> list = new List<VipInfo>();
            while (dr.Read())
            {
                VipInfo vip = new VipInfo();
                vip.VipId = dr[0].ToString();
                vip.Name = dr[1].ToString();
                vip.Phone = dr[2].ToString();
                vip.Birthday = dr[3].ToString();
                vip.Level = uint.Parse(dr[4].ToString());
                vip.Sex = dr[5].ToString();
                vip.ConnectCarNum = dr[6].ToString();
                list.Add(vip);

            }
            dr.Close();
            return list;
        }
        public static List<VipInfo> SearchAllVipInfo()
        {
            string sql = string.Format("select * from VipInfo");
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            List<VipInfo> list = new List<VipInfo>();
            while (dr.Read())
            {
                VipInfo vip = new VipInfo();
                vip.VipId = dr[0].ToString();
                vip.Name = dr[1].ToString();
                vip.Phone = dr[2].ToString();
                vip.Birthday = dr[3].ToString();
                vip.Level = uint.Parse(dr[4].ToString());
                vip.Sex = dr[5].ToString();
                vip.ConnectCarNum = dr[6].ToString();
                list.Add(vip);

            }
            dr.Close();
            return list;
        }
        public static int AddNewVip(VipInfo vip, string CardNum)
        {
            string sql = string.Format("insert into VipInfo (VipName,VipPhone,VipBirth,VipLevel,Sex,CardNumber) values('{0}','{1}','{2}','{3}','{4}',{5})", vip.Name, vip.Phone, vip.Birthday,"5",vip.Sex, CardNum);
            int val = Dbhelper.ExecuteNonQuery(sql);
            sql = string.Format("update SentCardInfo set ConnectVipId='{0}' where CardNumber='{1}' ", GetVipIdFromVipInfo(CardNum), CardNum);
            val = val + Dbhelper.ExecuteNonQuery(sql);
            return val;
        }

        public static uint GetVipIdFromVipInfo(string CardNum)
        {
            string sql = string.Format("select * from VipInfo where CardNumber = '{0}'", CardNum);
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            if (dr.Read())
            {
                if (dr[0].ToString() == "") return 0;
                else return uint.Parse(dr[0].ToString());
            }
            else return 0;
        }
        public static uint GetVipId(string CardNum)//从sentCardInfo里查找固定卡号的关联VipId
        {
            //string sql = string.Format("select * from SentCardInfo where CardNumber = '{0}' and CardStatus = '{1}' ", CardNum, "活动");
            string sql = string.Format("select * from SentCardInfo where CardNumber = '{0}'", CardNum);
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            if (dr.Read())
            {
                if (dr[3].ToString() == "") return 0;
                else return uint.Parse(dr[3].ToString());
            }
            else return 0;
        }


        public static VipInfo GetVipInfo(uint VipId,VipInfo vip)
        {
            string sql = string.Format("select * from VipInfo where VipId = {0}", VipId.ToString());//标准表达式中数据类型不匹配。不能使用上面一样的单引号
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            if (dr.Read())
            {
                vip.VipId = dr[0].ToString();
                vip.Name = dr[1].ToString();
                vip.Phone = dr[2].ToString();
                vip.Birthday = dr[3].ToString();
                vip.Level = uint.Parse(dr[4].ToString());
                vip.Sex = dr[5].ToString();
                vip.ConnectCarNum = dr[6].ToString();
            }
            return vip;
        }
        public static bool Consume(string CardNum, uint ConsBalance)
        {
            string sql = string.Format("select * from SentCardInfo where CardNumber = '{0}' and CardStatus = '{1}' ", CardNum, "活动");
            int val = Dbhelper.ExecuteNonQuery(sql);
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            if (dr.Read())
            {
                if (int.Parse(dr[5].ToString()) - ConsBalance >= 0)
                {
                    string UpdataBalance = string.Format("update SentCardInfo set Balance='{0}' where CardNumber='{1}' ", uint.Parse(dr[5].ToString()) - ConsBalance, CardNum);
                    val = Dbhelper.ExecuteNonQuery(UpdataBalance);
                    if (val > 0 && val < 2)
                        return true;
                    else return false;
                }
                else return false;

            }
            else return false;
        }

        public static bool TopIn(string CardNum, uint TopInBalance)
        {
            string sql = string.Format("select * from SentCardInfo where CardNumber = '{0}' and CardStatus = '{1}' ", CardNum, "活动");
            int val = Dbhelper.ExecuteNonQuery(sql);
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            if (dr.Read())
            {
                string UpdataBalance = string.Format("update SentCardInfo set Balance='{0}' where CardNumber='{1}' ", TopInBalance + uint.Parse(dr[5].ToString()),CardNum);
                val = Dbhelper.ExecuteNonQuery(UpdataBalance);
                if (val > 0 && val < 2)
                    return true;
                else return false;
            }
            else return false;
        }

        public static string GetCardBalance(string CardNum)
        {
            string sql = string.Format("select * from SentCardInfo where CardNumber = '{0}'", CardNum);
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            if (dr != null)
            {
                if (dr.Read())
                {
                    return dr[5].ToString();
                }
                else return null;
            }
            else return null;
        }
        public static PrivilegeInfo GetPriInfo()
        {//更改刷新逻辑
            PrivilegeInfo pri = new PrivilegeInfo();
            string sql = string.Format("select * from PrivilegeInfo");
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            if (dr.Read())
            {
                pri.BuyN = uint.Parse(dr[1].ToString());
                pri.FreeN = uint.Parse(dr[2].ToString());
            }
            return pri;
        }

        public static SentCardInfo GetCardInfoAct(string CardNum)  //查找已发卡表中是否有在使用中的卡，有返回卡的信息，没有返回null
        {
            string sql = string.Format("SELECT * from SentCardInfo where CardNumber = '{0}' and CardStatus = '{1}'", CardNum, SentCardInfo.CardStatus.活动);
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            SentCardInfo cardinfo = new SentCardInfo();
            if (dr.Read())
            {
                cardinfo.CarNumber = dr[1].ToString();
                cardinfo.SentTime = DateTime.Parse(dr[2].ToString());
                try//没有关联会员的卡
                {
                    cardinfo.ConnectVipId = uint.Parse(dr[3].ToString());
                }
                catch
                {

                }
                cardinfo.Status = dr[4].ToString();
                cardinfo.Balance =uint.Parse(dr[5].ToString());
                return cardinfo;
            }
            else return null;
        }

        public static bool SentNewCard(string CardNum)
        {
            if (GetCardStatus(CardNum) == "未发的卡")
            {
                string sql = string.Format("insert into SentCardInfo (CardNumber,SentTime,CardStatus) values('{0}','{1}','{2}')", CardNum, DateTime.Now, SentCardInfo.CardStatus.活动);
                try
                {
                    Dbhelper.ExecuteNonQuery(sql);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else return false;           
        }
     /*   public static bool VerifyConnExcel(string path)//验证连接数据库
        {
            OleDbConnection conn = null;
            conn = Dbhelper.GetOleDbConnectionExcel(path);
            try
            {
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {

            }
        }*/
        public static bool VerifyConn()//验证连接数据库
        {
            OleDbConnection conn = null;
            conn = Dbhelper.GetOleDbConnection();
            try
            {
                  conn.Open();
                  return true;
            }
            catch
            {
                  return false;
            }
            finally
            {
                  
            }
        }
            

            public static int AddEmployee(employeeInfo Employee)
            {
                if (Employee.Name != "" && Employee.Password != "" && LoginEmployee(Employee.Name, Employee.Password).Name == null)
                {
                    string sql = string.Format("insert into EmployeeInfo (EmployeeName,EmployeePassword,CreateTime,EmployeeType) values('{0}','{1}','{2}','{3}')", Employee.Name, Employee.Password, System.DateTime.Now.ToString(), Employee.Type);
                    return Dbhelper.ExecuteNonQuery(sql);
                }
                return 0;
            }

            public static int UpdataEmployee(employeeInfo Employee)
            {
                string sql = string.Format("update EmployeeInfo set EmployeePassword='{1}' where EmployeeName='{0}'", Employee.Name, Employee.Password);
                return Dbhelper.ExecuteNonQuery(sql);
            }
            public static employeeInfo LoginEmployee(string username, string userpwd, AdminType LogType)
            {
                string sql = string.Format("select * from EmployeeInfo where EmployeeName='{0}' and EmployeePassword='{1}' and EmployeeType='{2}'", username, userpwd,LogType);
                OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
                employeeInfo Employee = new employeeInfo();
                
                if(dr != null)
                {
                    if (dr.Read())
                    {
                        Employee.Id = uint.Parse(dr[0].ToString());
                        Employee.Name = dr[1].ToString();
                        Employee.Password = dr[2].ToString();
                    }
                    return Employee;
                }
                else return null;
            }
           
        public static List<ObjInfo> GetALLObjInfo()//获取所有物品信息
            {
                string sql = "select * from PriceInfo";
                OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
                List<ObjInfo> list = new List<ObjInfo>();
                while (dr.Read())
                {
                    ObjInfo Obj = new ObjInfo();
                    Obj.Index  = int.Parse(dr[0].ToString());
                    Obj.Name = dr[1].ToString();
                    Obj.Parameter1 = dr[2].ToString();
                    Obj.Parameter2 = dr[3].ToString();
                    Obj.Parameter3 = dr[4].ToString();
                    Obj.BasePrice1 = dr[5].ToString();
                    Obj.BasePrice2 = dr[6].ToString();
                    Obj.BasePrice3 = dr[7].ToString();
                    Obj.Comments = dr[8].ToString();
                    
                    //使用控件显示所有数据
                    list.Add(Obj);
                }
                dr.Close();

                return list;
            }

            public static List<employeeInfo> GetALLEmployee()
            {
                string sql = "select * from EmployeeInfo";
                OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
                List<employeeInfo> list = new List<employeeInfo>();
                while (dr.Read())
                {
                    employeeInfo Employee = new employeeInfo();
                    Employee.Id = uint.Parse(dr[0].ToString());
                    Employee.Name = dr[1].ToString();
                    Employee.Password = dr[2].ToString();
                    //使用控件显示所有数据
                    list.Add(Employee);
                }
                dr.Close();

                return list;
            }
            public static int DelEmployee(employeeInfo Employee)
            {
                string sql = string.Format("delete from EmployeeInfo where EmployeeId = {0}", Employee.Id);
                return Dbhelper.ExecuteNonQuery(sql);
            }
            public static void test()
            {
                string sql = string.Format("select * from EmployeeInfo");
                OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
                while (dr.Read())
                {
                }
            }


    }




    public class SentCardInfo
    {
       private string carNumber;
        public string CarNumber
        {
            get { return carNumber; }
            set { carNumber = value; }
        }
       private  DateTime sentTime;

        public DateTime SentTime
        {
            get { return sentTime; }
            set { sentTime = value; }
        }
       private  uint connectVipId;

        public uint ConnectVipId
        {
            get { return connectVipId; }
            set { connectVipId = value; }
        }

        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private uint balance;
        public uint Balance
        {
            get { return balance; }
            set { balance = value; }
        }


        public enum CardStatus { 活动, 挂失, 废弃 };//活动，挂失，废弃

    }

    public class ObjInfo
    {

        public ObjInfo(uint status)//传入数字不同返回不同状态的特殊对象
        {
            if (status == 0)
            {
                name = "没有数据";
                index = -1;
                parameter1 = "没有数据";
                parameter2 = "没有数据";
                parameter3 = "没有数据";
                basePrice1 = "没有数据";
                basePrice2 = "没有数据";
                basePrice3 = "没有数据";
                comments = "没有数据";
            }
        }
        public ObjInfo()
        { }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int index;
        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        private string parameter1;
        public string Parameter1
        {
            get { return parameter1; }
            set { parameter1 = value; }
        }

        private string parameter2;
        public string Parameter2
        {
            get { return parameter2; }
            set { parameter2 = value; }
        }

        private string parameter3;
        public string Parameter3
        {
            get { return parameter3; }
            set { parameter3 = value; }
        }


        private string basePrice1;
        public string BasePrice1
        {
            get { return basePrice1; }
            set { basePrice1 = value; }
        }

        private string basePrice2;
        public string BasePrice2
        {
            get { return basePrice2; }
            set { basePrice2 = value; }
        }

        private string basePrice3;
        public string BasePrice3
        {
            get { return basePrice3; }
            set { basePrice3 = value; }
        }
        private string comments;
        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }


    }
    public class VipInfo
    {

        public VipInfo(uint status)//传入数字不同返回不同状态的特殊对象
        {
            if (status == 0)
            {
                name = "没有关联会员";
                phone = "没有关联会员";
                birthday = "没有关联会员";
                level = 0;
                sex = "没有关联会员";
                vipId = "没有关联会员";
                connectCarNum = "没有关联会员";
            }
        }
        public VipInfo()
        {
        }


        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string birthday;
        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        private uint level;
        public uint Level
        {
            get { return level; }
            set { level = value; }
        }

        private string sex;
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public enum SEX { MAN,WOMEN};

        private string vipId;
        public string VipId
        {
            get { return vipId; }
            set { vipId = value; }
        }

        private string connectCarNum;
        public string ConnectCarNum
        {
            get { return connectCarNum; }
            set { connectCarNum = value; }
        }


    }


    public class PrivilegeInfo//优惠类
    {

        private string priName;
        public string PriName
        {
            get { return priName; }
            set { priName = value; }
        }

        //public PriType type;
        private uint buyN;//买多少个
        public uint BuyN
        {
            get { return buyN; }
            set { buyN = value; }
        }

        private uint freeN;//送多少个
        public uint FreeN
        {
            get { return freeN; }
            set { freeN = value; }
        }


        //public float discount;
    }


    public class OperatRecordInfo
    {
       
        public enum OperateType { TopIn, Consume,SentCard}
        
        private OperateType type;
        public OperateType Type
        {
            get { return type; }
            set { type = value; }
        }


        private DateTime operatTime;
        public DateTime OperatTime
        {
            get { return operatTime; }
            set { operatTime = value; }
        }

        private uint employeeId;
        public uint EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; } 
        }
        private uint balance;
        public uint Balance
        {
            get { return balance; }
            set { balance = value; }
        }

    }

    public class employeeInfo
    {

        private uint id;
        public uint Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private DateTime createTime;
        public DateTime CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }


    //public enum CommodityType { MaJiang, AnyElse };
    //public enum PriType { BuyNFreeN, Discount, BuyNDisN, None };//买N送N，折扣,买N折扣N，无

}



