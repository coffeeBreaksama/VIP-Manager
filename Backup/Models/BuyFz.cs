using System;
using System.Collections.Generic;
using System.Text;

namespace SysCard.Models
{
    public class BuyFz
    {
        private string pid;

        public string Pid
        {
            get { return pid; }
            set { pid = value; }
        }
        private string pname;

        public string Pname
        {
            get { return pname; }
            set { pname = value; }
        }
        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        private int num;

        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        private string cardnum;

        public string Cardnum
        {
            get { return cardnum; }
            set { cardnum = value; }
        }
    }
}
