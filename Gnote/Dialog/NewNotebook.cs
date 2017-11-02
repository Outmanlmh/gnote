using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gnote.Controller;

namespace Gnote.Dialog
{
    public partial class NewNotebook : Form
    {
        public NewNotebook()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxNotebook.Text == "")
            {
                MessageBox.Show("笔记本名不能为空！");
            }
            else
            {
                try
                {
                    //实例化notebook对象
                    Notebook notebook = new Notebook();
                    //创建笔记本
                    notebook.createNotebook(textBoxNotebook.Text);
                    MessageBox.Show("新建成功");
                }
                catch (Exception)
                {
                    MessageBox.Show("新建失败");
                }
                finally
                {
                    //关闭窗口
                    this.Close();
                }
            }
            
        }
        /// <summary>
        /// 取消新建笔记本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
