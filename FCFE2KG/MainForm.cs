using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCFE2KG
{
    /// <summary>
    /// 主窗体
    /// </summary>
    public partial class MainForm : Form
    {
        AboutForm abf = null;
        MapForm mapForm = null;

        int picabout = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 程序退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenu_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 打开关于对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pic_fe2_about(object sender, EventArgs e)
        {
            picabout = 1;
            try
            {
                if (abf == null || abf.IsDisposed) abf = new AboutForm();
                abf.Show();
                abf.Focus();
            }
            catch
            {
                abf = new AboutForm();
                abf.Show();
            }
        }

        /// <summary>
        /// 打开地图编辑器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenu_Mapeditor_Click(object sender, EventArgs e)
        {
            try
            {
                if (mapForm == null || mapForm.IsDisposed) mapForm = new MapForm();
                mapForm.Show();
                mapForm.Focus();
            }
            catch
            {
                mapForm = new MapForm();
                mapForm.Show();
            }
        }

        /// <summary>
        /// 单击logo图片事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pic_fe2_Click(object sender, EventArgs e)
        {
            //仅一次
            if (picabout == 0) Pic_fe2_about(sender, e);
        }
    }
}
