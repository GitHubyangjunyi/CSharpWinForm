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
    public partial class FormFileStreamDemo : Form
    {
        public FormFileStreamDemo()
        {
            InitializeComponent();
        }
    }
}
//文件是指在各种存储介质上永久保存的数据的有序集合,并以一个具体的名称与此集合相对应,是文件进行读写操作的基本对象
//流是字节序列的抽象概念,如文件/输入输出设备/内部进程通信管道/TCP/IP套接字等,流提供一种对后续存储器写入或读取字节的方式