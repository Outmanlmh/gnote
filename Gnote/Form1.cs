using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gnote.Dialog;
using Gnote.Model;

namespace Gnote
{
    public partial class Gnote : Form
    {
        public Gnote()
        {
            InitializeComponent();
           
            
        }

        /// <summary>
        /// 点击搜索按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_Click(object sender, EventArgs e)
        {
            NotebookModel n = new NotebookModel();
            string a = n.notebook_list();
        }
        /// <summary>
        /// 新建笔记本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewNotebook_Click(object sender, EventArgs e)
        {
            NewNotebook NewNotebook = new NewNotebook();
            NewNotebook.Show();
        }


    }
}
