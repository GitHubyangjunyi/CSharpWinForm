using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileStreamDemo
{
    public partial class FormCheckFileUsing : Form
    {
        public FormCheckFileUsing()
        {
            InitializeComponent();
        }

        private void Btn_Check_Click(object sender, EventArgs e)
        {
            OpenFileDialog checkFileDialog = new OpenFileDialog();
            checkFileDialog.ShowDialog();
            try
            {
                System.IO.File.Move(checkFileDialog.FileName, checkFileDialog.FileName);
                MessageBox.Show("所选文件未被其他程序使用!");
            }
            catch (Exception)
            {
                MessageBox.Show("所选文件正在被其他程序使用!");
            }
        }
    }
}
//检测原理是利用File对象的Move方法,将待检测的文件在其源文件夹中移动,实际上未移动
//如果能够正常执行,表明该文件正常存在或者未被其他程序使用
//由于是通过对话框指定文件,所以不存在文件不存在的情况
//txt文件好像检测无效