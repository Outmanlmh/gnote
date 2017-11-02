using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Gnote.Model
{
    /// <summary>
    /// 连接mysql的基类
    /// </summary>
    class BaseConnectionMysql
    {
        /// <summary>
        /// 链接数据库的基础方法
        /// </summary>
        /// <param name="sql">要执行的sql语句</param>
        public void base_mysql(string sql)
        {
            string MysqlConnectString = "Server=localhost;Database=gnote;Uid=root;Pwd=root";
            MySqlConnection connection = new MySqlConnection(MysqlConnectString);
            MySqlCommand cmd;
            connection.Open();
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
