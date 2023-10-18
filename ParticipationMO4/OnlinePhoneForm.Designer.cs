namespace ParticipationMO4
{
    partial class OnlinePhoneForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlinePhoneForm));
            this.iNFO2200_CrandallSayDataSet = new ParticipationMO4.INFO2200_CrandallSayDataSet();
            this.uVUPhoneNumsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uVUPhoneNumsTableTableAdapter = new ParticipationMO4.INFO2200_CrandallSayDataSetTableAdapters.UVUPhoneNumsTableTableAdapter();
            this.tableAdapterManager = new ParticipationMO4.INFO2200_CrandallSayDataSetTableAdapters.TableAdapterManager();
            this.uVUPhoneNumsTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.uVUPhoneNumsTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.uVUPhoneNumsTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iNFO2200_CrandallSayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumsTableBindingNavigator)).BeginInit();
            this.uVUPhoneNumsTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumsTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iNFO2200_CrandallSayDataSet
            // 
            this.iNFO2200_CrandallSayDataSet.DataSetName = "INFO2200_CrandallSayDataSet";
            this.iNFO2200_CrandallSayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uVUPhoneNumsTableBindingSource
            // 
            this.uVUPhoneNumsTableBindingSource.DataMember = "UVUPhoneNumsTable";
            this.uVUPhoneNumsTableBindingSource.DataSource = this.iNFO2200_CrandallSayDataSet;
            // 
            // uVUPhoneNumsTableTableAdapter
            // 
            this.uVUPhoneNumsTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.JellyBellyTableAdapter = null;
            this.tableAdapterManager.MovieTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ParticipationMO4.INFO2200_CrandallSayDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UVUClassesOnlineTableTableAdapter = null;
            this.tableAdapterManager.UVUPhoneNumsTableTableAdapter = this.uVUPhoneNumsTableTableAdapter;
            // 
            // uVUPhoneNumsTableBindingNavigator
            // 
            this.uVUPhoneNumsTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uVUPhoneNumsTableBindingNavigator.BindingSource = this.uVUPhoneNumsTableBindingSource;
            this.uVUPhoneNumsTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uVUPhoneNumsTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uVUPhoneNumsTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.uVUPhoneNumsTableBindingNavigatorSaveItem});
            this.uVUPhoneNumsTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uVUPhoneNumsTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uVUPhoneNumsTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uVUPhoneNumsTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uVUPhoneNumsTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uVUPhoneNumsTableBindingNavigator.Name = "uVUPhoneNumsTableBindingNavigator";
            this.uVUPhoneNumsTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uVUPhoneNumsTableBindingNavigator.Size = new System.Drawing.Size(637, 25);
            this.uVUPhoneNumsTableBindingNavigator.TabIndex = 0;
            this.uVUPhoneNumsTableBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // uVUPhoneNumsTableBindingNavigatorSaveItem
            // 
            this.uVUPhoneNumsTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uVUPhoneNumsTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uVUPhoneNumsTableBindingNavigatorSaveItem.Image")));
            this.uVUPhoneNumsTableBindingNavigatorSaveItem.Name = "uVUPhoneNumsTableBindingNavigatorSaveItem";
            this.uVUPhoneNumsTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.uVUPhoneNumsTableBindingNavigatorSaveItem.Text = "Save Data";
            this.uVUPhoneNumsTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.uVUPhoneNumsTableBindingNavigatorSaveItem_Click);
            // 
            // uVUPhoneNumsTableDataGridView
            // 
            this.uVUPhoneNumsTableDataGridView.AutoGenerateColumns = false;
            this.uVUPhoneNumsTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uVUPhoneNumsTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.uVUPhoneNumsTableDataGridView.DataSource = this.uVUPhoneNumsTableBindingSource;
            this.uVUPhoneNumsTableDataGridView.Location = new System.Drawing.Point(12, 48);
            this.uVUPhoneNumsTableDataGridView.Name = "uVUPhoneNumsTableDataGridView";
            this.uVUPhoneNumsTableDataGridView.Size = new System.Drawing.Size(566, 220);
            this.uVUPhoneNumsTableDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UVUPhoneNumsId";
            this.dataGridViewTextBoxColumn1.HeaderText = "UVUPhoneNumsId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Department";
            this.dataGridViewTextBoxColumn5.HeaderText = "Department";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Summary
            // 
            this.Summary.Location = new System.Drawing.Point(436, 283);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(142, 29);
            this.Summary.TabIndex = 2;
            this.Summary.Text = "Summary";
            this.Summary.UseVisualStyleBackColor = true;
            this.Summary.Click += new System.EventHandler(this.Summary_Click);
            // 
            // OnlinePhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 326);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.uVUPhoneNumsTableDataGridView);
            this.Controls.Add(this.uVUPhoneNumsTableBindingNavigator);
            this.Name = "OnlinePhoneForm";
            this.Text = "OnlinePhoneForm";
            this.Load += new System.EventHandler(this.OnlinePhoneForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iNFO2200_CrandallSayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumsTableBindingNavigator)).EndInit();
            this.uVUPhoneNumsTableBindingNavigator.ResumeLayout(false);
            this.uVUPhoneNumsTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumsTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private INFO2200_CrandallSayDataSet iNFO2200_CrandallSayDataSet;
        private System.Windows.Forms.BindingSource uVUPhoneNumsTableBindingSource;
        private INFO2200_CrandallSayDataSetTableAdapters.UVUPhoneNumsTableTableAdapter uVUPhoneNumsTableTableAdapter;
        private INFO2200_CrandallSayDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uVUPhoneNumsTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton uVUPhoneNumsTableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView uVUPhoneNumsTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button Summary;
    }
}