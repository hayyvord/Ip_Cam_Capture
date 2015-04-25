namespace Ip_Cam_Capture
{
    partial class IpCam
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
            this.capture = new System.Windows.Forms.Button();
            this.pbMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // capture
            // 
            this.capture.Location = new System.Drawing.Point(12, 498);
            this.capture.Name = "capture";
            this.capture.Size = new System.Drawing.Size(75, 23);
            this.capture.TabIndex = 0;
            this.capture.Text = "Capture";
            this.capture.UseVisualStyleBackColor = true;
            this.capture.Click += new System.EventHandler(this.capture_Click);
            // 
            // pbMain
            // 
            this.pbMain.Location = new System.Drawing.Point(12, 12);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(640, 480);
            this.pbMain.TabIndex = 1;
            this.pbMain.TabStop = false;
            // 
            // IpCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 530);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.capture);
            this.Name = "IpCam";
            this.Text = "IpCam";
            this.Load += new System.EventHandler(this.IpCam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button capture;
        private System.Windows.Forms.PictureBox pbMain;
    }
}

