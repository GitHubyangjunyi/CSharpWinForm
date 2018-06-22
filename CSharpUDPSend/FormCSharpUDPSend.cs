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

namespace CSharpUDPSend
{
    public partial class FormCSharpUDPSend : Form
    {
        UdpClient udpClientSend;

        public FormCSharpUDPSend()
        {
            InitializeComponent();
            //创建一个未与指定地址或端口绑定的UdpClient实例
            udpClientSend = new UdpClient();
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            byte[] sData = System.Text.Encoding.UTF8.GetBytes(this.Tb_Send.Text);//转换成字节编码
            //向本机的13579端口发送数据方法一
            udpClientSend.Send(sData, sData.Length, Dns.GetHostName(), 13579);
            //方法二需先连接主机然后发送数据
            //udpClientSend.Connect(IPAddress.Parse("127.0.0.1"), 13579);
            //udpClientSend.Send(bData, bData.Length);
        }
    }
}
//UDP用户数据报协议是一种面向无连接的协议,发送方只需要知道对方的IP地址和端口号
//不需要在发送和接收数据前建立远程主机连接就可以发送,UDP无需双方握手,发送方只管发送数据,并不确认对方是否接收
//因为UDP是无连接的传输协议,但可以使用下面方法建立连接
//1.使用远程主机名和端口号来创建UdpClient实例
//2.创建UdpClient类的实例,然后调用Connect()方法