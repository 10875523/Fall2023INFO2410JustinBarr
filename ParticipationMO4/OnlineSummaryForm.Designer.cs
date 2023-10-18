namespace ParticipationMO4
{
    partial class OnlineSummaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlineSummaryForm));
            this.iNFO2200_CrandallSaySP = new ParticipationMO4.INFO2200_CrandallSaySP();
            this.uVUPhoneNumbersSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uVUPhoneNumbersSPTableAdapter = new ParticipationMO4.INFO2200_CrandallSaySPTableAdapters.UVUPhoneNumbersSPTableAdapter();
            this.tableAdapterManager = new ParticipationMO4.INFO2200_CrandallSaySPTableAdapters.TableAdapterManager();
            this.uVUPhoneNumbersSPBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.uVUPhoneNumbersSPBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.uVUPhoneNumbersSPDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iNFO2200_CrandallSaySP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumbersSPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumbersSPBindingNavigator)).BeginInit();
            this.uVUPhoneNumbersSPBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumbersSPDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iNFO2200_CrandallSaySP
            // 
            this.iNFO2200_CrandallSaySP.DataSetName = "INFO2200_CrandallSaySP";
            this.iNFO2200_CrandallSaySP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uVUPhoneNumbersSPBindingSource
            // 
            this.uVUPhoneNumbersSPBindingSource.DataMember = "UVUPhoneNumbersSP";
            this.uVUPhoneNumbersSPBindingSource.DataSource = this.iNFO2200_CrandallSaySP;
            // 
            // uVUPhoneNumbersSPTableAdapter
            // 
            this.uVUPhoneNumbersSPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = ParticipationMO4.INFO2200_CrandallSaySPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uVUPhoneNumbersSPBindingNavigator
            // 
            this.uVUPhoneNumbersSPBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uVUPhoneNumbersSPBindingNavigator.BindingSource = this.uVUPhoneNumbersSPBindingSource;
            this.uVUPhoneNumbersSPBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uVUPhoneNumbersSPBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uVUPhoneNumbersSPBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.uVUPhoneNumbersSPBindingNavigatorSaveItem});
            this.uVUPhoneNumbersSPBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uVUPhoneNumbersSPBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uVUPhoneNumbersSPBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uVUPhoneNumbersSPBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uVUPhoneNumbersSPBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uVUPhoneNumbersSPBindingNavigator.Name = "uVUPhoneNumbersSPBindingNavigator";
            this.uVUPhoneNumbersSPBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uVUPhoneNumbersSPBindingNavigator.Size = new System.Drawing.Size(468, 25);
            this.uVUPhoneNumbersSPBindingNavigator.TabIndex = 0;
            this.uVUPhoneNumbersSPBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // uVUPhoneNumbersSPBindingNavigatorSaveItem
            // 
            this.uVUPhoneNumbersSPBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uVUPhoneNumbersSPBindingNavigatorSaveItem.Enabled = false;
            this.uVUPhoneNumbersSPBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uVUPhoneNumbersSPBindingNavigatorSaveItem.Image")));
            this.uVUPhoneNumbersSPBindingNavigatorSaveItem.Name = "uVUPhoneNumbersSPBindingNavigatorSaveItem";
            this.uVUPhoneNumbersSPBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.uVUPhoneNumbersSPBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // uVUPhoneNumbersSPDataGridView
            // 
            this.uVUPhoneNumbersSPDataGridView.AutoGenerateColumns = false;
            this.uVUPhoneNumbersSPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uVUPhoneNumbersSPDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.uVUPhoneNumbersSPDataGridView.DataSource = this.uVUPhoneNumbersSPBindingSource;
            this.uVUPhoneNumbersSPDataGridView.Location = new System.Drawing.Point(35, 39);
            this.uVUPhoneNumbersSPDataGridView.Name = "uVUPhoneNumbersSPDataGridView";
            this.uVUPhoneNumbersSPDataGridView.Size = new System.Drawing.Size(410, 249);
            this.uVUPhoneNumbersSPDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Dept";
            this.dataGridViewTextBoxColumn1.HeaderText = "Count";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Department";
            this.dataGridViewTextBoxColumn2.HeaderText = "Department";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // OnlineSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 296);
            this.Controls.Add(this.uVUPhoneNumbersSPDataGridView);
            this.Controls.Add(this.uVUPhoneNumbersSPBindingNavigator);
            this.Name = "OnlineSummaryForm";
            this.Text = "OnlineSummaryForm";
            this.Load += new System.EventHandler(this.OnlineSummaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iNFO2200_CrandallSaySP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumbersSPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumbersSPBindingNavigator)).EndInit();
            this.uVUPhoneNumbersSPBindingNavigator.ResumeLayout(false);
            this.uVUPhoneNumbersSPBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumbersSPDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private INFO2200_CrandallSaySP iNFO2200_CrandallSaySP;
        private System.Windows.Forms.BindingSource uVUPhoneNumbersSPBindingSource;
        private INFO2200_CrandallSaySPTableAdapters.UVUPhoneNumbersSPTableAdapter uVUPhoneNumbersSPTableAdapter;
        private INFO2200_CrandallSaySPTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uVUPhoneNumbersSPBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton uVUPhoneNumbersSPBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView uVUPhoneNumbersSPDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}