namespace M05JellyBellyJustinBarr
{
    partial class JellyBellyForm
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
            this.DGVJellyBelly = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNAll = new System.Windows.Forms.Button();
            this.BTNSearch = new System.Windows.Forms.Button();
            this.TXTBoxSearch = new System.Windows.Forms.TextBox();
            this.BTNClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVJellyBelly)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVJellyBelly
            // 
            this.DGVJellyBelly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVJellyBelly.Location = new System.Drawing.Point(12, 12);
            this.DGVJellyBelly.Name = "DGVJellyBelly";
            this.DGVJellyBelly.Size = new System.Drawing.Size(333, 201);
            this.DGVJellyBelly.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNAll);
            this.groupBox1.Controls.Add(this.BTNSearch);
            this.groupBox1.Controls.Add(this.TXTBoxSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // BTNAll
            // 
            this.BTNAll.Location = new System.Drawing.Point(246, 30);
            this.BTNAll.Name = "BTNAll";
            this.BTNAll.Size = new System.Drawing.Size(75, 23);
            this.BTNAll.TabIndex = 1;
            this.BTNAll.Text = "All";
            this.BTNAll.UseVisualStyleBackColor = true;
            this.BTNAll.Click += new System.EventHandler(this.BTNAll_Click);
            // 
            // BTNSearch
            // 
            this.BTNSearch.Location = new System.Drawing.Point(165, 30);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(75, 23);
            this.BTNSearch.TabIndex = 1;
            this.BTNSearch.Text = "Search";
            this.BTNSearch.UseVisualStyleBackColor = true;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // TXTBoxSearch
            // 
            this.TXTBoxSearch.Location = new System.Drawing.Point(6, 30);
            this.TXTBoxSearch.Name = "TXTBoxSearch";
            this.TXTBoxSearch.Size = new System.Drawing.Size(153, 20);
            this.TXTBoxSearch.TabIndex = 0;
            this.TXTBoxSearch.TextChanged += new System.EventHandler(this.TXTBoxSearch_TextChanged);
            // 
            // BTNClose
            // 
            this.BTNClose.Location = new System.Drawing.Point(243, 293);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(90, 23);
            this.BTNClose.TabIndex = 2;
            this.BTNClose.Text = "Close";
            this.BTNClose.UseVisualStyleBackColor = true;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            // 
            // JellyBellyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 362);
            this.Controls.Add(this.BTNClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGVJellyBelly);
            this.Name = "JellyBellyForm";
            this.Text = "JellyBellyForm";
            this.Load += new System.EventHandler(this.JellyBellyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVJellyBelly)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVJellyBelly;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXTBoxSearch;
        private System.Windows.Forms.Button BTNAll;
        private System.Windows.Forms.Button BTNSearch;
        private System.Windows.Forms.Button BTNClose;
    }
}