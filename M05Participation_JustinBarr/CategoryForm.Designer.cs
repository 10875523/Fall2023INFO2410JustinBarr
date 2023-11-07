namespace M05Participation_JustinBarr
{
    partial class CategoryForm
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
            this.LSTViewCat = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // LSTViewCat
            // 
            this.LSTViewCat.HideSelection = false;
            this.LSTViewCat.Location = new System.Drawing.Point(12, 12);
            this.LSTViewCat.Name = "LSTViewCat";
            this.LSTViewCat.Size = new System.Drawing.Size(385, 374);
            this.LSTViewCat.TabIndex = 0;
            this.LSTViewCat.UseCompatibleStateImageBehavior = false;
            this.LSTViewCat.View = System.Windows.Forms.View.Details;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 398);
            this.Controls.Add(this.LSTViewCat);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LSTViewCat;
    }
}