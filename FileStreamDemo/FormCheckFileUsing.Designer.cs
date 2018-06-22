namespace FileStreamDemo
{
    partial class FormCheckFileUsing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Check = new System.Windows.Forms.Button();
            this.L_Check = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Check
            // 
            this.Btn_Check.Location = new System.Drawing.Point(310, 310);
            this.Btn_Check.Name = "Btn_Check";
            this.Btn_Check.Size = new System.Drawing.Size(75, 23);
            this.Btn_Check.TabIndex = 0;
            this.Btn_Check.Text = "Check";
            this.Btn_Check.UseVisualStyleBackColor = true;
            this.Btn_Check.Click += new System.EventHandler(this.Btn_Check_Click);
            // 
            // L_Check
            // 
            this.L_Check.AutoSize = true;
            this.L_Check.Location = new System.Drawing.Point(237, 166);
            this.L_Check.Name = "L_Check";
            this.L_Check.Size = new System.Drawing.Size(221, 12);
            this.L_Check.TabIndex = 1;
            this.L_Check.Text = "检测所选的文件是否正在被其他程序使用";
            // 
            // FormCheckFileUsing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.L_Check);
            this.Controls.Add(this.Btn_Check);
            this.Name = "FormCheckFileUsing";
            this.Text = "CheckFileUsing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Check;
        private System.Windows.Forms.Label L_Check;
    }
}