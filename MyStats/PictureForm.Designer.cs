namespace MyStats
{
    partial class PictureForm
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
            this.pic_Main = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Main
            // 
            this.pic_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_Main.Location = new System.Drawing.Point(1, 3);
            this.pic_Main.Name = "pic_Main";
            this.pic_Main.Size = new System.Drawing.Size(300, 300);
            this.pic_Main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Main.TabIndex = 0;
            this.pic_Main.TabStop = false;
            // 
            // PictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 297);
            this.Controls.Add(this.pic_Main);
            this.Name = "PictureForm";
            this.Text = "PictureForm";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public PictureBox pic_Main;
    }
}