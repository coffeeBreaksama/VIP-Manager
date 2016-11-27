using System;
using System.Collections.Generic;
using System.Text;
using SysCard.DAL.Manager;
using System.Data.OleDb;
using System.Windows.Forms;
namespace SysCard.DAL.Data
{
    public class DataService
    {
        
        
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
                string sql = string.Format("insert into EmployeeInfo (ID,EmployeeName,EmployeePassword) values('{0}','{1}','{2}')", Employee.Id, Employee.Name, Employee.Password);
                return Dbhelper.ExecuteNonQuery(sql);
            }

            public static int UpdataEmployee(employeeInfo Employee)
            {
                string sql = string.Format("update EmployeeInfo (ID,EmployeeName,EmployeePassword) values('{0}','{1}','{2}')", Employee.Id, Employee.Name, Employee.Password);
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
    }


    //public enum CommodityType { MaJiang, AnyElse };
    //public enum PriType { BuyNFreeN, Discount, BuyNDisN, None };//买N送N，折扣,买N折扣N，无

}



