namespace M05Participation_JustinBarr
{
    partial class LandingForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTNProdSearch = new System.Windows.Forms.Button();
            this.BTNGroupCat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::M05Participation_JustinBarr.Properties.Resources.before;
            this.pictureBox1.Location = new System.Drawing.Point(-66, -26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(697, 727);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BTNProdSearch
            // 
            this.BTNProdSearch.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNProdSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNProdSearch.Location = new System.Drawing.Point(44, 514);
            this.BTNProdSearch.Name = "BTNProdSearch";
            this.BTNProdSearch.Size = new System.Drawing.Size(203, 77);
            this.BTNProdSearch.TabIndex = 1;
            this.BTNProdSearch.Text = "Product Search";
            this.BTNProdSearch.UseVisualStyleBackColor = false;
            this.BTNProdSearch.Click += new System.EventHandler(this.BTNProdSearch_Click);
            // 
            // BTNGroupCat
            // 
            this.BTNGroupCat.Location = new System.Drawing.Point(301, 514);
            this.BTNGroupCat.Name = "BTNGroupCat";
            this.BTNGroupCat.Size = new System.Drawing.Size(203, 77);
            this.BTNGroupCat.TabIndex = 1;
            this.BTNGroupCat.Text = "Group by Category";
            this.BTNGroupCat.UseVisualStyleBackColor = true;
            this.BTNGroupCat.Click += new System.EventHandler(this.BTNGroupCat_Click);
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 629);
            this.Controls.Add(this.BTNGroupCat);
            this.Controls.Add(this.BTNProdSearch);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LandingForm";
            this.Text = "Justin\'s Clothes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTNProdSearch;
        private System.Windows.Forms.Button BTNGroupCat;
    }
}

