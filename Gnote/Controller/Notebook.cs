using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using Gnote.Interface;
using Gnote.Model;

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
            string sql = "INSERT INTO `notebook` (`notebook_name`) VALUES ('"+ notebookName + "')";
            MysqlBase createNotebook = new MysqlBase();
            createNotebook.base_mysql(sql);
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
