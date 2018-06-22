namespace FileStreamDemo
{
    partial class FormFileStreamDemo
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
            this.Rbt_One = new System.Windows.Forms.RadioButton();
            this.Rbt_Two = new System.Windows.Forms.RadioButton();
            this.Rbt_Three = new System.Windows.Forms.RadioButton();
            this.Btn_Write = new System.Windows.Forms.Button();
            this.Btn_Read = new System.Windows.Forms.Button();
            this.GroupBoxOne = new System.Windows.Forms.GroupBox();
            this.Tb_One = new System.Windows.Forms.TextBox();
            this.GroupBoxOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rbt_One
            // 
            this.Rbt_One.AutoSize = true;
            this.Rbt_One.Location = new System.Drawing.Point(58, 17);
            this.Rbt_One.Name = "Rbt_One";
            this.Rbt_One.Size = new System.Drawing.Size(95, 16);
            this.Rbt_One.TabIndex = 0;
            this.Rbt_One.TabStop = true;
            this.Rbt_One.Text = "FileStream类";
            this.Rbt_One.UseVisualStyleBackColor = true;
            // 
            // Rbt_Two
            // 
            this.Rbt_Two.AutoSize = true;
            this.Rbt_Two.Location = new System.Drawing.Point(214, 17);
            this.Rbt_Two.Name = "Rbt_Two";
            this.Rbt_Two.Size = new System.Drawing.Size(107, 16);
            this.Rbt_Two.TabIndex = 1;
            this.Rbt_Two.TabStop = true;
            this.Rbt_Two.Text = "BinaryWriter类";
            this.Rbt_Two.UseVisualStyleBackColor = true;
            // 
            // Rbt_Three
            // 
            this.Rbt_Three.AutoSize = true;
            this.Rbt_Three.Location = new System.Drawing.Point(370, 17);
            this.Rbt_Three.Name = "Rbt_Three";
            this.Rbt_Three.Size = new System.Drawing.Size(107, 16);
            this.Rbt_Three.TabIndex = 2;
            this.Rbt_Three.TabStop = true;
            this.Rbt_Three.Text = "StreamWriter类";
            this.Rbt_Three.UseVisualStyleBackColor = true;
            // 
            // Btn_Write
            // 
            this.Btn_Write.Location = new System.Drawing.Point(258, 467);
            this.Btn_Write.Name = "Btn_Write";
            this.Btn_Write.Size = new System.Drawing.Size(75, 23);
            this.Btn_Write.TabIndex = 3;
            this.Btn_Write.Text = "写入文件";
            this.Btn_Write.UseVisualStyleBackColor = true;
            this.Btn_Write.Click += new System.EventHandler(this.Btn_Write_Click);
            // 
            // Btn_Read
            // 
            this.Btn_Read.Location = new System.Drawing.Point(423, 467);
            this.Btn_Read.Name = "Btn_Read";
            this.Btn_Read.Size = new System.Drawing.Size(75, 23);
            this.Btn_Read.TabIndex = 4;
            this.Btn_Read.Text = "读取文件";
            this.Btn_Read.UseVisualStyleBackColor = true;
            this.Btn_Read.Click += new System.EventHandler(this.Btn_Read_Click);
            // 
            // GroupBoxOne
            // 
            this.GroupBoxOne.Controls.Add(this.Rbt_Three);
            this.GroupBoxOne.Controls.Add(this.Rbt_Two);
            this.GroupBoxOne.Controls.Add(this.Rbt_One);
            this.GroupBoxOne.Location = new System.Drawing.Point(110, 393);
            this.GroupBoxOne.Name = "GroupBoxOne";
            this.GroupBoxOne.Size = new System.Drawing.Size(525, 45);
            this.GroupBoxOne.TabIndex = 5;
            this.GroupBoxOne.TabStop = false;
            // 
            // Tb_One
            // 
            this.Tb_One.Location = new System.Drawing.Point(12, 12);
            this.Tb_One.Multiline = true;
            this.Tb_One.Name = "Tb_One";
            this.Tb_One.Size = new System.Drawing.Size(760, 375);
            this.Tb_One.TabIndex = 6;
            // 
            // FormFileStreamDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Tb_One);
            this.Controls.Add(this.GroupBoxOne);
            this.Controls.Add(this.Btn_Read);
            this.Controls.Add(this.Btn_Write);
            this.Name = "FormFileStreamDemo";
            this.Text = "FileStream";
            this.GroupBoxOne.ResumeLayout(false);
            this.GroupBoxOne.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Rbt_One;
        private System.Windows.Forms.RadioButton Rbt_Two;
        private System.Windows.Forms.RadioButton Rbt_Three;
        private System.Windows.Forms.Button Btn_Write;
        private System.Windows.Forms.Button Btn_Read;
        private System.Windows.Forms.GroupBox GroupBoxOne;
        private System.Windows.Forms.TextBox Tb_One;
    }
}

