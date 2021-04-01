
namespace YTDownloader
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.link = new System.Windows.Forms.TextBox();
            this.download_button = new System.Windows.Forms.Button();
            this.linklabel = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // link
            // 
            this.link.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.link.Location = new System.Drawing.Point(12, 40);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(430, 29);
            this.link.TabIndex = 0;
            // 
            // download_button
            // 
            this.download_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.download_button.Location = new System.Drawing.Point(12, 92);
            this.download_button.Name = "download_button";
            this.download_button.Size = new System.Drawing.Size(430, 57);
            this.download_button.TabIndex = 1;
            this.download_button.Text = "İndir";
            this.download_button.UseVisualStyleBackColor = true;
            this.download_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // linklabel
            // 
            this.linklabel.AutoSize = true;
            this.linklabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linklabel.Location = new System.Drawing.Point(12, 7);
            this.linklabel.Name = "linklabel";
            this.linklabel.Size = new System.Drawing.Size(62, 30);
            this.linklabel.TabIndex = 2;
            this.linklabel.Text = "Link:";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(12, 155);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(430, 37);
            this.progress.TabIndex = 3;
            // 
            // Main
            // 
            this.AcceptButton = this.download_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(454, 221);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.download_button);
            this.Controls.Add(this.linklabel);
            this.Controls.Add(this.link);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YT Downloader";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox link;
        private System.Windows.Forms.Button download_button;
        private System.Windows.Forms.Label linklabel;
        private System.Windows.Forms.ProgressBar progress;
    }
}

