﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQDemo
{
    public partial class FormLINQDemo : Form
    {
        public FormLINQDemo()
        {
            InitializeComponent();
        }
    }
}
// ______________________________LINQ的体系结构_____________________________________
//|                                                                                 |
//|              ____          ____          __________                             |
//|             | C# |        | VB |        | 其他语言 |                            |
//|             |____|        |____|        |__________|                            |
//|  _____________________________________________________________________________  |
//| |                       .NET语言集成查询LING                                  | |
//| |_____________________________________________________________________________| |
//|  _____________________________________________________________________________  |
//| |                         支持LING的数据源                                    | |
//| |                 ______________________________                              | |
//| |                |      启用LING的ADO.NET       |                             | |
//| |    __________  |  __________     __________   |    __________               | |
//| |   |  LINQ    | | |   LINQ   |   |   LINQ   |  |   |  LINQ    |              | |
//| |   |to object | | |to DataSet|   |  to SQL  |  |   | to XML   |              | |
//| |    ----|-----  |  ----------     ----------   |    ----|-----               | |
//| |        |       |______________|_______________|        |                    | |
//| |        |                      |                        |                    | |
//| |________|______________________|________________________|____________________| |
//|          |                      |                        |                      |
//|          |                      |                        |                      |
//|         对象                  关系                      XML                     |
//|                                                                                 |
//|_________________________________________________________________________________|
//
//LINQ是Language Integrated Query的缩写,全称是基于关系数据的.NET语言集成查询
//LINQ采用类似于SQL的句法,句法结构是以from子句开始,以select或者group子句结束
//from子句可以跟0个或多个from或where子句,每个from子句都是一个产生器
//它引入迭代变量在序列上搜索,每个where子句是一个过滤器,它从结果中排除一些数据
//最后的select或者group子句指定了迭代变量得出的结果的外形
//另外,select或者group子句之前可以有一个order by子句,用于指定返回结果的排序