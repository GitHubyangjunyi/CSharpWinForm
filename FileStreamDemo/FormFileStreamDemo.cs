using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileStreamDemo
{
    public partial class FormFileStreamDemo : Form
    {
        public FormFileStreamDemo()
        {
            InitializeComponent();
        }

        private void Btn_Write_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog
            {
                Filter = "txt 文件|*.txt|所有文件|*.*",
                AddExtension = true,
                Title = "写文件"
            };//文件保存对话框
            if (Rbt_One.Checked)
            {
                if (sf.ShowDialog()==DialogResult.OK)
                {
                    //实例化文件流并与写入文件相关
                    FileStream fileStream = new FileStream(sf.FileName, FileMode.Create);
                    byte[] data = new UTF8Encoding().GetBytes(this.Tb_One.Text);
                    fileStream.Write(data, 0, data.Length);
                    fileStream.Flush();
                    fileStream.Close();
                }
            }
        }

        private void Btn_Read_Click(object sender, EventArgs e)
        {

        }
    }
}
//文件是指在各种存储介质上永久保存的数据的有序集合,并以一个具体的名称与此集合相对应,是文件进行读写操作的基本对象
//流是字节序列的抽象概念,如文件/输入输出设备/内部进程通信管道/TCP/IP套接字等,流提供一种对后续存储器写入或读取字节的方式