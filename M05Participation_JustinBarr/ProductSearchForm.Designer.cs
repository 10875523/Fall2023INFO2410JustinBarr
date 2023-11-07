namespace M05Participation_JustinBarr
{
    partial class ProductSearchForm
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
            this.DGVProducts = new System.Windows.Forms.DataGridView();
            this.BTNDelete = new System.Windows.Forms.Button();
            this.BTNAddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBProductID = new System.Windows.Forms.ComboBox();
            this.TXTProductDesc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVProducts
            // 
            this.DGVProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProducts.Location = new System.Drawing.Point(12, 12);
            this.DGVProducts.Name = "DGVProducts";
            this.DGVProducts.Size = new System.Drawing.Size(776, 355);
            this.DGVProducts.TabIndex = 0;
            // 
            // BTNDelete
            // 
            this.BTNDelete.Location = new System.Drawing.Point(666, 415);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(109, 23);
            this.BTNDelete.TabIndex = 1;
            this.BTNDelete.Text = "Delete";
            this.BTNDelete.UseVisualStyleBackColor = true;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // BTNAddNew
            // 
            this.BTNAddNew.Location = new System.Drawing.Point(666, 386);
            this.BTNAddNew.Name = "BTNAddNew";
            this.BTNAddNew.Size = new System.Drawing.Size(109, 23);
            this.BTNAddNew.TabIndex = 1;
            this.BTNAddNew.Text = "Add New";
            this.BTNAddNew.UseVisualStyleBackColor = true;
            this.BTNAddNew.Click += new System.EventHandler(this.BTNAddNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product ID";
            // 
            // CBProductID
            // 
            this.CBProductID.FormattingEnabled = true;
            this.CBProductID.Location = new System.Drawing.Point(515, 415);
            this.CBProductID.Name = "CBProductID";
            this.CBProductID.Size = new System.Drawing.Size(121, 21);
            this.CBProductID.TabIndex = 4;
            // 
            // TXTProductDesc
            // 
            this.TXTProductDesc.Location = new System.Drawing.Point(207, 386);
            this.TXTProductDesc.Name = "TXTProductDesc";
            this.TXTProductDesc.Size = new System.Drawing.Size(262, 20);
            this.TXTProductDesc.TabIndex = 5;
            this.TXTProductDesc.TextChanged += new System.EventHandler(this.TXTProductDesc_TextChanged);
            // 
            // ProductSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXTProductDesc);
            this.Controls.Add(this.CBProductID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNAddNew);
            this.Controls.Add(this.BTNDelete);
            this.Controls.Add(this.DGVProducts);
            this.Name = "ProductSearchForm";
            this.Text = "ProductSearchForm";
            this.Load += new System.EventHandler(this.ProductSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVProducts;
        private System.Windows.Forms.Button BTNDelete;
        private System.Windows.Forms.Button BTNAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBProductID;
        private System.Windows.Forms.TextBox TXTProductDesc;
    }
}