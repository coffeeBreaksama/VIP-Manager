using System;
using System.Collections.Generic;
using System.Text;

namespace SysCard.Models
{
   public class ScoInfo1
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string sco;

        public string Sco
        {
            get { return sco; }
            set { sco = value; }
        }
        private string scoHis;

        public string ScoHis
        {
            get { return scoHis; }
            set { scoHis = value; }
        }
        private string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }
    }
}
