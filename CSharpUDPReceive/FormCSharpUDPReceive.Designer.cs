namespace CSharpUDPReceive
{
    partial class FormCSharpUDPReceive
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
            this.Btn_Receive = new System.Windows.Forms.Button();
            this.Lb_Receive = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Btn_Receive
            // 
            this.Btn_Receive.Location = new System.Drawing.Point(325, 400);
            this.Btn_Receive.Name = "Btn_Receive";
            this.Btn_Receive.Size = new System.Drawing.Size(75, 23);
            this.Btn_Receive.TabIndex = 1;
            this.Btn_Receive.Text = "Receive";
            this.Btn_Receive.UseVisualStyleBackColor = true;
            this.Btn_Receive.Click += new System.EventHandler(this.Btn_Receive_Click);
            // 
            // Lb_Receive
            // 
            this.Lb_Receive.FormattingEnabled = true;
            this.Lb_Receive.ItemHeight = 12;
            this.Lb_Receive.Location = new System.Drawing.Point(12, 12);
            this.Lb_Receive.Name = "Lb_Receive";
            this.Lb_Receive.Size = new System.Drawing.Size(760, 340);
            this.Lb_Receive.TabIndex = 2;
            // 
            // FormCSharpUDPReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Lb_Receive);
            this.Controls.Add(this.Btn_Receive);
            this.Name = "FormCSharpUDPReceive";
            this.Text = "CSharpUDPReceive";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCSharpUDPReceive_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Receive;
        private System.Windows.Forms.ListBox Lb_Receive;
    }
}

