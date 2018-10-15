namespace HaNoiTower
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.About_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // About_OK
            // 
            this.About_OK.Location = new System.Drawing.Point(246, 489);
            this.About_OK.Name = "About_OK";
            this.About_OK.Size = new System.Drawing.Size(75, 23);
            this.About_OK.TabIndex = 0;
            this.About_OK.Text = "OK";
            this.About_OK.UseVisualStyleBackColor = true;
            this.About_OK.Click += new System.EventHandler(this.About_OK_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 524);
            this.Controls.Add(this.About_OK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "About This Project";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button About_OK;
    }
}