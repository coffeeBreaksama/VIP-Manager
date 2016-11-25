using System;
using System.Collections.Generic;
using System.Text;

namespace SysCard.Models
{
   public class BuyBk
    {
        private int buyid;

        public int Buyid
        {
            get { return buyid; }
            set { buyid = value; }
        }
        private string buyproduct;

        public string Buyproduct
        {
            get { return buyproduct; }
            set { buyproduct = value; }
        }
        private string buyprice;

        public string Buyprice
        {
            get { return buyprice; }
            set { buyprice = value; }
        }
        private string buytime;

        public string Buytime
        {
            get { return buytime; }
            set { buytime = value; }
        }
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        private string buyFrom;

        public string BuyFrom
        {
            get { return buyFrom; }
            set { buyFrom = value; }
        }

    }
}
