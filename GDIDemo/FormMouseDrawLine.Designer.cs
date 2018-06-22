namespace GDIDemo
{
    partial class FormMouseDrawLine
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
            this.Pb_Draw = new System.Windows.Forms.PictureBox();
            this.Btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Draw)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_Draw
            // 
            this.Pb_Draw.Location = new System.Drawing.Point(12, 12);
            this.Pb_Draw.Name = "Pb_Draw";
            this.Pb_Draw.Size = new System.Drawing.Size(1240, 618);
            this.Pb_Draw.TabIndex = 0;
            this.Pb_Draw.TabStop = false;
            this.Pb_Draw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pb_Draw_MouseDown);
            this.Pb_Draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pb_Draw_MouseMove);
            this.Pb_Draw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pb_Draw_MouseUp);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(600, 650);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.Btn_Clear.TabIndex = 1;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // FormMouseDrawLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Pb_Draw);
            this.Name = "FormMouseDrawLine";
            this.Text = "MouseDrawLine";
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Draw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb_Draw;
        private System.Windows.Forms.Button Btn_Clear;
    }
}