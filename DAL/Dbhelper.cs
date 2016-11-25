using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace SysCard.DAL
{
    public abstract class Dbhelper
    {


        private static OleDbConnection connection;
        private static OleDbCommand command;
        private static OleDbDataReader reader;

        /**/
        /// <summary>
        /// 获得连接对象
        /// </summary>
        /// <returns></returns>
        /// 
        public static void OpenConnect()
        {
            connection = GetOleDbConnection();
            if(connection.State == ConnectionState.Open)
            {

            }
            else
            {
                connection.Open();
            }
        }
        public static OleDbConnection GetOleDbConnection()
        {
            string connstr = System.Configuration.ConfigurationManager.ConnectionStrings["connstr"].ToString();//从配置文件读取dat.mdb所在文件地址
                                                                                                               //string connstr = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = dat.mdb; Persist Security Info = False";
            if (connection == null)
            {
                connection = new OleDbConnection(connstr);
            }
            else
            {
                
            }
            return connection;
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

            if(command == null)
            {
                command = new OleDbCommand(cmdText, connection);
            }
            else
            {
                command.Dispose();
                command = new OleDbCommand(cmdText, connection);
            }

            try
            {
                int val = command.ExecuteNonQuery();
                //connection.Close();
                return val;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
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
            if (command == null)
            {
                command = new OleDbCommand(cmdText, connection);
            }
            else
            {
                command.Dispose();
                command = new OleDbCommand(cmdText, connection);
            }
            
            if(reader != null) reader.Close();
            try
            {
                
                reader = command.ExecuteReader();
                command.Parameters.Clear();

                return reader;
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
            }
            return null;
        }
    }
}
