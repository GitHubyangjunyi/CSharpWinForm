using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpUDPReceive
{
    public partial class FormCSharpUDPReceive : Form
    {
        UdpClient udpClientReceive;
        Thread threadListen;

        public FormCSharpUDPReceive()
        {
            CheckForIllegalCrossThreadCalls = false;//屏蔽异常以跨线程访问控件
            InitializeComponent();
            udpClientReceive = new UdpClient(13579);//将其绑定到提供的本地端口号
        }

        private void Listen()//监听并接收数据
        {
            //定义一个终结点,因为此前创建的UdpClient实例已经和指定端口绑定,所以此处的IP地址和端口可设置或不设置
            IPEndPoint iep = null;
            while (true)
            {
                //获得发送方的数据包并转换为指定字符类型
                string rData = System.Text.Encoding.UTF8.GetString(udpClientReceive.Receive(ref iep));//ref关键字使参数按引用传递
                Lb_Receive.Items.Add(rData);
            }
        }

        private void Btn_Receive_Click(object sender, EventArgs e)
        {
            threadListen = new Thread(new ThreadStart(Listen))
            {
                IsBackground = true//设置为后台线程以便关闭窗体时终止线程
            };
            threadListen.Start();
        }

        private void FormCSharpUDPReceive_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadListen != null)
            {
                threadListen.Abort();//终止线程
            }
        }
    }
}
