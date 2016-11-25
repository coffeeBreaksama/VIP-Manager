﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysCard.DAL;
using SysCard.Models;
using SysCard.DAL.Waiter;
using SysCard.DAL.Manager;
using SysCard.DAL.Data;
namespace SysCard.DAL.Waiter
{

    public class waiter
    {

        public static void ReissueCard(VipInfo vip, string NewCard)
        {
            if(ControCenter.ReissueCard(vip,NewCard))
            {
                MessageBox.Show("成功");
            }
        }

        public static void CancelLoss(string CardNum, VipInfo vip)
        {
            if (ControCenter.CancelLoss(CardNum, vip))
            {
                MessageBox.Show("成功");
            }
            else
                MessageBox.Show("失败");
        }
        public static void ReportLoss(string CardNum, VipInfo vip)
        {
            if (ControCenter.ReportLoss(CardNum, vip))
            {
                MessageBox.Show("成功");
            }
            else
                MessageBox.Show("失败");
        }
        public static Form ProjectForm;//程序主窗口,类似于线程概念，关闭他就是关闭所有窗体
        public static string GetCardStatus(string CardNum)
        {
            return DataService.GetCardStatus(CardNum);
        }
        public static void RunSearchVip()
        {
            Form_SearchVip SearchVip = new Form_SearchVip();
            Port.OpenPort();
        }
        public static List<VipInfo> SearchVipInfo(string name, string phone, string CardNum)
        {
            return ControCenter.SearchVipInfo(name, phone, CardNum);
        }
        public static List<VipInfo> SearchVipInfo(string name, string phone)
        {
            return ControCenter.SearchVipInfo(name, phone);
        }

        public static List<VipInfo> SearchAllVipInfo()
        {
            return ControCenter.SearchAllVipInfo();
        }
        public static void RunAddNewVip()
        {
            Form_NewVip TopIn = new Form_NewVip();
            Port.OpenPort();
        }
        public static void AddNewViper(VipInfo vip, string CardNum)
        {
            if(ControCenter.AddNewViper(vip,CardNum))
            {
                MessageBox.Show("成功");
            }
        }
        public static VipInfo SearchVipInfo(string CardNum,VipInfo vip)
        {
            if (CardNum != "未读取到卡号")
            {
                vip = ControCenter.SearchVipInfo(CardNum, vip);
            }
            return vip;
        }
        public static void Consume(string CardNum, string balance, Form form)
        {
            if (ControCenter.Consume(CardNum, uint.Parse(balance.ToString())) == true)
            {
                MessageBox.Show("成功");
                form.Close();
            }
            else MessageBox.Show("失败");
        }
        public static string GetTopInFreeNum(string balance)
        {
            uint FreeN;
            if (balance != "")
            {
                FreeN = uint.Parse(balance);
                return ControCenter.GetTopInFreeNum(FreeN).ToString();
            }
            else return "";
        }
        public static string GetCardBalanceNum(string CardNum)
        {
            if (CardNum != null)
                return ControCenter.GetCardBalanceNum(CardNum);
            else return "";
        }

        public static void TopIn(string CardNum, string balance,Form form)
        {
            if (balance != "")
            {
                if (ControCenter.TopIn(CardNum, uint.Parse(balance.ToString()) + uint.Parse(GetTopInFreeNum(balance))) == true)
                {
                    MessageBox.Show("成功");
                    form.Close();
                }
                else MessageBox.Show("失败");
            }
            else MessageBox.Show("失败");
        }
        public static void RunTopIn()
        {
            Form_TopIn TopIn = new Form_TopIn();
            Port.OpenPort();
        }
        public static void RunConsu()
        {
            Form_Consu Consu = new Form_Consu();
            Port.OpenPort();
        }
        public static void SentNewCard(string CardNum)
        {
            if (ControCenter.SentNewCard(CardNum)) MessageBox.Show("发卡成功");
            else MessageBox.Show("发卡失败");
        }
        public static void EndProgram()//关闭程序
        {
            ProjectForm.Close();
        }
        public static void StartLog(Form init)
        {
            ProjectForm = init;
            if (!DataService.VerifyConn())
            {
                MessageBox.Show("数据连接失败！");
                init.Close();
            }
            else
            {
                init.Visible = false;
                Form_log Log = new Form_log();                
            }
        }
        public static string GetPortCardNum()
        {
            if (Port.GetCardNum() == null)
                return "未读取到卡号";
            else return Port.GetCardNum();
        }
        public static void RunSearchCard()
        {
            Form_SearchCard searchCard = new Form_SearchCard();
            Port.OpenPort();//TODO 把OpenOprt 和 OpenConnect 放在初始化里，结束的时候统一关闭；
        }
        public static void RunNewCard()
        {
            Form_NewCard newCard = new Form_NewCard();
            Port.OpenPort();
        }
        public void IntService()
        {

        }
        public void GetCalendar()
        {

        }
        public void TopUp()
        {

        }
        public void ShiftChange()
        {

        }
        public static void Log(string LogName, string LogPassword, AdminType LogType, Form_log log)
        {
            if (ControCenter.LogIn(LogName, LogPassword, LogType))
            {
                log.Visible = false;
                Form_main f = new Form_main();
                f.ShowDialog();

            }
            else
                MessageBox.Show("密码错误！");
        }
        

    }
}