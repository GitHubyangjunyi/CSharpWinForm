using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintDocumentDemo
{
    public partial class FormPrintDocumentDemo : Form
    {
        public FormPrintDocumentDemo()
        {
            InitializeComponent();
        }
    }
}
//在C#中包含了5个打印组件
//PrintDocument:设置属性,这些属性说明在基于Windows中应用程序要打印什么内容以及打印文档的能力
//PrintPreviewDialog:一个预先配置的对话框,用于显示文档打印后的外观
//PrintDialog:一个预先配置的对话框,用于选择一台打印机,并选择文档中要打印的内容及其他与打印相关的设置
//PrintPreviewControl:用于按文档打印时的外观显示PrintDocument,该控件没有按钮或其他用户界面元素,只用在需要自己编写预览界面使用
//PrintSetupDialog:一个预先配置的页面对话框,用在基于Windows的应用程序中设置页面信息,以便打印
//                 这个组件允许用户更改与页面相关的打印设置,包括纸张大小/纸张方向/页边距及打印机选择等