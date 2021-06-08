using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace OOP_CourseWork
{
    /// <summary>
    /// Представляет форму для выбора параметров фильтрации.
    /// </summary>
    public partial class ApplyFilterForm : Form
    {
        // Индексы опций в ComboBox, соотвутствующие режимам фильтрации по диапазону
        private const int NumericFilterRangeIndex = 3;
        private const int DateTimeFilterRangeIndex = 3;

        // Данные, необходимые для формирования возможных параметров фильтрации
        private readonly List<ColumnFilterInfo> _filterInfoList;

        private ApplyFilterForm()
        {
            InitializeComponent();
            ActiveControl = _filterPropertyComboBox;
        }

        /// <summary>
        /// Создает новую форму для выбора параметров фильтрации.
        /// </summary>
        /// <param name="grid">Таблица, для щначений которых необходимо выбрать параметры фильтрации.</param>
        public ApplyFilterForm(DataGridView grid) : this()
        {
            _filterInfoList = PrepareFilterInfo(grid);

            foreach (var info in _filterInfoList)
                _filterPropertyComboBox.Items.Add(info.ColumnName);

            _filterPropertyComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Представляет предикат для фильтрации.
        /// </summary>
        public IColumnFilterer ColumnFilterer { get; private set; }

        /// <summary>
        /// Изменяет размер клиентской части и положение кнопки при отображении формы.
        /// </summary>
        private void ApplyFilterFormShown(object sender, EventArgs e)
        {
            Size = MinimumSize;
            _applyButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - _applyButton.Size.Width / 2, _applyButton.Location.Y);
        }

        /// <summary>
        /// Меняет параметры отображения и настраивает необходимые элементы управления
        /// при выборе свойства, по которому выполняется фильтрация.
        /// </summary>
        private void FilterPropertyChanged(object sender, EventArgs e)
        {
            int index = _filterPropertyComboBox.SelectedIndex;
            if (index == -1)
                return;

            ColumnFilterInfo filterInfo = _filterInfoList[_filterPropertyComboBox.SelectedIndex];
            bool isFixedValue = (filterInfo.AllowedValues != null);
            bool isNumeric = (!isFixedValue && filterInfo.ValueType.IsNumericType());
            bool isString = (!isFixedValue && filterInfo.ValueType == typeof(string));
            bool isDate = (!isFixedValue && filterInfo.ValueType == typeof(DateTime));

            _filterParamsLayoutPanel.Visible = isNumeric || isDate;
            SetFixedValuesControlsVisibility(isFixedValue);
            SetNumericControlsVisibility(isNumeric);
            SetSearchControlsVisibility(isString);
            SetDateTimeControlsVisibility(isDate);
        }

        /// <summary>
        /// Настраивает элементы управления, необходимые для фильтрации фиксированных значений.
        /// </summary>
        private void SetFixedValuesControlsVisibility(bool isVisible)
        {
            _fixedValuesComboBox.Visible = isVisible;
            if (isVisible)
            {
                _fixedValuesComboBox.Items.Clear();
                foreach (var value in _filterInfoList[_filterPropertyComboBox.SelectedIndex].AllowedValues)
                    _fixedValuesComboBox.Items.Add(new CheckComboBoxItem(value.ToString()));
            }
        }

        /// <summary>
        /// Настраивает элементы управления, необходимые для фильтрации по числам.
        /// </summary>
        private void SetNumericControlsVisibility(bool isVisible)
        {
            _filterTypeComboBox.Visible = isVisible;
            _filterParam1Numeric.Visible = isVisible;

            if (isVisible)
            {
                // Определение допустимого диапазона в соответствии с типом данных
                var typeRange = Utils.GetNumericTypeRange(_filterInfoList[_filterPropertyComboBox.SelectedIndex].ValueType);
                decimal minValue = Convert.ToDecimal(typeRange.Item1);
                decimal maxValue = Convert.ToDecimal(typeRange.Item2);

                _filterParam1Numeric.Minimum = minValue;
                _filterParam1Numeric.Maximum = maxValue;
                _filterParam2Numeric.Minimum = minValue;
                _filterParam2Numeric.Maximum = maxValue;

                if (_filterTypeComboBox.SelectedIndex == -1)
                {
                    _filterTypeComboBox.SelectedIndex = 0;
                }
                else
                {
                    _filterParam2Numeric.Visible = (_filterTypeComboBox.SelectedIndex == NumericFilterRangeIndex);
                }
            }
            else
            {
                _filterParam1Numeric.Value = 0;
                _filterParam2Numeric.Value = 0;
                _filterTypeComboBox.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Настраивает элементы управления, необходимые для строкового поиска.
        /// </summary>
        private void SetSearchControlsVisibility(bool isVisible)
        {
            _searchTextbox.Visible = isVisible;
            _isCaseSensitiveCheckBox.Visible = isVisible;
            _useRegexCheckBox.Visible = isVisible;
            if (!isVisible)
            {
                _searchTextbox.Text = String.Empty;
                _isCaseSensitiveCheckBox.Checked = false;
                _useRegexCheckBox.Checked = false;
            }
        }

        /// <summary>
        /// Настраивает элементы управления, необходимые для фильтрации по дате и времени.
        /// </summary>
        private void SetDateTimeControlsVisibility(bool isVisible)
        {
            _dateFilterTypeComboBox.Visible = isVisible;
            _dateTimePicker1.Visible = isVisible;
            if (isVisible)
            {
                if (_dateFilterTypeComboBox.SelectedIndex == -1)
                {
                    _dateFilterTypeComboBox.SelectedIndex = 0;
                }
                else
                {
                    _dateTimePicker2.Visible = (_dateFilterTypeComboBox.SelectedIndex == DateTimeFilterRangeIndex);
                }
            }
            else
            {
                _dateTimePicker1.Value = DateTime.Now;
                _dateTimePicker2.Value = DateTime.Now;
                _dateFilterTypeComboBox.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Настраивает необходимые элементы управления при изменении типа фильтра по числам.
        /// </summary>
        private void FilterTypeChanged(object sender, EventArgs e)
        {
            bool isRange = (_filterTypeComboBox.SelectedIndex == NumericFilterRangeIndex);
            _filterParam2Numeric.Visible = isRange;
            _rangeMinLabel.Visible = isRange;
            _rangeMaxLabel.Visible = isRange;
        }

        /// <summary>
        /// Настраивает необходимые элементы управления при изменении типа фильтра по дате и времени.
        /// </summary>
        private void DateFilterTypeChanged(object sender, EventArgs e)
        {
            bool isRange = (_dateFilterTypeComboBox.SelectedIndex == DateTimeFilterRangeIndex);
            _dateTimePicker2.Visible = isRange;
            _rangeMinLabel.Visible = isRange;
            _rangeMaxLabel.Visible = isRange;
        }

        /// <summary>
        /// Формирует выбранные параметры фильтрации при нажатии на кнопку применения фильтра.
        /// </summary>
        private void ApplyButtonClick(object sender, EventArgs e)
        {
            // Проверка численного диапазона
            if (_filterTypeComboBox.SelectedIndex == NumericFilterRangeIndex && _filterParam1Numeric.Value >= _filterParam2Numeric.Value)
            {
                MessageBox.Show("Максимальное значение диапазона должно быть больше минимального!", "Фильтр", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка диапазона даты и времени
            if (_dateFilterTypeComboBox.SelectedIndex == DateTimeFilterRangeIndex && _dateTimePicker1.Value >= _dateTimePicker2.Value)
            {
                MessageBox.Show("Начальная дата должна быть меньше конечной!", "Фильтр", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка корректности строковых параметров
            if (_searchTextbox.Visible)
            {
                if (String.IsNullOrEmpty(_searchTextbox.Text))
                {
                    MessageBox.Show("Введите строку для поиска!", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Проверка корректности регулярного выражения
                try
                {
                    Regex.IsMatch(String.Empty, _searchTextbox.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Неверный формат регулярного выражения: {exception.Message}", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Определяем тип фильтрации
            ColumnFilterInfo filterInfo = _filterInfoList[_filterPropertyComboBox.SelectedIndex];
            bool isFixedValue = (filterInfo.AllowedValues != null);
            bool isNumeric = (!isFixedValue && filterInfo.ValueType.IsNumericType());
            bool isString = (!isFixedValue && filterInfo.ValueType == typeof(string));
            
            // Назначаем параметры фильтрации в соответствии с типом фильтра
            if (isFixedValue)
            {
                ColumnFilterer = ApplyFixedValueFiltering(filterInfo);
            }
            else if (isNumeric)
            {
                ColumnFilterer = ApplyNumericFiltering(filterInfo);
            }
            else if (isString)
            {
                ColumnFilterer = ApplySearchFiltering(filterInfo);
            }
            else
            {
                ColumnFilterer = ApplyDateTimeFiltering(filterInfo);
            }

            // Отправляем результат диалога на родительскую форму
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Формирует параметры фильтрации для фиксированных значений.
        /// </summary>
        private ColumnFilterer<object> ApplyFixedValueFiltering(ColumnFilterInfo filterInfo)
        {
            if (filterInfo == null)
                throw new ArgumentException("Filter info cannot be null.");

            var filteredValues = new List<object>();
            int i = 0;
            foreach (var allowedValue in filterInfo.AllowedValues)
            {
                if (_fixedValuesComboBox.Items[i++] is CheckComboBoxItem item && item.Checked)
                    filteredValues.Add(allowedValue);
            }

            Func<object, object> propGetter = obj => filterInfo.GetPropertyValue(obj);
            Predicate<object> filterPredicate = obj => filteredValues.Contains(obj);

            return new ColumnFilterer<object>(propGetter, filterPredicate);
        }

        /// <summary>
        /// Формирует параметры фильтрации для численных значений.
        /// </summary>
        private ColumnFilterer<IComparable> ApplyNumericFiltering(ColumnFilterInfo filterInfo)
        {
            if (filterInfo == null)
                throw new ArgumentException("Filter info cannot be null.");

            int comparisonType = _filterTypeComboBox.SelectedIndex;
            IComparable param1 = Utils.ConvertToNumeric(_filterParam1Numeric.Value, filterInfo.ValueType);
            Predicate<IComparable> filterPredicate = null;

            switch (comparisonType)
            {
                case 0:
                case 1:
                case 2:
                    // Индексы элементов в ComboBox: 0 - "меньше", 1 - "равно", 2 - "больше"
                    // IComparable#CompareTo возвращает: -1 - при меньшем, 0 - при равном, 1 - при большем значении
                    filterPredicate = number => number.CompareTo(param1) == comparisonType - 1; 
                    break;

                case 3:
                    IComparable param2 = Utils.ConvertToNumeric(_filterParam2Numeric.Value, filterInfo.ValueType);
                    filterPredicate = number => (number.CompareTo(param1) >= 0 && number.CompareTo(param2) <= 0);
                    break;
            }

            Func<object, IComparable> propGetter = (obj) => filterInfo.GetPropertyValue<IComparable>(obj);

            return new ColumnFilterer<IComparable>(propGetter, filterPredicate);
        }

        /// <summary>
        /// Формирует параметры фильтрации для строковых значений.
        /// </summary>
        private ColumnFilterer<string> ApplySearchFiltering(ColumnFilterInfo filterInfo)
        {
            if (filterInfo == null)
                throw new ArgumentException("Filter info cannot be null.");

            string query = _searchTextbox.Text;

            Func<object, string> propGetter = (obj) => filterInfo.GetPropertyValue<string>(obj);
            Predicate<string> filterPredicate;

            if (_useRegexCheckBox.Checked)
            {
                filterPredicate = (str) => Regex.IsMatch(str, query);
            }
            else
            {
                StringComparison comparisonType = (_isCaseSensitiveCheckBox.Checked ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase);
                filterPredicate = (str) =>
                {
                    return str.IndexOf(query, comparisonType) >= 0;
                };
            }

            return new ColumnFilterer<string>(propGetter, filterPredicate);
        }

        /// <summary>
        /// Формирует параметры фильтрации для значений даты и времени.
        /// </summary>
        private ColumnFilterer<DateTime> ApplyDateTimeFiltering(ColumnFilterInfo filterInfo)
        {
            if (filterInfo == null)
                throw new ArgumentException("Filter info cannot be null.");

            Func<object, DateTime> propGetter = (obj) => filterInfo.GetPropertyValue<DateTime>(obj);
            Predicate<DateTime> filterPredicate = null;

            int comparisonType = _dateFilterTypeComboBox.SelectedIndex;
            switch (comparisonType)
            {
                case 0:
                case 1:
                case 2:
                    // Индексы элементов в ComboBox: 0 - "до", 1 - "в день", 2 - "после"
                    // IComparable#CompareTo возвращает: -1 - при меньшем, 0 - при равном, 1 - при большем значении
                    filterPredicate = (dateTime) =>
                    {
                        return dateTime.Date.CompareTo(_dateTimePicker1.Value.Date) == comparisonType - 1;
                    }; 
                    break;

                case 3:
                    filterPredicate = (dateTime) => (dateTime.Date.CompareTo(_dateTimePicker1.Value.Date) >= 0 &&
                                                     dateTime.Date.CompareTo(_dateTimePicker2.Value.Date) <= 0);
                    break;
            }

            return new ColumnFilterer<DateTime>(propGetter, filterPredicate);
        }

        /// <summary>
        /// Формирует данные, необходимые для фильтрации записей заданной таблицы.
        /// </summary>
        /// <param name="grid">Таблица, записи которой готовятся к фильтрации.</param>
        private static List<ColumnFilterInfo> PrepareFilterInfo(DataGridView grid)
        {
            Type sourceType = ListBindingHelper.GetListItemType(grid.DataSource);

            var filterInfoList = new List<ColumnFilterInfo>();
            foreach (DataGridViewColumn column in grid.Columns)
            {
                // Не добавлять фильтрацию по спрятанным колонкам
                if (!column.Visible)
                    continue;

                // Данные для фильтрации 
                ColumnFilterInfo filterInfo = null;

                // Тип значения, хранимый в данной колонке
                Type valueType = column.ValueType;
                // Свойство объекта, соответствующее данной колонке
                PropertyInfo filterProperty = sourceType.GetProperty(column.DataPropertyName);
                // Делегат, возвращающий значение вынеописанного свойства переданного в него объекта 
                Func<object, object> propGetter = (obj) => filterProperty.GetValue(obj);
                // Перечислитель допустимых значений
                System.Collections.IEnumerable allowedValues = null;

                if (column is DataGridViewComboBoxColumn comboBoxColumn)
                {
                    if (comboBoxColumn.DataPropertyName == "ProductId")
                    {
                        // Тип фильтрации для колонки товаров - поиск по строке
                        valueType = typeof(string);
                        propGetter = (obj) => ((Transaction)obj).Product.DetailedName;
                    }
                    else if (comboBoxColumn.Items.Count > 0)
                    {
                        // Иначе - выбор из конечного (ненулевого) набора значений
                        if (comboBoxColumn.IsDataBound && column.ValueType == typeof(int))
                        {
                            propGetter = obj =>
                            {
                                int index = (int)filterProperty.GetValue(obj);
                                return comboBoxColumn.Items[index - 1];
                            };
                        }

                        valueType = comboBoxColumn.Items[0].GetType();
                        allowedValues = comboBoxColumn.Items;
                    }
                }
                else if (!valueType.IsNumericType() && valueType != typeof(string) && valueType != typeof(DateTime))
                {
                    // Если тип не относится ни к одному из перечисленных, выбрать в качестве фильтрации поиск по строке
                    valueType = typeof(string);
                }

                // Создает экземпляр обобщенного типа ColumnFilterInfo<> для парамтера типа sourceType с помощью рефлексии
                Type genericType = typeof(ColumnFilterInfo<>).MakeGenericType(sourceType);
                filterInfo = (ColumnFilterInfo)Activator.CreateInstance(genericType, column.HeaderText, valueType, propGetter, allowedValues);

                filterInfoList.Add(filterInfo);
            }

            return filterInfoList;
        }

        /// <summary>
        /// Закрывает форму при нажатии на клавишу Escape.
        /// </summary>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Abort;
                Close();
            }
        }
    }
}