using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIDemo
{
    public partial class FormGDIDemo : Form
    {
        public FormGDIDemo()
        {
            InitializeComponent();
        }

        //颜色系统,在GDI+中,141种颜色封装在Color结构中
        Color red = Color.Red;//纯红色
        Color green = Color.FromArgb(0, 255, 0);//纯绿色
        Color blue = Color.FromArgb(0, 0, 0xff);//纯蓝色
        Color alphaBlue = Color.FromArgb(128,0, 0, 0xff);//半透明蓝色
        //坐标系统
        static Point startPoi = new Point(300, 100);
        static Point endPoi = new Point(200, 200);

        Point[] pointsOne = 
        {   new Point(210, 20),
            new Point(160, 130),
            new Point(260, 130)
        };

        Point[] pointsTwo = 
        {   new Point(70, 20),
            new Point(20, 130),
            new Point(120, 130)
        };

        Point[] pointsCurve = 
        {   new Point(20, 140),
            new Point(60, 10),
            new Point(100, 130),
            new Point(140, 20),
            new Point(180, 130),
            new Point(220, 30),
            new Point(260, 120)
        };
        //GDI+使用Size表示一个尺寸,Size结构包含高度和宽度两个参数
        static Size size = new Size(150, 300);
        //Rectangle结构
        Rectangle rectangleOne = new Rectangle(400, 20, 150, 300);//这种指定矩形左上角的X和Y坐标以及矩形的宽和高
        Rectangle rectangleTwo = new Rectangle(startPoi, size);
        //画笔,用于绘制线条或空心图形
        Pen blakPenOne = new Pen(Color.Black);//默认一个像素
        Pen redPenFive = new Pen(Color.Red, 5);
        //画刷
        static SolidBrush solidBrushBlue = new SolidBrush(Color.Blue);
        //从画刷实例化画笔
        Pen penFromSolidBrush = new Pen(solidBrushBlue,1);

        private void FormGDIDemo_Paint(object sender, PaintEventArgs e)
        {
            //1.在窗体或控件的Paint事件中直接引用,该事件参数中包含了当前窗体或控件的Graphics对象
            Graphics paintGraphics = e.Graphics;//在为窗体或控件编写绘图代码时,一般使用此方法获取图形对象的引用
            //2.调用窗体或控件的CreateGraphics获得对Graphics对象的引用
            Graphics createGraphics = this.CreateGraphics();
            //3.调用Graphics类的FromImage静态方法,从继承自图像的任何对象创建Graphics对象,常用于更改已经存在的图像
            //Bitmap bitmap = new Bitmap(@"C:\");
            //Graphics gb = Graphics.FromImage(bitmap);
            //或者
            //Image img = Image.FromFile(@"C:\");
            //Graphics gi = Graphics.FromImage(img);
            //由于图像对象占用较多的资源,当不再使用这些对象时应该使用Dispose()方法释放资源
            paintGraphics.DrawLine(redPenFive, startPoi, endPoi);
            paintGraphics.FillPolygon(solidBrushBlue, pointsOne);
            createGraphics.DrawPolygon(redPenFive, pointsTwo);
            //绘制曲线
            createGraphics.DrawCurve(blakPenOne, pointsCurve, 0.6f);
            //绘制矩形
            createGraphics.FillRectangle(solidBrushBlue, rectangleOne);
            createGraphics.DrawRectangle(blakPenOne, rectangleTwo);
        }
    }
}
// _____________________________GDI+体系结构___________________________________
//|  ____________________________________________________    _______________   |
//| |                      Microsoft.NET框架             |  |   Win32(C++)  |  |
//| |____________________________________________________|  |_______________|  |
//|  ________________________________________________________________________  |
//| |                               GDI+引擎                                 | |
//| |    __________    _________      _________                              | |
//| |   | 二维矢量 |  |   图像  |    |   文本  |                             | |
//| |   |   图形   |  |         |    |         |                             | |
//| |    ----------    ---------      ---------                              | |
//| |    __________    ________   ________                                   | |
//| |   |   GDI+   |  |   GDL  | | DirectX|                                  | |
//| |   |          |  |        | |        |                                  | |
//| |    ----------    --------   --------                                   | |
//| |________________________________________________________________________| |
//|                                                                            |
//|  ________________________________________________________________________  |
//| |                              底层驱动程序                              | |
//| |________________________________________________________________________| |
//|____________________________________________________________________________|
//GDI+是GDI的升级版,增加了如渐变画刷Gradient/Brushes/混合画刷/Alpha Blending/图像处理/文本显示等新功能
//颜色是进行图形操作的基本要素,任何一种颜色的表现效果都可以由3个色彩分量和一个透明度参数来确定,每个分量占1B
//R(红色):0-255,255为饱和红色
//G(绿色):0-255,255为饱和绿色
//B(蓝色):0-255,255为饱和蓝色
//A(Alpha值):一种表示颜色的透明度,0-255,0为完全透明,255为完全不透明