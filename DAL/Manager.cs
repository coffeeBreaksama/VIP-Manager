using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Text;
using SysCard.DAL.Waiter;
using SysCard.DAL.Data;
using System.Threading;//用于启用线程类;
using System.Management;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.Cryptography;
using System.Text.RegularExpressions;


namespace SysCard.DAL.Manager//主要的业务逻辑实现控制台
{
    public class ControCenter
    {
        public static uint NowLogId;
        public static string NowLogName;
        public static string NowLogType;
        public static admin NowLogAdmin;
        public static PrivilegeInfo NowPrivilege;
        public static List<ObjInfo> ObjInfoData;
        public static DataSet ds;
        public static string CpuId;
        public static string HdId;
        public static string FeatureCode;//根据CPUID加密计算出来的特征码，CDK log中储存的也是特征码
        public static bool FirstUse;
        public static string PermissionCode;//数据库返回的包含所有CDK信息的字符串
        public static string[] str;
        private static string KEY = "TONGYUEY";
        public static int remainDays;


        public ControCenter()
        {
            LoadObjData();
            //KEY = GenerateKey();
        }

        public static string GernerCDK(string code,string time,int type)
        {
            string testCDK = null;
            if (type == 0)
            {
                testCDK = Encrypt(FeatureCode + ":" + time, KEY);
                return testCDK;
            }
            else if (type == 1)
            {
                string xufeiInfo = Decrypt(code, KEY);//从续费特征码计算出续费信息。
                string[] xufeisArray = Regex.Split(xufeiInfo, ";", RegexOptions.IgnoreCase);//
                string getCDK = Encrypt(xufeisArray[0] + ";xufei;130", KEY);//这里的150后续要设变量
                return getCDK;

            }
            return null;
        }

        public static bool CertifyXufeiCode(string XufeiCode, string XufeiCDK)//验证CDK若为真，更新LOG表。
        {
            string xufeiInfo = Decrypt(XufeiCode, KEY);//从续费特征码计算出续费信息。
            string[] xufeisArray = Regex.Split(xufeiInfo, ";", RegexOptions.IgnoreCase);//
            string getCDK = Encrypt(xufeisArray[0] + ";xufei;130", KEY);//这里的150后续要设变量


            try
            {
                string middle = Decrypt(XufeiCDK, KEY);//解密CDK转化为续费特征码
                string[] sArray = Regex.Split(middle, ";", RegexOptions.IgnoreCase);//
                uint day = uint.Parse(sArray[2]);
                if (sArray[0] == CpuId)//验证成功
                {
                    MessageBox.Show("续费成功！欢迎使用！");
                    DataService.UpdataPer(FeatureCode, day);//更新授权表数据
                    remainDays = int.Parse(sArray[3]);
                    return true;
                }

                else
                    return false;
            }
            catch
            {
                return false;
            }

        }
        public static string GetXufeiCode()//计算返回续费特征码
        {
            if (str == null)
                return FeatureCode;
            string xufeicode = CpuId +";"+ str[2] +";" + str[3];
            string code;
            try
            {
                code = Encrypt(xufeicode, KEY);
                return code;

            }
            catch
            {
                MessageBox.Show("获取序列号失败，请联系销售人员");
                return null;
            }
        }


        public static int VerifyUsingPermission()//验证授权，返回剩余使用天数,更新remainDays值。
        {
            int day = 0;
            PermissionCode = DataService.GetPermissionInfo();
            str = Regex.Split(PermissionCode, ";");
            if (NowLogType == "开发者")
                return 999;
            else
            {
                try
                {
                    if (str[1] == FeatureCode)//特征码与库中数据对的上。
                    {
                        DateTime CDKCreatTime = DateTime.Parse(str[2]);
                        DateTime now = System.DateTime.Now;
                        DateTime overdueDay = CDKCreatTime.AddDays(int.Parse(str[3]));
                        TimeSpan remainTime = overdueDay - now;
                        // MessageBox.Show(remainTime.TotalDays.ToString());
                        day = (int)remainTime.TotalDays;
                        remainDays = day;
                        return day;
                    }
                    else
                    {
                        remainDays = -1;
                        MessageBox.Show("电脑不符合，无法登陆，请联系管理员");
                    }

                }
                catch
                {
                    MessageBox.Show("错误：解析授权失败");
                    return -1;
                }
            }

            return -1;
        }

