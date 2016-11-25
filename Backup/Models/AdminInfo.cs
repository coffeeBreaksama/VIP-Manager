using System;
using System.Collections.Generic;
using System.Text;

namespace SysCard.Models
{
   public class AdminInfo
    {
        private int adminId;

        public int AdminId
        {
            get { return adminId; }
            set { adminId = value; }
        }
        private string adminname;

        public string Adminname
        {
            get { return adminname; }
            set { adminname = value; }
        }
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string userpwd;

        public string Userpwd
        {
            get { return userpwd; }
            set { userpwd = value; }
        }

    }
}
