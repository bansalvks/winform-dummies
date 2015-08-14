namespace WebCamDummy
{
    partial class Form1
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
            this.ClickPic = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Photo_frame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Photo_frame)).BeginInit();
            this.SuspendLayout();
            // 
            // ClickPic
            // 
            this.ClickPic.AutoSize = true;
            this.ClickPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClickPic.Location = new System.Drawing.Point(312, 222);
            this.ClickPic.Name = "ClickPic";
            this.ClickPic.Size = new System.Drawing.Size(75, 25);
            this.ClickPic.TabIndex = 1;
            this.ClickPic.Text = "Start";
            this.ClickPic.UseVisualStyleBackColor = true;
            this.ClickPic.Click += new System.EventHandler(this.ClickPic_Click);
            // 
            // Save
            // 
            this.Save.AutoSize = true;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.Location = new System.Drawing.Point(393, 222);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 25);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Photo_frame
            // 
            this.Photo_frame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Photo_frame.Dock = System.Windows.Forms.DockStyle.Top;
            this.Photo_frame.Location = new System.Drawing.Point(0, 0);
            this.Photo_frame.Name = "Photo_frame";
            this.Photo_frame.Size = new System.Drawing.Size(737, 216);
            this.Photo_frame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo_frame.TabIndex = 45;
            this.Photo_frame.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(737, 251);
            this.Controls.Add(this.Photo_frame);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.ClickPic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Photo_frame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClickPic;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.PictureBox Photo_frame;
    }
}

