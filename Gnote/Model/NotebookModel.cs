using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gnote.Model
{
    /// <summary>
    /// 关于笔记本的数据库操作
    /// </summary>
    class NotebookModel : BaseConnectionMysql
    {
        /// <summary>
        /// 创建笔记本
        /// </summary>
        /// <param name="notebookname">笔记本名称</param>
        public void create_notebook(string notebookname)
        {
            string sql = "INSERT INTO `notebook` (`notebook_name`) VALUES ('" + notebookname + "')";
            base_mysql(sql);
        }
        public string notebook_list()
        {
            string sql = "SELECT * FROM `notebook`;";
        }
    }
}
