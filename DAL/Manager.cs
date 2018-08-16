using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using SysCard.DAL.Waiter;
using SysCard.DAL.Data;
using System.Threading;//用于启用线程类;
using System.IO.Ports;//用于调用串口类函数
using System.Windows.Forms;


namespace SysCard.DAL.Manager//主要的业务逻辑实现控制台
{
    public class ControCenter
    {
        public static uint NowLogId;
        public static string NowLogName;
        public static AdminType NowLogType;
        public static admin NowLogAdmin;
        public static PrivilegeInfo NowPrivilege;
        public static List<ObjInfo> ObjInfoData;
        public static DataSet ds;


        public ControCenter()
        {
            LoadObjData();
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
        public static bool LogIn(string LogName,string LogPassword,AdminType LogType)
        {
            employeeInfo employee = DataService.LoginEmployee(LogName, LogPassword, LogType);
            if (employee.Name != null)
            {
                NowLogName = LogName;
                NowLogType = LogType;
                if (LogType == AdminType.老板)
                {
                    NowLogAdmin = new Boss(LogName);
                }
                else NowLogAdmin = new admin(LogName);
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



    public class Port
    {
        public static Form UsingForm;
        public static string CardNum;
        public static string CardBalance;

        public static string iPort = "COM3"; //默认为串口1

        public static int iRate = 9600; //波特率1200,2400,4800,9600
        public static byte bSize = 8; //8 bits
        public static int iTimeout = 10000; //延时时长
        public static SerialPort serialPort1 = new SerialPort();//定义一个串口类的串口变量
        static string serialReadString = ""; //用于串口接收数据
        public static bool IsCirlce;//判断是否选用循环发送数据
        public static Thread Thd_Send; //开辟一个专用于发送数据的线程        
        public static byte[] recb = new Byte[100];  //用于存放接收数据的数组


        public Port(Form form)
        {
            UsingForm = form;
        }
        public static string GetCardNum()
        {
            
            return CardNum;          
        }

        public static  void ChangePort(string port)
        {
            iPort = port;
        }
        public static string GetCardBalance()
        {
           // OpenPort();
            return CardBalance;
        }

        public static void OpenPort()
        {
            //UsingForm = form;
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            if (iPort.Length != 0)
            {
                Parity myParity = Parity.None;
                StopBits MyStopBits = StopBits.One;

                serialPort1.PortName = iPort;
                serialPort1.BaudRate = iRate;
                serialPort1.DataBits = bSize;
                serialPort1.Parity = myParity;
                serialPort1.StopBits = MyStopBits;
                serialPort1.ReadTimeout = iTimeout;
                try
                {
                    serialPort1.Open();
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);

                    string message = "串口成功开启……\r\n";
                    message = iPort + message;
                    //MessageBox.Show(message);

                }
                catch (UnauthorizedAccessException)
                {
                    string message = "串口开启失败……\r\n串口被占用";
                    message = iPort + message;
                    MessageBox.Show(message);
                }
                catch (System.IO.IOException)
                {
                    string message = "串口开启失败……\r\n不存在的串口！";
                    message = iPort + message;
                    MessageBox.Show(message);
                }
                catch (ArgumentException)
                {
                    string message = "串口开启失败……\r\n无效的串口名称！";
                    message = iPort + message;
                    MessageBox.Show(message);
                }
            }
        }
        private static void sp_DataReceived(object sender, SerialDataReceivedEventArgs e) //接收函数只
        {
            System.Threading.Thread.Sleep(100);

            //延时100ms等待接收完数据
            //this.Invoke就是跨线程访问ui的方法，也是本文的范例
            int i = 0;
            int lenRead;

            try
            {
                lenRead = serialPort1.Read(recb, 0, 100); //读取数据
            }
            catch(System.TimeoutException)
            {
                lenRead = 0;
            }
            for (i = 0; i < lenRead; i++) serialReadString += ((char)recb[i]);

            serialPort1.DiscardInBuffer(); //读完放弃缓冲区里面的数据
            if (lenRead > 0) //说明接到一个完整的数据了
            {
                if (recb[lenRead - 1] == '\0')
                {
                    string m_valRec = "";
                    string m_cardIdRec = "";
                    int len = serialReadString.Length;

                    for (i = 0; i < len; i++)
                    {
                        if (serialReadString[i] != '\n' && serialReadString[i] != ',') m_valRec += serialReadString[i];
                        else break;
                    }
                    i++;
                    for (; i < len; i++)
                    {
                        if (serialReadString[i] != '\n' && serialReadString[i] != ',') m_cardIdRec += serialReadString[i];
                        else break;
                    }

                    serialReadString = ""; //清除接收数据
                    if (m_cardIdRec.Length > 0)
                    {

                                CardBalance = m_valRec;
                                CardNum = m_cardIdRec;
                    }
                    serialReadString = "";
                }
            }
        }
    }
}
