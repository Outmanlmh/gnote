using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using Gnote.Interface;

namespace Gnote.Controller
{
    class Notebook : INotebook
    {
        private string _notebookName;       //笔记本名

        public string NotebookName
        {
            get { return _notebookName; }
            set { _notebookName = value; }
        }
        /// <summary>
        /// 创建笔记本
        /// </summary>
        /// <param name="notebookName">笔记本名</param>
        public void createNotebook(string notebookName)
        {
            string MysqlConnectString = "Server=localhost;Database=gnote;Uid=root;Pwd=root";
            MySqlConnection connection = new MySqlConnection(MysqlConnectString);
            MySqlCommand cmd;
            connection.Open();
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO notebook (notebook_name) VALUE (@name)";
                cmd.Parameters.AddWithValue("@name", notebookName);
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

        /// <summary>
        /// 删除笔记本
        /// </summary>
        /// <param name="notebookNo"></param>
        public void deleteNotebook(int notebookNo)
        {

        }
    }
}
