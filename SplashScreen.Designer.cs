namespace WolfWatch
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.image = new MetroFramework.Controls.MetroPanel();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.image.SuspendLayout();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.BackgroundImage = global::WolfWatch.Properties.Resources.WolfWatch;
            this.image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image.Controls.Add(this.progressBar);
            this.image.HorizontalScrollbarBarColor = true;
            this.image.HorizontalScrollbarHighlightOnWheel = false;
            this.image.HorizontalScrollbarSize = 10;
            this.image.Location = new System.Drawing.Point(0, 5);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(480, 240);
            this.image.TabIndex = 1;
            this.image.VerticalScrollbarBarColor = true;
            this.image.VerticalScrollbarHighlightOnWheel = false;
            this.image.VerticalScrollbarSize = 10;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(23, 168);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.Size = new System.Drawing.Size(434, 23);
            this.progressBar.TabIndex = 2;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 240);
            this.ControlBox = false;
            this.Controls.Add(this.image);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.Resizable = false;
            this.image.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel image;
        private MetroFramework.Controls.MetroProgressBar progressBar;
    }
}