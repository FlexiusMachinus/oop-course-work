
namespace OOP_CourseWork
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._tabControl = new System.Windows.Forms.TabControl();
            this._tabPage1 = new System.Windows.Forms.TabPage();
            this._deleteProductButton = new System.Windows.Forms.Button();
            this._addProductButton = new System.Windows.Forms.Button();
            this._productsGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this._categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SubjectId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this._subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediaTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._tabPage2 = new System.Windows.Forms.TabPage();
            this._deleteTransactionButton = new System.Windows.Forms.Button();
            this._addTransactionButton = new System.Windows.Forms.Button();
            this._transactionsGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PurchaseDate = new OOP_CourseWork.DataGridViewCalendarColumn();
            this._transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._tabPage3 = new System.Windows.Forms.TabPage();
            this._deleteCategoryButton = new System.Windows.Forms.Button();
            this._addCategoryButton = new System.Windows.Forms.Button();
            this._categoriesGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tabPage4 = new System.Windows.Forms.TabPage();
            this._deleteSubjectButton = new System.Windows.Forms.Button();
            this._addSubjectButton = new System.Windows.Forms.Button();
            this._subjectsGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this._bdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._createDbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._loadDbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._saveDbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._closeDbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._deleteDbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._applyFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._resetFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._splitter = new System.Windows.Forms.Label();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tabControl.SuspendLayout();
            this._tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._productsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._productBindingSource)).BeginInit();
            this._tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._transactionsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._transactionBindingSource)).BeginInit();
            this._tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._categoriesGrid)).BeginInit();
            this._tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._subjectsGrid)).BeginInit();
            this._menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tabControl
            // 
            this._tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tabControl.Controls.Add(this._tabPage1);
            this._tabControl.Controls.Add(this._tabPage2);
            this._tabControl.Controls.Add(this._tabPage3);
            this._tabControl.Controls.Add(this._tabPage4);
            this._tabControl.Location = new System.Drawing.Point(12, 34);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(1055, 545);
            this._tabControl.TabIndex = 0;
            this._tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControlSelectedIndexChanged);
            // 
            // _tabPage1
            // 
            this._tabPage1.Controls.Add(this._deleteProductButton);
            this._tabPage1.Controls.Add(this._addProductButton);
            this._tabPage1.Controls.Add(this._productsGrid);
            this._tabPage1.Location = new System.Drawing.Point(4, 24);
            this._tabPage1.Name = "_tabPage1";
            this._tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this._tabPage1.Size = new System.Drawing.Size(1047, 517);
            this._tabPage1.TabIndex = 0;
            this._tabPage1.Text = "Товары";
            this._tabPage1.UseVisualStyleBackColor = true;
            // 
            // _deleteProductButton
            // 
            this._deleteProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._deleteProductButton.Enabled = false;
            this._deleteProductButton.Location = new System.Drawing.Point(162, 484);
            this._deleteProductButton.Name = "_deleteProductButton";
            this._deleteProductButton.Size = new System.Drawing.Size(150, 25);
            this._deleteProductButton.TabIndex = 2;
            this._deleteProductButton.Text = "Удалить";
            this._deleteProductButton.UseVisualStyleBackColor = true;
            this._deleteProductButton.Click += new System.EventHandler(this.DeleteEntryButtonClick);
            // 
            // _addProductButton
            // 
            this._addProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._addProductButton.Enabled = false;
            this._addProductButton.Location = new System.Drawing.Point(6, 484);
            this._addProductButton.Name = "_addProductButton";
            this._addProductButton.Size = new System.Drawing.Size(150, 25);
            this._addProductButton.TabIndex = 1;
            this._addProductButton.Text = "Добавить";
            this._addProductButton.UseVisualStyleBackColor = true;
            this._addProductButton.Click += new System.EventHandler(this.AddEntryButtonClick);
            // 
            // _productsGrid
            // 
            this._productsGrid.AllowUserToAddRows = false;
            this._productsGrid.AllowUserToDeleteRows = false;
            this._productsGrid.AllowUserToOrderColumns = true;
            this._productsGrid.AllowUserToResizeRows = false;
            this._productsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._productsGrid.AutoGenerateColumns = false;
            this._productsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._productsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.CategoryId,
            this.SubjectId,
            this.mediaTypeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this._productsGrid.DataSource = this._productBindingSource;
            this._productsGrid.Location = new System.Drawing.Point(6, 6);
            this._productsGrid.Name = "_productsGrid";
            this._productsGrid.RowHeadersWidth = 47;
            this._productsGrid.Size = new System.Drawing.Size(1035, 472);
            this._productsGrid.TabIndex = 0;
            this._productsGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ProductGridCellFormatting);
            this._productsGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.GridCellValidating);
            this._productsGrid.SelectionChanged += new System.EventHandler(this.GridSelectionChanged);
            this._productsGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridKeyDown);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 70;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // CategoryId
            // 
            this.CategoryId.DataPropertyName = "CategoryId";
            this.CategoryId.DataSource = this._categoryBindingSource;
            this.CategoryId.DisplayMember = "Name";
            this.CategoryId.FillWeight = 86.12566F;
            this.CategoryId.HeaderText = "Категория";
            this.CategoryId.MinimumWidth = 6;
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CategoryId.ValueMember = "Id";
            // 
            // _categoryBindingSource
            // 
            this._categoryBindingSource.DataSource = typeof(OOP_CourseWork.Category);
            // 
            // SubjectId
            // 
            this.SubjectId.DataPropertyName = "SubjectId";
            this.SubjectId.DataSource = this._subjectBindingSource;
            this.SubjectId.DisplayMember = "Name";
            this.SubjectId.FillWeight = 86.12566F;
            this.SubjectId.HeaderText = "Тематика";
            this.SubjectId.MinimumWidth = 6;
            this.SubjectId.Name = "SubjectId";
            this.SubjectId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SubjectId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SubjectId.ValueMember = "Id";
            // 
            // _subjectBindingSource
            // 
            this._subjectBindingSource.DataSource = typeof(OOP_CourseWork.Subject);
            // 
            // mediaTypeDataGridViewTextBoxColumn
            // 
            this.mediaTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mediaTypeDataGridViewTextBoxColumn.DataPropertyName = "MediaType";
            this.mediaTypeDataGridViewTextBoxColumn.HeaderText = "Тип носителя";
            this.mediaTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mediaTypeDataGridViewTextBoxColumn.Name = "mediaTypeDataGridViewTextBoxColumn";
            this.mediaTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mediaTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 115;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 115;
            // 
            // _productBindingSource
            // 
            this._productBindingSource.AllowNew = true;
            this._productBindingSource.DataSource = typeof(OOP_CourseWork.Product);
            // 
            // _tabPage2
            // 
            this._tabPage2.Controls.Add(this._deleteTransactionButton);
            this._tabPage2.Controls.Add(this._addTransactionButton);
            this._tabPage2.Controls.Add(this._transactionsGrid);
            this._tabPage2.Location = new System.Drawing.Point(4, 24);
            this._tabPage2.Name = "_tabPage2";
            this._tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this._tabPage2.Size = new System.Drawing.Size(1047, 517);
            this._tabPage2.TabIndex = 1;
            this._tabPage2.Text = "Транзакции";
            this._tabPage2.UseVisualStyleBackColor = true;
            // 
            // _deleteTransactionButton
            // 
            this._deleteTransactionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._deleteTransactionButton.Enabled = false;
            this._deleteTransactionButton.Location = new System.Drawing.Point(162, 486);
            this._deleteTransactionButton.Name = "_deleteTransactionButton";
            this._deleteTransactionButton.Size = new System.Drawing.Size(150, 25);
            this._deleteTransactionButton.TabIndex = 4;
            this._deleteTransactionButton.Text = "Удалить";
            this._deleteTransactionButton.UseVisualStyleBackColor = true;
            this._deleteTransactionButton.Click += new System.EventHandler(this.DeleteEntryButtonClick);
            // 
            // _addTransactionButton
            // 
            this._addTransactionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._addTransactionButton.Enabled = false;
            this._addTransactionButton.Location = new System.Drawing.Point(6, 486);
            this._addTransactionButton.Name = "_addTransactionButton";
            this._addTransactionButton.Size = new System.Drawing.Size(150, 25);
            this._addTransactionButton.TabIndex = 3;
            this._addTransactionButton.Text = "Добавить";
            this._addTransactionButton.UseVisualStyleBackColor = true;
            this._addTransactionButton.Click += new System.EventHandler(this.AddEntryButtonClick);
            // 
            // _transactionsGrid
            // 
            this._transactionsGrid.AllowDrop = true;
            this._transactionsGrid.AllowUserToAddRows = false;
            this._transactionsGrid.AllowUserToDeleteRows = false;
            this._transactionsGrid.AllowUserToOrderColumns = true;
            this._transactionsGrid.AllowUserToResizeColumns = false;
            this._transactionsGrid.AllowUserToResizeRows = false;
            this._transactionsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._transactionsGrid.AutoGenerateColumns = false;
            this._transactionsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._transactionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._transactionsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.ProductId,
            this.PurchaseDate});
            this._transactionsGrid.DataSource = this._transactionBindingSource;
            this._transactionsGrid.Location = new System.Drawing.Point(6, 6);
            this._transactionsGrid.Name = "_transactionsGrid";
            this._transactionsGrid.RowHeadersWidth = 47;
            this._transactionsGrid.Size = new System.Drawing.Size(1035, 474);
            this._transactionsGrid.TabIndex = 1;
            this._transactionsGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.GridCellValidating);
            this._transactionsGrid.SelectionChanged += new System.EventHandler(this.GridSelectionChanged);
            this._transactionsGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridKeyDown);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 70;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.DataSource = this._productBindingSource;
            this.ProductId.DisplayMember = "DetailedName";
            this.ProductId.HeaderText = "Товар";
            this.ProductId.MinimumWidth = 6;
            this.ProductId.Name = "ProductId";
            this.ProductId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProductId.ValueMember = "Id";
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.DataPropertyName = "PurchaseDate";
            this.PurchaseDate.HeaderText = "Дата покупки";
            this.PurchaseDate.MinimumWidth = 6;
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PurchaseDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // _transactionBindingSource
            // 
            this._transactionBindingSource.AllowNew = true;
            this._transactionBindingSource.DataSource = typeof(OOP_CourseWork.Transaction);
            // 
            // _tabPage3
            // 
            this._tabPage3.Controls.Add(this._deleteCategoryButton);
            this._tabPage3.Controls.Add(this._addCategoryButton);
            this._tabPage3.Controls.Add(this._categoriesGrid);
            this._tabPage3.Location = new System.Drawing.Point(4, 24);
            this._tabPage3.Name = "_tabPage3";
            this._tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this._tabPage3.Size = new System.Drawing.Size(1047, 517);
            this._tabPage3.TabIndex = 2;
            this._tabPage3.Text = "Категории товаров";
            this._tabPage3.UseVisualStyleBackColor = true;
            // 
            // _deleteCategoryButton
            // 
            this._deleteCategoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._deleteCategoryButton.Enabled = false;
            this._deleteCategoryButton.Location = new System.Drawing.Point(162, 486);
            this._deleteCategoryButton.Name = "_deleteCategoryButton";
            this._deleteCategoryButton.Size = new System.Drawing.Size(150, 25);
            this._deleteCategoryButton.TabIndex = 4;
            this._deleteCategoryButton.Text = "Удалить";
            this._deleteCategoryButton.UseVisualStyleBackColor = true;
            this._deleteCategoryButton.Click += new System.EventHandler(this.DeleteEntryButtonClick);
            // 
            // _addCategoryButton
            // 
            this._addCategoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._addCategoryButton.Enabled = false;
            this._addCategoryButton.Location = new System.Drawing.Point(6, 486);
            this._addCategoryButton.Name = "_addCategoryButton";
            this._addCategoryButton.Size = new System.Drawing.Size(150, 25);
            this._addCategoryButton.TabIndex = 3;
            this._addCategoryButton.Text = "Добавить";
            this._addCategoryButton.UseVisualStyleBackColor = true;
            this._addCategoryButton.Click += new System.EventHandler(this.AddEntryButtonClick);
            // 
            // _categoriesGrid
            // 
            this._categoriesGrid.AllowUserToAddRows = false;
            this._categoriesGrid.AllowUserToDeleteRows = false;
            this._categoriesGrid.AllowUserToOrderColumns = true;
            this._categoriesGrid.AllowUserToResizeColumns = false;
            this._categoriesGrid.AllowUserToResizeRows = false;
            this._categoriesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._categoriesGrid.AutoGenerateColumns = false;
            this._categoriesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._categoriesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._categoriesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn1});
            this._categoriesGrid.DataSource = this._categoryBindingSource;
            this._categoriesGrid.Location = new System.Drawing.Point(6, 6);
            this._categoriesGrid.Name = "_categoriesGrid";
            this._categoriesGrid.RowHeadersWidth = 47;
            this._categoriesGrid.Size = new System.Drawing.Size(1035, 474);
            this._categoriesGrid.TabIndex = 1;
            this._categoriesGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.GridCellValidating);
            this._categoriesGrid.SelectionChanged += new System.EventHandler(this.GridSelectionChanged);
            this._categoriesGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridKeyDown);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.FillWeight = 52.35602F;
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Width = 70;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.FillWeight = 147.644F;
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // _tabPage4
            // 
            this._tabPage4.Controls.Add(this._deleteSubjectButton);
            this._tabPage4.Controls.Add(this._addSubjectButton);
            this._tabPage4.Controls.Add(this._subjectsGrid);
            this._tabPage4.Location = new System.Drawing.Point(4, 24);
            this._tabPage4.Name = "_tabPage4";
            this._tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this._tabPage4.Size = new System.Drawing.Size(1047, 517);
            this._tabPage4.TabIndex = 3;
            this._tabPage4.Text = "Тематики товаров";
            this._tabPage4.UseVisualStyleBackColor = true;
            // 
            // _deleteSubjectButton
            // 
            this._deleteSubjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._deleteSubjectButton.Enabled = false;
            this._deleteSubjectButton.Location = new System.Drawing.Point(162, 486);
            this._deleteSubjectButton.Name = "_deleteSubjectButton";
            this._deleteSubjectButton.Size = new System.Drawing.Size(150, 25);
            this._deleteSubjectButton.TabIndex = 4;
            this._deleteSubjectButton.Text = "Удалить";
            this._deleteSubjectButton.UseVisualStyleBackColor = true;
            this._deleteSubjectButton.Click += new System.EventHandler(this.DeleteEntryButtonClick);
            // 
            // _addSubjectButton
            // 
            this._addSubjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._addSubjectButton.Enabled = false;
            this._addSubjectButton.Location = new System.Drawing.Point(6, 486);
            this._addSubjectButton.Name = "_addSubjectButton";
            this._addSubjectButton.Size = new System.Drawing.Size(150, 25);
            this._addSubjectButton.TabIndex = 3;
            this._addSubjectButton.Text = "Добавить";
            this._addSubjectButton.UseVisualStyleBackColor = true;
            this._addSubjectButton.Click += new System.EventHandler(this.AddEntryButtonClick);
            // 
            // _subjectsGrid
            // 
            this._subjectsGrid.AllowUserToAddRows = false;
            this._subjectsGrid.AllowUserToDeleteRows = false;
            this._subjectsGrid.AllowUserToOrderColumns = true;
            this._subjectsGrid.AllowUserToResizeColumns = false;
            this._subjectsGrid.AllowUserToResizeRows = false;
            this._subjectsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._subjectsGrid.AutoGenerateColumns = false;
            this._subjectsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._subjectsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._subjectsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.nameDataGridViewTextBoxColumn2});
            this._subjectsGrid.DataSource = this._subjectBindingSource;
            this._subjectsGrid.Location = new System.Drawing.Point(6, 6);
            this._subjectsGrid.Name = "_subjectsGrid";
            this._subjectsGrid.RowHeadersWidth = 47;
            this._subjectsGrid.Size = new System.Drawing.Size(1035, 474);
            this._subjectsGrid.TabIndex = 1;
            this._subjectsGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.GridCellValidating);
            this._subjectsGrid.SelectionChanged += new System.EventHandler(this.GridSelectionChanged);
            this._subjectsGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridKeyDown);
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            this.idDataGridViewTextBoxColumn3.Width = 70;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // _menuStrip
            // 
            this._menuStrip.ImageScalingSize = new System.Drawing.Size(18, 18);
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._bdToolStripMenuItem,
            this._viewToolStripMenuItem,
            this._filterToolStripMenuItem});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(1079, 27);
            this._menuStrip.TabIndex = 6;
            this._menuStrip.Text = "menuStrip1";
            // 
            // _bdToolStripMenuItem
            // 
            this._bdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._createDbToolStripMenuItem,
            this._loadDbToolStripMenuItem,
            this._saveDbToolStripMenuItem,
            this._closeDbToolStripMenuItem,
            this._deleteDbToolStripMenuItem});
            this._bdToolStripMenuItem.Name = "_bdToolStripMenuItem";
            this._bdToolStripMenuItem.Size = new System.Drawing.Size(102, 23);
            this._bdToolStripMenuItem.Text = "База данных";
            // 
            // _createDbToolStripMenuItem
            // 
            this._createDbToolStripMenuItem.Name = "_createDbToolStripMenuItem";
            this._createDbToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this._createDbToolStripMenuItem.Text = "Создать";
            this._createDbToolStripMenuItem.Click += new System.EventHandler(this.CeateDbToolStripMenuItemClick);
            // 
            // _loadDbToolStripMenuItem
            // 
            this._loadDbToolStripMenuItem.Name = "_loadDbToolStripMenuItem";
            this._loadDbToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this._loadDbToolStripMenuItem.Text = "Загрузить";
            this._loadDbToolStripMenuItem.Click += new System.EventHandler(this.LoadDbToolStripMenuItemClick);
            // 
            // _saveDbToolStripMenuItem
            // 
            this._saveDbToolStripMenuItem.Enabled = false;
            this._saveDbToolStripMenuItem.Name = "_saveDbToolStripMenuItem";
            this._saveDbToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this._saveDbToolStripMenuItem.Text = "Сохранить";
            this._saveDbToolStripMenuItem.Click += new System.EventHandler(this.SaveDbToolStripMenuItemClick);
            // 
            // _closeDbToolStripMenuItem
            // 
            this._closeDbToolStripMenuItem.Enabled = false;
            this._closeDbToolStripMenuItem.Name = "_closeDbToolStripMenuItem";
            this._closeDbToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this._closeDbToolStripMenuItem.Text = "Закрыть";
            this._closeDbToolStripMenuItem.Click += new System.EventHandler(this.CloseDbToolStripMenuItemClick);
            // 
            // _deleteDbToolStripMenuItem
            // 
            this._deleteDbToolStripMenuItem.Enabled = false;
            this._deleteDbToolStripMenuItem.Name = "_deleteDbToolStripMenuItem";
            this._deleteDbToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this._deleteDbToolStripMenuItem.Text = "Удалить";
            this._deleteDbToolStripMenuItem.Click += new System.EventHandler(this.DeleteDbToolStripMenuItemClick);
            // 
            // _viewToolStripMenuItem
            // 
            this._viewToolStripMenuItem.CheckOnClick = true;
            this._viewToolStripMenuItem.Name = "_viewToolStripMenuItem";
            this._viewToolStripMenuItem.Size = new System.Drawing.Size(47, 23);
            this._viewToolStripMenuItem.Text = "Вид";
            // 
            // _filterToolStripMenuItem
            // 
            this._filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._applyFilterToolStripMenuItem,
            this._resetFilterToolStripMenuItem});
            this._filterToolStripMenuItem.Name = "_filterToolStripMenuItem";
            this._filterToolStripMenuItem.Size = new System.Drawing.Size(122, 23);
            this._filterToolStripMenuItem.Text = "Фильтр и поиск";
            // 
            // _applyFilterToolStripMenuItem
            // 
            this._applyFilterToolStripMenuItem.Enabled = false;
            this._applyFilterToolStripMenuItem.Name = "_applyFilterToolStripMenuItem";
            this._applyFilterToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this._applyFilterToolStripMenuItem.Text = "Отфильтровать по...";
            this._applyFilterToolStripMenuItem.Click += new System.EventHandler(this.ApplyFilterToolStripMenuItemClick);
            // 
            // _resetFilterToolStripMenuItem
            // 
            this._resetFilterToolStripMenuItem.Enabled = false;
            this._resetFilterToolStripMenuItem.Name = "_resetFilterToolStripMenuItem";
            this._resetFilterToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this._resetFilterToolStripMenuItem.Text = "Сбросить фильтр";
            this._resetFilterToolStripMenuItem.Click += new System.EventHandler(this.ResetFilterToolStripMenuItemClick);
            // 
            // _splitter
            // 
            this._splitter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._splitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._splitter.Location = new System.Drawing.Point(0, 29);
            this._splitter.Name = "_splitter";
            this._splitter.Size = new System.Drawing.Size(1079, 2);
            this._splitter.TabIndex = 7;
            this._splitter.Text = "SPLITTER";
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "Product";
            this.dataGridViewComboBoxColumn1.HeaderText = "Товар";
            this.dataGridViewComboBoxColumn1.MinimumWidth = 6;
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn1.Width = 493;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 493;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Product";
            this.dataGridViewTextBoxColumn2.HeaderText = "Товар";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Width = 493;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 591);
            this.Controls.Add(this._splitter);
            this.Controls.Add(this._tabControl);
            this.Controls.Add(this._menuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this._menuStrip;
            this.Name = "MainForm";
            this.Text = "Курсовой проект";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing);
            this.Shown += new System.EventHandler(this.MainFormShown);
            this._tabControl.ResumeLayout(false);
            this._tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._productsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._productBindingSource)).EndInit();
            this._tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._transactionsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._transactionBindingSource)).EndInit();
            this._tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._categoriesGrid)).EndInit();
            this._tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._subjectsGrid)).EndInit();
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.TabPage _tabPage1;
        private System.Windows.Forms.TabPage _tabPage2;
        private System.Windows.Forms.TabPage _tabPage3;
        private System.Windows.Forms.TabPage _tabPage4;
        private System.Windows.Forms.DataGridView _transactionsGrid;
        private System.Windows.Forms.DataGridView _categoriesGrid;
        private System.Windows.Forms.DataGridView _subjectsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource _categoryBindingSource;
        private System.Windows.Forms.BindingSource _subjectBindingSource;
        private System.Windows.Forms.BindingSource _transactionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.ToolStripMenuItem _bdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _loadDbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _saveDbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _createDbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _deleteDbToolStripMenuItem;
        private System.Windows.Forms.Label _splitter;
        private System.Windows.Forms.Button _deleteProductButton;
        private System.Windows.Forms.Button _addProductButton;
        private System.Windows.Forms.ToolStripMenuItem _filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _applyFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _resetFilterToolStripMenuItem;
        private System.Windows.Forms.Button _deleteTransactionButton;
        private System.Windows.Forms.Button _addTransactionButton;
        private System.Windows.Forms.Button _deleteCategoryButton;
        private System.Windows.Forms.Button _addCategoryButton;
        private System.Windows.Forms.Button _deleteSubjectButton;
        private System.Windows.Forms.Button _addSubjectButton;
        private System.Windows.Forms.ToolStripMenuItem _closeDbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _viewToolStripMenuItem;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.BindingSource _productBindingSource;
        private System.Windows.Forms.DataGridView _productsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn _categoryIdColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn _subjectIdColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn mediaTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn _productIdColumn;
        private DataGridViewCalendarColumn PurchaseDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewComboBoxColumn SubjectId;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductId;
    }
}