        public static string Encrypt(string pToEncrypt, string sKey)//加密
        {
            System.Security.Cryptography.DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = Encoding.Default.GetBytes(pToEncrypt);
            des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                ret.AppendFormat("{0:X2}", b);
            }
            ret.ToString();
            return ret.ToString();

        }
        public static string Decrypt(string pToDecrypt, string sKey)//解密
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();

            byte[] inputByteArray = new byte[pToDecrypt.Length / 2];
            for (int x = 0; x < pToDecrypt.Length / 2; x++)
            {
                int i = (Convert.ToInt32(pToDecrypt.Substring(x * 2, 2), 16));
                inputByteArray[x] = (byte)i;
            }

            des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();

            StringBuilder ret = new StringBuilder();

            return System.Text.Encoding.Default.GetString(ms.ToArray());
        }

        public static bool CertifyCDK(string CDK)//验证CDK
        {
            //string testCDK = Encrypt(FeatureCode+":150", KEY);

            try
            {
                string middle = Decrypt(CDK, KEY);//解密CDK
                string[] sArray = Regex.Split(middle, ":", RegexOptions.IgnoreCase);
                uint day = uint.Parse(sArray[1]);
                if (sArray[0] == FeatureCode)//验证成功
                {
                    MessageBox.Show("激活成功！欢迎使用！");
                    DataService.UpdataPer(FeatureCode,day);//更新授权表数据
                    if (ControCenter.FirstUse == true)
                    {
                        employeeInfo emp = new employeeInfo();
                        emp.Name = "1";
                        emp.Password = "1";
                        emp.Type = "管理员";
                        MessageBox.Show("初始用户名：1，密码：1  登陆后请自行修改密码");
                        DataService.AddEmployee(emp);
                    }
                    return true;
                }
                    
                else
                    return false;
            }
            catch
            {
                return false;
            }
         


        }

        public static string GetFeatureCode()//计算特征码
        {
            string code = CpuId;
            try
            {
                FeatureCode = Encrypt(CpuId, KEY);

            }
            catch
            {
                MessageBox.Show("获取序列号失败，请联系销售人员");
            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
            return FeatureCode;
        }

        public static string  GetCpuDeskId()
        {
                string cpuInfo = "";//cpu序列号 
                ManagementClass mc = new ManagementClass("Win32_Processor");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    cpuInfo = mo.Properties["ProcessorId"].Value.ToString();
                }
                CpuId = cpuInfo;
               /* string deskInfo = "";//desk序列号 
                ManagementClass mc1 = new ManagementClass("Win32_DiskDrive");
                ManagementObjectCollection moc1 = mc.GetInstances();
                foreach (ManagementObject mo1 in moc1)
                {
                    deskInfo = mo1.Properties["ProcessorId"].Value.ToString();
                }
                HdId = cpuInfo;
                return cpuInfo + ";" + deskInfo;*/
                return cpuInfo;
        }
        public static void LoadObjData()
        {
            ObjInfoData = DataService.GetALLObjInfo();


        }

        public static void GetDataOfExcel(string path)
        {
            ds = DataService.OpenExcelToDs(path);
            
        }

        public static string SelectPath()
        {
            string path = string.Empty;
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog(); ;
            var result = openFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                path = openFileDialog.FileName;
            }
            return path;
        }

        public static bool ReissueCard(VipInfo vip, string NewCard)
        {
            if (vip.ConnectCarNum != null)
            {
                if (DataService.ChangeCardStatus(vip.ConnectCarNum, SentCardInfo.CardStatus.废弃) > 0)
                {

                    if (DataService.GetVipId(NewCard) > 0)
                    {
                        MessageBox.Show("已存在关联vip");
                        return false;
                    }
                    else if (DataService.GetCardInfoAct(NewCard) == null)
                    {
                        MessageBox.Show("此卡未发");
                        return false;
                    }
                    else if (DataService.ChangeVipConnCard(NewCard, vip) > 0)
                    {
                        return true;
                    }
                    else return false;
                 
                }
                else return false;
            }
            else return false;
        }
        public static bool CancelLoss(string CardNum, VipInfo vip)
        {
            if (DataService.GetVipId(CardNum) == uint.Parse(vip.VipId))
            {
                if (DataService.ChangeCardStatus(CardNum, SentCardInfo.CardStatus.活动) > 0)
                    return true;
                else return false;
            }
            else
                return false;
        }
        public static bool ReportLoss(string CardNum, VipInfo vip)
        {
            if (DataService.GetVipId(CardNum) == uint.Parse(vip.VipId))
            {
                if (DataService.ChangeCardStatus(CardNum, SentCardInfo.CardStatus.挂失) > 0)
                    return true;
                else return false;
            }
            else
                return false;
        }
        public static string GetCardStatus(string CardNum)
        {
            return DataService.GetCardStatus(CardNum);
        }
        public static List<VipInfo> SearchVipInfo(string name, string phone)
        {
            return DataService.SearchVipInfo(name, phone);
        }
        public static List<VipInfo> SearchVipInfo(string name, string phone,string CardNum)
        {
            return DataService.SearchVipInfo(name, phone, CardNum);
        }

        public static List<VipInfo> SearchAllVipInfo()
        {
            return DataService.SearchAllVipInfo();
        }
        public static bool AddNewViper(VipInfo vip, string CardNum)
        {
            if(DataService.GetVipId(CardNum) > 0 || DataService.GetVipIdFromVipInfo(CardNum) > 0)
            {
                MessageBox.Show("已存在关联vip或vip已关联此卡");
                return false;
            }
            else if(DataService.GetCardInfoAct(CardNum) == null)
            {
                MessageBox.Show("此卡未发");
                return false;
            }
            else
            {
                if (vip.Name == "" || vip.Phone == "")
                {
                    MessageBox.Show("信息不全");
                    return false;
                }
                if (DataService.AddNewVip(vip, CardNum) > 0)
                    return true;
                else return false;
            }
        }

        public static bool VerifyCard(string CardNum)//验证是否允许发这张卡号
        {
            if(DataService.GetCardInfoAct(CardNum) == null)
            {
                return true;
            }
            return false;
        }

        public static VipInfo SearchVipInfo(string CardNum,VipInfo vipinfo)
        {
            uint VipId = DataService.GetVipId(CardNum);
            vipinfo = DataService.GetVipInfo(VipId, vipinfo);
            return vipinfo;
        }
        public static bool Consume (string CardNum, uint ConsBalance )
        {
            return DataService.Consume(CardNum,ConsBalance);
        }
        public static string GetCardBalanceNum(string CardNum)
        {
            return DataService.GetCardBalance(CardNum);
        }
        public static bool TopIn(string CardNum, uint TopInBalance)
        {
            return DataService.TopIn(CardNum, TopInBalance);
        }
        public static uint GetTopInFreeNum(uint balance)
        {
            if(NowPrivilege == null)
                NowPrivilege = DataService.GetPriInfo();
            uint FreeNum = (balance - (balance % NowPrivilege.BuyN)) / NowPrivilege.BuyN * NowPrivilege.FreeN;
            return FreeNum;
        }


        public static bool SentNewCard(string CardNum)
        {
            if (CardNum != "未读取到卡号")
            {
                if (VerifyCard(CardNum))
                {
                    if (DataService.SentNewCard(CardNum))
                        return true;
                    else
                        return false;
                }
                else return false;
            }
            else return false;
        }

        /*public void SellCommodity(Commodity type, uint CommodityNum)
        {
            //在这里获取会员Id
            Viper vip = new Viper(123);
            float CollectMoney = type.CountMoney(CommodityNum);
            //data.SellCommodity(adminId,CommodityType,CommodityNum,CommodityType.pri.type,CollectMoney)
            //data.CollectMoney(CollectMoney)
            NowLogAdmin.SellCommodity(vip,type, CommodityNum);
        }*/
        public static bool LogIn(string LogName,string LogPassword)
        {
            employeeInfo employee = DataService.LoginEmployee(LogName, LogPassword);
            if (employee.Name != null)
            {
                NowLogName = employee.Name.ToString();
                NowLogType = employee.Type.ToString();
                return true;
            }
            else return false;
        }



        public void ChangeViperPassword(Viper People, uint Password)
        {   //if failed ,throw error message;
            NowLogAdmin.ChangeViperPassword(People, Password);
        }

        public void ReportLoss(uint VipId )
        {   //if failed ,throw error message;
            //data.reportLoss
        }






    }

    public class Viper
    {
        public int VipId;
        public string name;
        public uint balance;

       public Viper(int Id)
        {
            //data.SearchVip(Id)
        }

        /*public void Consume(Commodity CdType, uint CdNumber)//消费
        {
            //
            //Tell admin to comsume
            //data.addComsume(Vipid,name,CdType,CdNumber,manager.NowLogID); 
        }*/

        
    }



    public class admin
    {
        public string Name;
        public uint Id;
        //public table OperationRecord;操作记录

        public admin(string AdminName)
        {
            Name = AdminName;
        }

        public void TopIn(Viper People, uint TopInBalance)
        {
            // 增加admin个人的操作记录
        }

        public void  ChangeViperPassword(Viper People, uint Password)
        {
            //确定要增加每张卡的交易密码？
        }

       
        public void CollectMoney(float Balance)//收钱
        {
            //增加admin个人的操作记录
            
        }
        /*public void SellCommodity(Viper Vip,Commodity type, uint CommodityNum)
        {

            //增加admin个人的操作记录
        }*/

        public void NewCard(uint Id,string name, string phone, string sex)
        {
            //增加admin个人的操作记录
        }
    }


    public class Boss:admin
    {

        public string BossName;
        public uint BossId;
        public Boss(string name) : base(name)
        {
            BossName = name;

        }

        public void ChangeAdminPassword(admin Id)
        {
            //data.ChangeAdminPassword(admin Id)
        }

        public void AddAdminCount()
        {
            //data.AddAdminCount();
        }
    }
    /*public class Commodity//商品类
    {

        public string Name;
        public uint CommodityId;
        public float Price;
        public privilege Pri;
        public float PriMoney, ShouldMoney;

        public float CountMoney(uint Num)//计算商品总价
        {
            ShouldMoney = Price * Num;
            if (this.Pri.type == PriType.BuyNFreeN && Num > Pri.BuyN)
            {
                uint FreeNum = (Num - Num % Pri.BuyN) / Pri.BuyN * Pri.FreeN;
                ShouldMoney = (Num + FreeNum) * Price;
                PriMoney = Num * Price;
                return PriMoney;
            }
            else if (this.Pri.type == PriType.BuyNDisN && Num > Pri.BuyN)
            {
                PriMoney = Num * Price * this.Pri.discount;
                return PriMoney;
            }
            else if (this.Pri.type == PriType.Discount)
            {
                PriMoney = Num * Price * this.Pri.discount;
                return PriMoney;
            }
            else
            {
                return ShouldMoney;
            }
        }


    }*/

    public enum AdminType { 雇员, 老板 };



   
}
