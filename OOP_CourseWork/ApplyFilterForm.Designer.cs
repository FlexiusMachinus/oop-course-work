
namespace OOP_CourseWork
{
    partial class ApplyFilterForm
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
            this._filterPropertyComboBox = new System.Windows.Forms.ComboBox();
            this._filterPropertyLabel = new System.Windows.Forms.Label();
            this._filterTypeLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._filterTypeComboBox = new System.Windows.Forms.ComboBox();
            this._dateFilterTypeComboBox = new System.Windows.Forms.ComboBox();
            this._searchTextbox = new System.Windows.Forms.TextBox();
            this._isCaseSensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this._useRegexCheckBox = new System.Windows.Forms.CheckBox();
            this._dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this._filterParam1Numeric = new System.Windows.Forms.NumericUpDown();
            this._filterTypeLabel = new System.Windows.Forms.Label();
            this._filterParamsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._rangeMinLabel = new System.Windows.Forms.Label();
            this._rangeMaxLabel = new System.Windows.Forms.Label();
            this._filterParam2Numeric = new System.Windows.Forms.NumericUpDown();
            this._dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this._applyButton = new System.Windows.Forms.Button();
            this._fixedValuesComboBox = new OOP_CourseWork.CheckComboBox();
            this._filterTypeLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._filterParam1Numeric)).BeginInit();
            this._filterParamsLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._filterParam2Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // _filterPropertyComboBox
            // 
            this._filterPropertyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._filterPropertyComboBox.FormattingEnabled = true;
            this._filterPropertyComboBox.Location = new System.Drawing.Point(104, 12);
            this._filterPropertyComboBox.Name = "_filterPropertyComboBox";
            this._filterPropertyComboBox.Size = new System.Drawing.Size(393, 23);
            this._filterPropertyComboBox.TabIndex = 0;
            this._filterPropertyComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterPropertyChanged);
            // 
            // _filterPropertyLabel
            // 
            this._filterPropertyLabel.AutoSize = true;
            this._filterPropertyLabel.Location = new System.Drawing.Point(12, 15);
            this._filterPropertyLabel.Name = "_filterPropertyLabel";
            this._filterPropertyLabel.Size = new System.Drawing.Size(86, 16);
            this._filterPropertyLabel.TabIndex = 1;
            this._filterPropertyLabel.Text = "По колонке:";
            // 
            // _filterTypeLayoutPanel
            // 
            this._filterTypeLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._filterTypeLayoutPanel.Controls.Add(this._filterTypeComboBox);
            this._filterTypeLayoutPanel.Controls.Add(this._dateFilterTypeComboBox);
            this._filterTypeLayoutPanel.Controls.Add(this._fixedValuesComboBox);
            this._filterTypeLayoutPanel.Controls.Add(this._searchTextbox);
            this._filterTypeLayoutPanel.Controls.Add(this._isCaseSensitiveCheckBox);
            this._filterTypeLayoutPanel.Controls.Add(this._useRegexCheckBox);
            this._filterTypeLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._filterTypeLayoutPanel.Location = new System.Drawing.Point(101, 41);
            this._filterTypeLayoutPanel.Name = "_filterTypeLayoutPanel";
            this._filterTypeLayoutPanel.Size = new System.Drawing.Size(616, 165);
            this._filterTypeLayoutPanel.TabIndex = 2;
            // 
            // _filterTypeComboBox
            // 
            this._filterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._filterTypeComboBox.FormattingEnabled = true;
            this._filterTypeComboBox.Items.AddRange(new object[] {
            "Меньше",
            "Равно",
            "Больше",
            "В диапазоне"});
            this._filterTypeComboBox.Location = new System.Drawing.Point(3, 3);
            this._filterTypeComboBox.Name = "_filterTypeComboBox";
            this._filterTypeComboBox.Size = new System.Drawing.Size(125, 23);
            this._filterTypeComboBox.TabIndex = 1;
            this._filterTypeComboBox.Visible = false;
            this._filterTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterTypeChanged);
            // 
            // _dateFilterTypeComboBox
            // 
            this._dateFilterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._dateFilterTypeComboBox.FormattingEnabled = true;
            this._dateFilterTypeComboBox.Items.AddRange(new object[] {
            "До",
            "В день",
            "После",
            "В диапазоне"});
            this._dateFilterTypeComboBox.Location = new System.Drawing.Point(3, 32);
            this._dateFilterTypeComboBox.Name = "_dateFilterTypeComboBox";
            this._dateFilterTypeComboBox.Size = new System.Drawing.Size(125, 23);
            this._dateFilterTypeComboBox.TabIndex = 15;
            this._dateFilterTypeComboBox.Visible = false;
            this._dateFilterTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.DateFilterTypeChanged);
            // 
            // _searchTextbox
            // 
            this._searchTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._searchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._searchTextbox.Location = new System.Drawing.Point(3, 89);
            this._searchTextbox.Name = "_searchTextbox";
            this._searchTextbox.Size = new System.Drawing.Size(393, 21);
            this._searchTextbox.TabIndex = 14;
            this._searchTextbox.Visible = false;
            // 
            // _isCaseSensitiveCheckBox
            // 
            this._isCaseSensitiveCheckBox.AutoSize = true;
            this._isCaseSensitiveCheckBox.Location = new System.Drawing.Point(3, 116);
            this._isCaseSensitiveCheckBox.Name = "_isCaseSensitiveCheckBox";
            this._isCaseSensitiveCheckBox.Size = new System.Drawing.Size(153, 20);
            this._isCaseSensitiveCheckBox.TabIndex = 12;
            this._isCaseSensitiveCheckBox.Text = "Учитывать регистр";
            this._isCaseSensitiveCheckBox.UseVisualStyleBackColor = true;
            this._isCaseSensitiveCheckBox.Visible = false;
            // 
            // _useRegexCheckBox
            // 
            this._useRegexCheckBox.AutoSize = true;
            this._useRegexCheckBox.Location = new System.Drawing.Point(3, 142);
            this._useRegexCheckBox.Name = "_useRegexCheckBox";
            this._useRegexCheckBox.Size = new System.Drawing.Size(278, 20);
            this._useRegexCheckBox.TabIndex = 13;
            this._useRegexCheckBox.Text = "Использовать регулярные выражения";
            this._useRegexCheckBox.UseVisualStyleBackColor = true;
            this._useRegexCheckBox.Visible = false;
            // 
            // _dateTimePicker1
            // 
            this._dateTimePicker1.CustomFormat = "";
            this._dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._dateTimePicker1.Location = new System.Drawing.Point(132, 3);
            this._dateTimePicker1.Name = "_dateTimePicker1";
            this._dateTimePicker1.Size = new System.Drawing.Size(100, 21);
            this._dateTimePicker1.TabIndex = 6;
            this._dateTimePicker1.Visible = false;
            // 
            // _filterParam1Numeric
            // 
            this._filterParam1Numeric.Location = new System.Drawing.Point(26, 3);
            this._filterParam1Numeric.Name = "_filterParam1Numeric";
            this._filterParam1Numeric.Size = new System.Drawing.Size(100, 21);
            this._filterParam1Numeric.TabIndex = 0;
            this._filterParam1Numeric.Visible = false;
            // 
            // _filterTypeLabel
            // 
            this._filterTypeLabel.AutoSize = true;
            this._filterTypeLabel.Location = new System.Drawing.Point(12, 46);
            this._filterTypeLabel.Name = "_filterTypeLabel";
            this._filterTypeLabel.Size = new System.Drawing.Size(86, 16);
            this._filterTypeLabel.TabIndex = 3;
            this._filterTypeLabel.Text = "Параметры:";
            // 
            // _filterParamsLayoutPanel
            // 
            this._filterParamsLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._filterParamsLayoutPanel.Controls.Add(this._rangeMinLabel);
            this._filterParamsLayoutPanel.Controls.Add(this._filterParam1Numeric);
            this._filterParamsLayoutPanel.Controls.Add(this._dateTimePicker1);
            this._filterParamsLayoutPanel.Controls.Add(this._rangeMaxLabel);
            this._filterParamsLayoutPanel.Controls.Add(this._filterParam2Numeric);
            this._filterParamsLayoutPanel.Controls.Add(this._dateTimePicker2);
            this._filterParamsLayoutPanel.Location = new System.Drawing.Point(231, 41);
            this._filterParamsLayoutPanel.Name = "_filterParamsLayoutPanel";
            this._filterParamsLayoutPanel.Size = new System.Drawing.Size(486, 28);
            this._filterParamsLayoutPanel.TabIndex = 4;
            // 
            // _rangeMinLabel
            // 
            this._rangeMinLabel.AutoSize = true;
            this._rangeMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._rangeMinLabel.Location = new System.Drawing.Point(0, 5);
            this._rangeMinLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this._rangeMinLabel.Name = "_rangeMinLabel";
            this._rangeMinLabel.Size = new System.Drawing.Size(23, 16);
            this._rangeMinLabel.TabIndex = 6;
            this._rangeMinLabel.Text = "от";
            this._rangeMinLabel.Visible = false;
            // 
            // _rangeMaxLabel
            // 
            this._rangeMaxLabel.AutoSize = true;
            this._rangeMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._rangeMaxLabel.Location = new System.Drawing.Point(235, 5);
            this._rangeMaxLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this._rangeMaxLabel.Name = "_rangeMaxLabel";
            this._rangeMaxLabel.Size = new System.Drawing.Size(24, 16);
            this._rangeMaxLabel.TabIndex = 5;
            this._rangeMaxLabel.Text = "до";
            this._rangeMaxLabel.Visible = false;
            // 
            // _filterParam2Numeric
            // 
            this._filterParam2Numeric.Location = new System.Drawing.Point(262, 3);
            this._filterParam2Numeric.Name = "_filterParam2Numeric";
            this._filterParam2Numeric.Size = new System.Drawing.Size(100, 21);
            this._filterParam2Numeric.TabIndex = 1;
            this._filterParam2Numeric.Visible = false;
            // 
            // _dateTimePicker2
            // 
            this._dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._dateTimePicker2.Location = new System.Drawing.Point(368, 3);
            this._dateTimePicker2.Name = "_dateTimePicker2";
            this._dateTimePicker2.Size = new System.Drawing.Size(100, 21);
            this._dateTimePicker2.TabIndex = 7;
            this._dateTimePicker2.Visible = false;
            // 
            // _applyButton
            // 
            this._applyButton.Location = new System.Drawing.Point(12, 122);
            this._applyButton.Name = "_applyButton";
            this._applyButton.Size = new System.Drawing.Size(125, 27);
            this._applyButton.TabIndex = 5;
            this._applyButton.Text = "Применить";
            this._applyButton.UseVisualStyleBackColor = true;
            this._applyButton.Click += new System.EventHandler(this.ApplyButtonClick);
            // 
            // _fixedValuesComboBox
            // 
            this._fixedValuesComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this._fixedValuesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._fixedValuesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._fixedValuesComboBox.FormattingEnabled = true;
            this._fixedValuesComboBox.Location = new System.Drawing.Point(3, 61);
            this._fixedValuesComboBox.Name = "_fixedValuesComboBox";
            this._fixedValuesComboBox.PlaceholderText = "Выберите опции";
            this._fixedValuesComboBox.Size = new System.Drawing.Size(393, 22);
            this._fixedValuesComboBox.TabIndex = 2;
            this._fixedValuesComboBox.Visible = false;
            // 
            // ApplyFilterForm
            // 
            this.AcceptButton = this._applyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 218);
            this.Controls.Add(this._applyButton);
            this.Controls.Add(this._filterParamsLayoutPanel);
            this.Controls.Add(this._filterTypeLabel);
            this.Controls.Add(this._filterTypeLayoutPanel);
            this.Controls.Add(this._filterPropertyLabel);
            this.Controls.Add(this._filterPropertyComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 200);
            this.Name = "ApplyFilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Применить фильтр";
            this.Shown += new System.EventHandler(this.ApplyFilterFormShown);
            this._filterTypeLayoutPanel.ResumeLayout(false);
            this._filterTypeLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._filterParam1Numeric)).EndInit();
            this._filterParamsLayoutPanel.ResumeLayout(false);
            this._filterParamsLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._filterParam2Numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _filterPropertyComboBox;
        private System.Windows.Forms.Label _filterPropertyLabel;
        private System.Windows.Forms.FlowLayoutPanel _filterTypeLayoutPanel;
        private System.Windows.Forms.NumericUpDown _filterParam1Numeric;
        private CheckComboBox _fixedValuesComboBox;
        private System.Windows.Forms.Label _filterTypeLabel;
        private System.Windows.Forms.FlowLayoutPanel _filterParamsLayoutPanel;
        private System.Windows.Forms.NumericUpDown _filterParam2Numeric;
        private System.Windows.Forms.Label _rangeMinLabel;
        private System.Windows.Forms.Label _rangeMaxLabel;
        private System.Windows.Forms.ComboBox _filterTypeComboBox;
        private System.Windows.Forms.Button _applyButton;
        private System.Windows.Forms.TextBox _searchTextbox;
        private System.Windows.Forms.CheckBox _isCaseSensitiveCheckBox;
        private System.Windows.Forms.CheckBox _useRegexCheckBox;
        private System.Windows.Forms.DateTimePicker _dateTimePicker1;
        private System.Windows.Forms.DateTimePicker _dateTimePicker2;
        private System.Windows.Forms.ComboBox _dateFilterTypeComboBox;
    }
}