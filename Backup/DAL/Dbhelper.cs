using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace SysCard.DAL
{
    public abstract class Dbhelper
    {



        /**/
        /// <summary>
        /// 获得连接对象
        /// </summary>
        /// <returns></returns>
        public static OleDbConnection GetOleDbConnection()
        {
            string connstr = System.Configuration.ConfigurationManager.ConnectionStrings["connstr"].ToString();
            return new OleDbConnection(connstr);
            //\\127.0.0.1\data\data.mdb
            //return new OleDbConnection("\\\\127.0.0.1\\data\\data.mdb");
           // return new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\\\192.168.1.101\\Users\\Public\\data.mdb");
        }

        /// <summary>
        /// 执行语句
        /// </summary>
        /// <param name="cmdText">sql</param>
        /// <returns></returns>

        public static int ExecuteNonQuery(string cmdText)
        {


            using (OleDbConnection connection = GetOleDbConnection())
            {
                OleDbCommand command = new OleDbCommand(cmdText, connection);
                connection.Open();
                try
                {
                    int val = command.ExecuteNonQuery();


                    connection.Close();
                    return val;
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
            }
            return 0;
        }
        /// <summary>
        /// 返回sqldataReader
        /// </summary>
        /// <param name="cmdText">sql语句</param>
        /// <returns></returns>
        public static OleDbDataReader ExecuteReader(string cmdText)
        {
            OleDbConnection connection = GetOleDbConnection();

            OleDbCommand command = new OleDbCommand(cmdText, connection);
            try
            {
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                command.Parameters.Clear();

                return reader;
            }
            catch(Exception e)
            {
                connection.Close();
                Console.Write(e.Message);
            }
            return null;
        }
    }
}
