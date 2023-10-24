namespace MO4Movies
{
    partial class MoviesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoviesForm));
            this.Search = new System.Windows.Forms.GroupBox();
            this.MovieLabel = new System.Windows.Forms.Label();
            this.TXTMovieSearch = new System.Windows.Forms.TextBox();
            this.BTNAZSort = new System.Windows.Forms.Button();
            this.BTNZASort = new System.Windows.Forms.Button();
            this.BTNTop20Sort = new System.Windows.Forms.Button();
            this.BTNTotalsSort = new System.Windows.Forms.Button();
            this.movieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.movieBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.BTNSearch = new System.Windows.Forms.Button();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNFO2200CrandallDataSet = new MO4Movies.INFO2200CrandallDataSet();
            this.iNFO2200_CrandallSayDataSet1 = new MO4Movies.INFO2200_CrandallSayDataSet1();
            this.movieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.movieTableAdapter1 = new MO4Movies.INFO2200_CrandallSayDataSet1TableAdapters.MovieTableAdapter();
            this.tableAdapterManager1 = new MO4Movies.INFO2200_CrandallSayDataSet1TableAdapters.TableAdapterManager();
            this.movieDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingNavigator)).BeginInit();
            this.movieBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNFO2200CrandallDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNFO2200_CrandallSayDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Controls.Add(this.BTNSearch);
            this.Search.Controls.Add(this.MovieLabel);
            this.Search.Controls.Add(this.TXTMovieSearch);
            this.Search.Location = new System.Drawing.Point(90, 288);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(370, 75);
            this.Search.TabIndex = 0;
            this.Search.TabStop = false;
            this.Search.Text = "Search";
            // 
            // MovieLabel
            // 
            this.MovieLabel.AutoSize = true;
            this.MovieLabel.Location = new System.Drawing.Point(23, 34);
            this.MovieLabel.Name = "MovieLabel";
            this.MovieLabel.Size = new System.Drawing.Size(59, 13);
            this.MovieLabel.TabIndex = 1;
            this.MovieLabel.Text = "Movie Title";
            // 
            // TXTMovieSearch
            // 
            this.TXTMovieSearch.Location = new System.Drawing.Point(88, 31);
            this.TXTMovieSearch.Name = "TXTMovieSearch";
            this.TXTMovieSearch.Size = new System.Drawing.Size(174, 20);
            this.TXTMovieSearch.TabIndex = 0;
            // 
            // BTNAZSort
            // 
            this.BTNAZSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAZSort.Location = new System.Drawing.Point(34, 369);
            this.BTNAZSort.Name = "BTNAZSort";
            this.BTNAZSort.Size = new System.Drawing.Size(97, 87);
            this.BTNAZSort.TabIndex = 1;
            this.BTNAZSort.Text = "Sort A-Z by Title";
            this.BTNAZSort.UseVisualStyleBackColor = true;
            this.BTNAZSort.Click += new System.EventHandler(this.BTNAZSort_Click);
            // 
            // BTNZASort
            // 
            this.BTNZASort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNZASort.Location = new System.Drawing.Point(166, 369);
            this.BTNZASort.Name = "BTNZASort";
            this.BTNZASort.Size = new System.Drawing.Size(97, 87);
            this.BTNZASort.TabIndex = 2;
            this.BTNZASort.Text = "Sort Z-A by Title";
            this.BTNZASort.UseVisualStyleBackColor = true;
            this.BTNZASort.Click += new System.EventHandler(this.BTNZASort_Click);
            // 
            // BTNTop20Sort
            // 
            this.BTNTop20Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNTop20Sort.Location = new System.Drawing.Point(304, 369);
            this.BTNTop20Sort.Name = "BTNTop20Sort";
            this.BTNTop20Sort.Size = new System.Drawing.Size(97, 87);
            this.BTNTop20Sort.TabIndex = 3;
            this.BTNTop20Sort.Text = "Search First 20 (By ID)";
            this.BTNTop20Sort.UseVisualStyleBackColor = true;
            this.BTNTop20Sort.Click += new System.EventHandler(this.BTNTop20Sort_Click);
            // 
            // BTNTotalsSort
            // 
            this.BTNTotalsSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNTotalsSort.Location = new System.Drawing.Point(432, 369);
            this.BTNTotalsSort.Name = "BTNTotalsSort";
            this.BTNTotalsSort.Size = new System.Drawing.Size(97, 87);
            this.BTNTotalsSort.TabIndex = 4;
            this.BTNTotalsSort.Text = "Show Totals";
            this.BTNTotalsSort.UseVisualStyleBackColor = true;
            this.BTNTotalsSort.Click += new System.EventHandler(this.BTNTotalsSort_Click);
            // 
            // movieBindingNavigator
            // 
            this.movieBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.movieBindingNavigator.BindingSource = this.movieBindingSource;
            this.movieBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.movieBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.movieBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.movieBindingNavigatorSaveItem});
            this.movieBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.movieBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.movieBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.movieBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.movieBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.movieBindingNavigator.Name = "movieBindingNavigator";
            this.movieBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.movieBindingNavigator.Size = new System.Drawing.Size(568, 25);
            this.movieBindingNavigator.TabIndex = 5;
            this.movieBindingNavigator.Text = "bindingNavigator1";
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
            // movieBindingNavigatorSaveItem
            // 
            this.movieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.movieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("movieBindingNavigatorSaveItem.Image")));
            this.movieBindingNavigatorSaveItem.Name = "movieBindingNavigatorSaveItem";
            this.movieBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.movieBindingNavigatorSaveItem.Text = "Save Data";
            this.movieBindingNavigatorSaveItem.Click += new System.EventHandler(this.movieBindingNavigatorSaveItem_Click);
            // 
            // BTNSearch
            // 
            this.BTNSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSearch.Location = new System.Drawing.Point(279, 16);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(75, 49);
            this.BTNSearch.TabIndex = 2;
            this.BTNSearch.Text = "Search";
            this.BTNSearch.UseVisualStyleBackColor = true;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            this.movieBindingSource.DataSource = this.iNFO2200CrandallDataSet;
            // 
            // iNFO2200CrandallDataSet
            // 
            this.iNFO2200CrandallDataSet.DataSetName = "INFO2200CrandallDataSet";
            this.iNFO2200CrandallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieTableAdapter
            // 
            // iNFO2200_CrandallSayDataSet1
            // 
            this.iNFO2200_CrandallSayDataSet1.DataSetName = "INFO2200_CrandallSayDataSet1";
            this.iNFO2200_CrandallSayDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieBindingSource1
            // 
            this.movieBindingSource1.DataMember = "Movie";
            this.movieBindingSource1.DataSource = this.iNFO2200_CrandallSayDataSet1;
            // 
            // movieTableAdapter1
            // 
            this.movieTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.MovieTableAdapter = this.movieTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = MO4Movies.INFO2200_CrandallSayDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // movieDataGridView
            // 
            this.movieDataGridView.AutoGenerateColumns = false;
            this.movieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.movieDataGridView.DataSource = this.movieBindingSource1;
            this.movieDataGridView.Location = new System.Drawing.Point(34, 38);
            this.movieDataGridView.Name = "movieDataGridView";
            this.movieDataGridView.Size = new System.Drawing.Size(495, 220);
            this.movieDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "movieID";
            this.dataGridViewTextBoxColumn1.HeaderText = "movieID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "movieTitle";
            this.dataGridViewTextBoxColumn2.HeaderText = "movieTitle";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn3.HeaderText = "category";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // MoviesForm
            // 
            this.AcceptButton = this.BTNSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 476);
            this.Controls.Add(this.movieDataGridView);
            this.Controls.Add(this.movieBindingNavigator);
            this.Controls.Add(this.BTNTotalsSort);
            this.Controls.Add(this.BTNTop20Sort);
            this.Controls.Add(this.BTNZASort);
            this.Controls.Add(this.BTNAZSort);
            this.Controls.Add(this.Search);
            this.Name = "MoviesForm";
            this.Text = "Movies Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingNavigator)).EndInit();
            this.movieBindingNavigator.ResumeLayout(false);
            this.movieBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNFO2200_CrandallSayDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Search;
        private System.Windows.Forms.Label MovieLabel;
        private System.Windows.Forms.TextBox TXTMovieSearch;
        private System.Windows.Forms.Button BTNAZSort;
        private System.Windows.Forms.Button BTNZASort;
        private System.Windows.Forms.Button BTNTop20Sort;
        private System.Windows.Forms.Button BTNTotalsSort;
        private INFO2200CrandallDataSet iNFO2200CrandallDataSet;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.BindingNavigator movieBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton movieBindingNavigatorSaveItem;
        private System.Windows.Forms.Button BTNSearch;
        private INFO2200_CrandallSayDataSet1 iNFO2200_CrandallSayDataSet1;
        private System.Windows.Forms.BindingSource movieBindingSource1;
        private INFO2200_CrandallSayDataSet1TableAdapters.MovieTableAdapter movieTableAdapter1;
        private INFO2200_CrandallSayDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView movieDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

