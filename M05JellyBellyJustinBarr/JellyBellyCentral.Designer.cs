namespace M05JellyBellyJustinBarr
{
    partial class JellyBellyCentral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JellyBellyCentral));
            this.BTNShowCats = new System.Windows.Forms.Button();
            this.BTNSearchFlavors = new System.Windows.Forms.Button();
            this.BTNClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNShowCats
            // 
            this.BTNShowCats.Location = new System.Drawing.Point(174, 323);
            this.BTNShowCats.Name = "BTNShowCats";
            this.BTNShowCats.Size = new System.Drawing.Size(140, 23);
            this.BTNShowCats.TabIndex = 0;
            this.BTNShowCats.Text = "Show Flavor Categories";
            this.BTNShowCats.UseVisualStyleBackColor = true;
            this.BTNShowCats.Click += new System.EventHandler(this.BTNShowCats_Click);
            // 
            // BTNSearchFlavors
            // 
            this.BTNSearchFlavors.Location = new System.Drawing.Point(22, 323);
            this.BTNSearchFlavors.Name = "BTNSearchFlavors";
            this.BTNSearchFlavors.Size = new System.Drawing.Size(140, 23);
            this.BTNSearchFlavors.TabIndex = 0;
            this.BTNSearchFlavors.Text = "Search Jelly Belly Flavors";
            this.BTNSearchFlavors.UseVisualStyleBackColor = true;
            this.BTNSearchFlavors.Click += new System.EventHandler(this.BTNSearchFlavors_Click);
            // 
            // BTNClose
            // 
            this.BTNClose.Location = new System.Drawing.Point(239, 377);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(75, 23);
            this.BTNClose.TabIndex = 0;
            this.BTNClose.Text = "Close";
            this.BTNClose.UseVisualStyleBackColor = true;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // JellyBellyCentral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 407);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNSearchFlavors);
            this.Controls.Add(this.BTNClose);
            this.Controls.Add(this.BTNShowCats);
            this.Name = "JellyBellyCentral";
            this.Text = "JellyBelly Central";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNShowCats;
        private System.Windows.Forms.Button BTNSearchFlavors;
        private System.Windows.Forms.Button BTNClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

