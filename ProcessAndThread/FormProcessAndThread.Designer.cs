namespace ProcessAndThread
{
    partial class FormProcessAndThread
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProcessAndThread));
            this.ProcessOne = new System.Diagnostics.Process();
            this.Btn_StartPowerShellOne = new System.Windows.Forms.Button();
            this.Btn_StartPowerShellTwo = new System.Windows.Forms.Button();
            this.Btn_StopAllThread = new System.Windows.Forms.Button();
            this.Btn_RestartAllThread = new System.Windows.Forms.Button();
            this.LOne = new System.Windows.Forms.Label();
            this.LTwo = new System.Windows.Forms.Label();
            this.LThree = new System.Windows.Forms.Label();
            this.Lable_Convey = new System.Windows.Forms.Label();
            this.Lb_Production = new System.Windows.Forms.ListBox();
            this.Lb_Convey = new System.Windows.Forms.ListBox();
            this.Rtb_ShowCharOne = new System.Windows.Forms.RichTextBox();
            this.Rtb_ShowCharTwo = new System.Windows.Forms.RichTextBox();
            this.Rtb_ShowCharThree = new System.Windows.Forms.RichTextBox();
            this.Btn_StopPowerShell = new System.Windows.Forms.Button();
            this.Tb_CounterOne = new System.Windows.Forms.TextBox();
            this.Tb_CounterTwo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ProcessOne
            // 
            this.ProcessOne.StartInfo.Domain = "";
            this.ProcessOne.StartInfo.FileName = "C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe";
            this.ProcessOne.StartInfo.LoadUserProfile = false;
            this.ProcessOne.StartInfo.Password = null;
            this.ProcessOne.StartInfo.StandardErrorEncoding = null;
            this.ProcessOne.StartInfo.StandardOutputEncoding = null;
            this.ProcessOne.StartInfo.UserName = "";
            this.ProcessOne.SynchronizingObject = this;
            // 
            // Btn_StartPowerShellOne
            // 
            this.Btn_StartPowerShellOne.Location = new System.Drawing.Point(30, 450);
            this.Btn_StartPowerShellOne.Name = "Btn_StartPowerShellOne";
            this.Btn_StartPowerShellOne.Size = new System.Drawing.Size(100, 45);
            this.Btn_StartPowerShellOne.TabIndex = 0;
            this.Btn_StartPowerShellOne.Text = "启动PowerShell方法一";
            this.Btn_StartPowerShellOne.UseVisualStyleBackColor = true;
            this.Btn_StartPowerShellOne.Click += new System.EventHandler(this.Btn_StartPowerShellOne_Click);
            // 
            // Btn_StartPowerShellTwo
            // 
            this.Btn_StartPowerShellTwo.Location = new System.Drawing.Point(137, 450);
            this.Btn_StartPowerShellTwo.Name = "Btn_StartPowerShellTwo";
            this.Btn_StartPowerShellTwo.Size = new System.Drawing.Size(100, 45);
            this.Btn_StartPowerShellTwo.TabIndex = 1;
            this.Btn_StartPowerShellTwo.Text = "启动PowerShell方法二";
            this.Btn_StartPowerShellTwo.UseVisualStyleBackColor = true;
            this.Btn_StartPowerShellTwo.Click += new System.EventHandler(this.Btn_StartPowerShellTwo_Click);
            // 
            // Btn_StopAllThread
            // 
            this.Btn_StopAllThread.Location = new System.Drawing.Point(351, 450);
            this.Btn_StopAllThread.Name = "Btn_StopAllThread";
            this.Btn_StopAllThread.Size = new System.Drawing.Size(100, 45);
            this.Btn_StopAllThread.TabIndex = 2;
            this.Btn_StopAllThread.Text = "终止所有线程\r\n单击后两个数值未必相等";
            this.Btn_StopAllThread.UseVisualStyleBackColor = true;
            this.Btn_StopAllThread.Click += new System.EventHandler(this.Btn_StopAllThread_Click);
            // 
            // Btn_RestartAllThread
            // 
            this.Btn_RestartAllThread.Location = new System.Drawing.Point(458, 450);
            this.Btn_RestartAllThread.Name = "Btn_RestartAllThread";
            this.Btn_RestartAllThread.Size = new System.Drawing.Size(100, 45);
            this.Btn_RestartAllThread.TabIndex = 3;
            this.Btn_RestartAllThread.Text = "重启所有线程";
            this.Btn_RestartAllThread.UseVisualStyleBackColor = true;
            this.Btn_RestartAllThread.Click += new System.EventHandler(this.Btn_RestartAllThread_Click);
            // 
            // LOne
            // 
            this.LOne.AutoSize = true;
            this.LOne.Location = new System.Drawing.Point(12, 27);
            this.LOne.Name = "LOne";
            this.LOne.Size = new System.Drawing.Size(95, 60);
            this.LOne.TabIndex = 4;
            this.LOne.Text = "线程一的计数值:\r\n\r\n\r\n\r\n线程二的计数值:";
            // 
            // LTwo
            // 
            this.LTwo.AutoSize = true;
            this.LTwo.Location = new System.Drawing.Point(287, 15);
            this.LTwo.Name = "LTwo";
            this.LTwo.Size = new System.Drawing.Size(605, 60);
            this.LTwo.TabIndex = 5;
            this.LTwo.Text = resources.GetString("LTwo.Text");
            // 
            // LThree
            // 
            this.LThree.AutoSize = true;
            this.LThree.Location = new System.Drawing.Point(654, 111);
            this.LThree.Name = "LThree";
            this.LThree.Size = new System.Drawing.Size(245, 12);
            this.LThree.TabIndex = 6;
            this.LThree.Text = "生产数量        待装数量        已装数量";
            // 
            // Lable_Convey
            // 
            this.Lable_Convey.AutoSize = true;
            this.Lable_Convey.Location = new System.Drawing.Point(771, 135);
            this.Lable_Convey.Name = "Lable_Convey";
            this.Lable_Convey.Size = new System.Drawing.Size(11, 12);
            this.Lable_Convey.TabIndex = 7;
            this.Lable_Convey.Text = "0";
            // 
            // Lb_Production
            // 
            this.Lb_Production.FormattingEnabled = true;
            this.Lb_Production.ItemHeight = 12;
            this.Lb_Production.Location = new System.Drawing.Point(632, 135);
            this.Lb_Production.Name = "Lb_Production";
            this.Lb_Production.Size = new System.Drawing.Size(100, 244);
            this.Lb_Production.TabIndex = 8;
            // 
            // Lb_Convey
            // 
            this.Lb_Convey.FormattingEnabled = true;
            this.Lb_Convey.ItemHeight = 12;
            this.Lb_Convey.Location = new System.Drawing.Point(822, 135);
            this.Lb_Convey.Name = "Lb_Convey";
            this.Lb_Convey.Size = new System.Drawing.Size(100, 244);
            this.Lb_Convey.TabIndex = 9;
            // 
            // Rtb_ShowCharOne
            // 
            this.Rtb_ShowCharOne.Location = new System.Drawing.Point(30, 135);
            this.Rtb_ShowCharOne.Name = "Rtb_ShowCharOne";
            this.Rtb_ShowCharOne.Size = new System.Drawing.Size(150, 200);
            this.Rtb_ShowCharOne.TabIndex = 10;
            this.Rtb_ShowCharOne.Text = "";
            // 
            // Rtb_ShowCharTwo
            // 
            this.Rtb_ShowCharTwo.Location = new System.Drawing.Point(224, 135);
            this.Rtb_ShowCharTwo.Name = "Rtb_ShowCharTwo";
            this.Rtb_ShowCharTwo.Size = new System.Drawing.Size(150, 200);
            this.Rtb_ShowCharTwo.TabIndex = 11;
            this.Rtb_ShowCharTwo.Text = "";
            // 
            // Rtb_ShowCharThree
            // 
            this.Rtb_ShowCharThree.Location = new System.Drawing.Point(418, 132);
            this.Rtb_ShowCharThree.Name = "Rtb_ShowCharThree";
            this.Rtb_ShowCharThree.Size = new System.Drawing.Size(150, 200);
            this.Rtb_ShowCharThree.TabIndex = 12;
            this.Rtb_ShowCharThree.Text = "";
            // 
            // Btn_StopPowerShell
            // 
            this.Btn_StopPowerShell.Location = new System.Drawing.Point(244, 450);
            this.Btn_StopPowerShell.Name = "Btn_StopPowerShell";
            this.Btn_StopPowerShell.Size = new System.Drawing.Size(100, 45);
            this.Btn_StopPowerShell.TabIndex = 13;
            this.Btn_StopPowerShell.Text = "关闭PowerShell";
            this.Btn_StopPowerShell.UseVisualStyleBackColor = true;
            this.Btn_StopPowerShell.Click += new System.EventHandler(this.Btn_StopPowerShell_Click);
            // 
            // Tb_CounterOne
            // 
            this.Tb_CounterOne.Location = new System.Drawing.Point(113, 24);
            this.Tb_CounterOne.Name = "Tb_CounterOne";
            this.Tb_CounterOne.Size = new System.Drawing.Size(100, 21);
            this.Tb_CounterOne.TabIndex = 14;
            // 
            // Tb_CounterTwo
            // 
            this.Tb_CounterTwo.Location = new System.Drawing.Point(113, 75);
            this.Tb_CounterTwo.Name = "Tb_CounterTwo";
            this.Tb_CounterTwo.Size = new System.Drawing.Size(100, 21);
            this.Tb_CounterTwo.TabIndex = 15;
            // 
            // FormProcessAndThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Tb_CounterTwo);
            this.Controls.Add(this.Tb_CounterOne);
            this.Controls.Add(this.Btn_StopPowerShell);
            this.Controls.Add(this.Rtb_ShowCharThree);
            this.Controls.Add(this.Rtb_ShowCharTwo);
            this.Controls.Add(this.Rtb_ShowCharOne);
            this.Controls.Add(this.Lb_Convey);
            this.Controls.Add(this.Lb_Production);
            this.Controls.Add(this.Lable_Convey);
            this.Controls.Add(this.LThree);
            this.Controls.Add(this.LTwo);
            this.Controls.Add(this.LOne);
            this.Controls.Add(this.Btn_RestartAllThread);
            this.Controls.Add(this.Btn_StopAllThread);
            this.Controls.Add(this.Btn_StartPowerShellTwo);
            this.Controls.Add(this.Btn_StartPowerShellOne);
            this.Name = "FormProcessAndThread";
            this.Text = "ProcessAndThread";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProcessAndThread_FormClosing);
            this.Load += new System.EventHandler(this.FormProcessAndThread_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.Process ProcessOne;
        private System.Windows.Forms.Button Btn_StartPowerShellTwo;
        private System.Windows.Forms.Button Btn_StartPowerShellOne;
        private System.Windows.Forms.Button Btn_StopAllThread;
        private System.Windows.Forms.Button Btn_RestartAllThread;
        private System.Windows.Forms.Label Lable_Convey;
        private System.Windows.Forms.Label LThree;
        private System.Windows.Forms.Label LTwo;
        private System.Windows.Forms.Label LOne;
        private System.Windows.Forms.ListBox Lb_Convey;
        private System.Windows.Forms.ListBox Lb_Production;
        private System.Windows.Forms.RichTextBox Rtb_ShowCharThree;
        private System.Windows.Forms.RichTextBox Rtb_ShowCharTwo;
        private System.Windows.Forms.RichTextBox Rtb_ShowCharOne;
        private System.Windows.Forms.Button Btn_StopPowerShell;
        private System.Windows.Forms.TextBox Tb_CounterTwo;
        private System.Windows.Forms.TextBox Tb_CounterOne;
    }
}

