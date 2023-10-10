namespace ParticipationMO4
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
            this.components = new System.ComponentModel.Container();
            this.localPhoneDBDataSet1 = new ParticipationMO4.LocalPhoneDBDataSet1();
            this.phoneListTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneListTableTableAdapter = new ParticipationMO4.LocalPhoneDBDataSet1TableAdapters.PhoneListTableTableAdapter();
            this.tableAdapterManager = new ParticipationMO4.LocalPhoneDBDataSet1TableAdapters.TableAdapterManager();
            this.BtnLocalNums = new System.Windows.Forms.Button();
            this.BtnImportedNums = new System.Windows.Forms.Button();
            this.BtnOnlineNums = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.localPhoneDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // localPhoneDBDataSet1
            // 
            this.localPhoneDBDataSet1.DataSetName = "LocalPhoneDBDataSet1";
            this.localPhoneDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phoneListTableBindingSource
            // 
            this.phoneListTableBindingSource.DataMember = "PhoneListTable";
            this.phoneListTableBindingSource.DataSource = this.localPhoneDBDataSet1;
            // 
            // phoneListTableTableAdapter
            // 
            this.phoneListTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PhoneListTableTableAdapter = this.phoneListTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = ParticipationMO4.LocalPhoneDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // BtnLocalNums
            // 
            this.BtnLocalNums.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLocalNums.Location = new System.Drawing.Point(12, 12);
            this.BtnLocalNums.Name = "BtnLocalNums";
            this.BtnLocalNums.Size = new System.Drawing.Size(246, 187);
            this.BtnLocalNums.TabIndex = 0;
            this.BtnLocalNums.Text = "Local Phone Numbers";
            this.BtnLocalNums.UseVisualStyleBackColor = true;
            this.BtnLocalNums.Click += new System.EventHandler(this.BtnLocalNums_Click);
            // 
            // BtnImportedNums
            // 
            this.BtnImportedNums.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImportedNums.Location = new System.Drawing.Point(270, 12);
            this.BtnImportedNums.Name = "BtnImportedNums";
            this.BtnImportedNums.Size = new System.Drawing.Size(246, 187);
            this.BtnImportedNums.TabIndex = 0;
            this.BtnImportedNums.Text = "Imported Phone Numbers";
            this.BtnImportedNums.UseVisualStyleBackColor = true;
            this.BtnImportedNums.Click += new System.EventHandler(this.BtnImportedNums_Click);
            // 
            // BtnOnlineNums
            // 
            this.BtnOnlineNums.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOnlineNums.Location = new System.Drawing.Point(12, 230);
            this.BtnOnlineNums.Name = "BtnOnlineNums";
            this.BtnOnlineNums.Size = new System.Drawing.Size(246, 187);
            this.BtnOnlineNums.TabIndex = 0;
            this.BtnOnlineNums.Text = "Online Phone Numbers";
            this.BtnOnlineNums.UseVisualStyleBackColor = true;
            this.BtnOnlineNums.Click += new System.EventHandler(this.BtnOnlineNums_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(270, 230);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(246, 187);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 448);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnOnlineNums);
            this.Controls.Add(this.BtnImportedNums);
            this.Controls.Add(this.BtnLocalNums);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.localPhoneDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LocalPhoneDBDataSet1 localPhoneDBDataSet1;
        private System.Windows.Forms.BindingSource phoneListTableBindingSource;
        private LocalPhoneDBDataSet1TableAdapters.PhoneListTableTableAdapter phoneListTableTableAdapter;
        private LocalPhoneDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button BtnLocalNums;
        private System.Windows.Forms.Button BtnImportedNums;
        private System.Windows.Forms.Button BtnOnlineNums;
        private System.Windows.Forms.Button BtnClose;
    }
}

