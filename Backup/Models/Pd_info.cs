using System;
using System.Collections.Generic;
using System.Text;

namespace SysCard.Models
{
    public class Pd_info
    {
        private int pdid;

        public int Pdid
        {
            get { return pdid; }
            set { pdid = value; }
        }
        private string pdname;

        public string Pdname
        {
            get { return pdname; }
            set { pdname = value; }
        }
    }
}
