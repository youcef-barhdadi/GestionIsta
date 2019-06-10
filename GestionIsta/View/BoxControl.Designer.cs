namespace GestionIsta.View
{
    partial class BoxControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxControl));
            this.ClosePictureBox = new System.Windows.Forms.PictureBox();
            this.MinPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ClosePictureBox
            // 
            this.ClosePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClosePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ClosePictureBox.Image")));
            this.ClosePictureBox.Location = new System.Drawing.Point(46, 0);
            this.ClosePictureBox.Name = "ClosePictureBox";
            this.ClosePictureBox.Size = new System.Drawing.Size(60, 31);
            this.ClosePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClosePictureBox.TabIndex = 0;
            this.ClosePictureBox.TabStop = false;
            this.ClosePictureBox.Click += new System.EventHandler(this.ClosePictureBox_Click);
            this.ClosePictureBox.MouseLeave += new System.EventHandler(this.ClosePictureBox_MouseLeave);
            this.ClosePictureBox.MouseHover += new System.EventHandler(this.ClosePictureBox_MouseHover);
            // 
            // MinPictureBox
            // 
            this.MinPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MinPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MinPictureBox.Image")));
            this.MinPictureBox.Location = new System.Drawing.Point(0, 0);
            this.MinPictureBox.Name = "MinPictureBox";
            this.MinPictureBox.Size = new System.Drawing.Size(40, 31);
            this.MinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinPictureBox.TabIndex = 1;
            this.MinPictureBox.TabStop = false;
            this.MinPictureBox.Click += new System.EventHandler(this.MinPictureBox_Click);
            this.MinPictureBox.MouseLeave += new System.EventHandler(this.MinPictureBox_MouseLeave);
            this.MinPictureBox.MouseHover += new System.EventHandler(this.MinPictureBox_MouseHover);
            // 
            // BoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.MinPictureBox);
            this.Controls.Add(this.ClosePictureBox);
            this.Name = "BoxControl";
            this.Size = new System.Drawing.Size(106, 31);
            ((System.ComponentModel.ISupportInitialize)(this.ClosePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ClosePictureBox;
        private System.Windows.Forms.PictureBox MinPictureBox;
    }
}
