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
    public partial class FormMouseDrawLine : Form
    {
        Graphics graphics;
        int LineStartX = 0;
        int LineStartY = 0;
        bool blDrawLine = false;

        public FormMouseDrawLine()
        {
            InitializeComponent();
            graphics = this.Pb_Draw.CreateGraphics();//创建绘画对象
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Pb_Draw.Refresh();
        }

        private void Pb_Draw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                LineStartX = e.X;
                LineStartY = e.Y;
                blDrawLine = true;
            }
        }

        private void Pb_Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (blDrawLine)
            {
                Pen penDraw = new Pen(Color.Blue, 2);
                graphics.DrawLine(penDraw, LineStartX, LineStartY, e.X, e.Y);
                LineStartX = e.X;
                LineStartY = e.Y;
            }
        }

        private void Pb_Draw_MouseUp(object sender, MouseEventArgs e)
        {
            blDrawLine = false;
        }
    }
}