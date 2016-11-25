using System;
using System.Collections.Generic;
using System.Windows.Forms;

using SysCard.DAL.Manager;
using SysCard.DAL.Waiter;
namespace SysCard
{
    static class Program
    {

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            waiter wait = new waiter();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_loading());
            
        }
    }
}