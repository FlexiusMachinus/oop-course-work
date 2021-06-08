using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;

namespace OOP_CourseWork
{
    /// <summary>
    /// Представляет форму для добавления новых записей.
    /// </summary>
    public partial class AddEntryForm : Form
    {
        // Ширина элементов управления для редактирования
        private const int EditorControlWidth = 300;
        // Отступ от краев формы
        private const int FormPadding = 12;

        // Тип добавляемого значения
        private Type _entryType;
        // Таблица, в которую добавляется значение
        private DataGridView _grid;

        // Словарь с элементами управления, используемыми для редактирования значений свойств новой записи,
        // а также соотвутствующими им делегатами, ссылающимися на данные свойства.
        private Dictionary<Control, Action<object, object>> _propSetters = new Dictionary<Control, Action<object, object>>();

        private AddEntryForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Создает новую форму для добавления новых записей в заданную таблицу.
        /// </summary>
        /// <param name="grid">Таблица, в которую будут добавляться новые записи.</param>
        public AddEntryForm(DataGridView grid) : this()
        {
            _grid = grid;
            _entryType = ListBindingHelper.GetListItemType((grid.DataSource as BindingSource)?.DataSource);

            InitializeSetters();
        }

        /// <summary>
        /// Новая запись, добавляемая на форму.
        /// </summary>
        public object NewEntry { get; private set; }

        /// <summary>
        /// Инициализирует все необходимые поля, а также их логику, для автоматической установки значений свойств для создаваемой записи.
        /// </summary>
        private void InitializeSetters()
        {
            // Положение следующего элемента управления
            Point newLocation = new Point(FormPadding, FormPadding);

            foreach (DataGridViewColumn column in _grid.Columns)
            {
                // Не создаем поле для редактирования идентификатора
                if (column.DataPropertyName == "Id")
                    continue;

                Label label = CreatePropertyLabel(column);
                Control propEditor = CreatePropertyEditor(column);

                if (propEditor == null)
                    continue;

                // Добавляем подпись
                label.Location = newLocation;
                Controls.Add(label);

                // Доавляем элемент управления-редактор
                propEditor.Location = new Point(newLocation.X + label.Width + label.Margin.Right * 2, newLocation.Y);
                propEditor.Size = new Size(EditorControlWidth, propEditor.Height);
                Controls.Add(propEditor);

                // Ставим фокус на первом элементе управления
                if (ActiveControl == null)
                    ActiveControl = propEditor;

                // Добавляем элемент управления и делегат в словарь
                _propSetters.Add(propEditor, CreatePropertySetter(column));

                // Задаем положения для следующего элемента
                newLocation = new Point(newLocation.X, newLocation.Y + label.Height + label.Margin.Top);
            }

            // Обновляем размер формы
            Control lastControl = Controls[Controls.Count - 1];
            ClientSize = new Size(lastControl.Bounds.Right + FormPadding, newLocation.Y + _addButton.Height + FormPadding);

            // Обновляем положение кнопки
            _addButton.Location = new Point(ClientSize.Width / 2 - _addButton.Width / 2, newLocation.Y + _addButton.Margin.Top);
        }

        /// <summary>
        /// Формирует новую запись при нажатии соответствующей кнопки на форме.
        /// </summary>
        private void AddButtonClick(object sender, EventArgs e)
        {
            // Создаем новую запись
            object newEntry = Activator.CreateInstance(_entryType, true);

            // Вычисляем новый Id
            int lastId = (_grid.Rows.Count > 0) ? (int)_grid.Rows[_grid.Rows.Count - 1].Cells[0].Value : 0;
            _entryType.GetProperty("Id")?.SetValue(newEntry, lastId + 1);

            // Устанавливаем свойствам новой записи значения с формы
            foreach (var keyVal in _propSetters)
            {
                Control editor = keyVal.Key;
                Action<object, object> propSetter = keyVal.Value;

                if (editor is ComboBox comboBox) // Установка фиксированных значений
                {
                    // Установка фактического значения
                    object selectedItem = comboBox.SelectedItem;
                    if (String.IsNullOrEmpty(comboBox.ValueMember))
                    {
                        propSetter(newEntry, selectedItem);
                    }
                    else
                    {
                        PropertyInfo valueMember = selectedItem.GetType().GetProperty(comboBox.ValueMember);
                        propSetter(newEntry, valueMember.GetValue(selectedItem));
                    }
                }
                else if (editor is NumericUpDown numeric) // Установка численных значений
                {
                    propSetter(newEntry, numeric.Value);
                }
                else if (editor is TextBox textbox) // Установка строковых значений
                {
                    propSetter(newEntry, textbox.Text);
                }
                else if (editor is DateTimePicker dateTimePicker) // Установка значений даты и времени
                {
                    propSetter(newEntry, dateTimePicker.Value);
                }
            }

            // Отправляем результат диалога на родительскую форму
            NewEntry = newEntry;
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Создает надпись с названием заданного свойства.
        /// </summary>
        /// <param name="column">Колонка, соотвутствующая заданному свойству.</param>
        /// <returns>Элемент типа <see cref="Label"/> с названием свойства.</returns>
        private Label CreatePropertyLabel(DataGridViewColumn column)
        {
            return new Label()
            {
                Text = column.HeaderText,
                Margin = new Padding(3, 3, 3, 3)
            };
        }

        /// <summary>
        /// Создает элемент управления для редактирования значения заданного свойства.
        /// </summary>
        /// <param name="column">Колонка, соотвутствующая заданному свойству.</param>
        /// <returns>Элемент управления для редактирования значения заданного свойства.</returns>
        private Control CreatePropertyEditor(DataGridViewColumn column)
        {
            Control propEditor = null;

            if (column is DataGridViewComboBoxColumn comboBoxColumn) // Выбор фиксированных значений
            {
                propEditor = new ComboBox()
                {
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    DataSource = comboBoxColumn.DataSource,
                    DisplayMember = comboBoxColumn.DisplayMember,
                    ValueMember = comboBoxColumn.ValueMember
                };
            }
            else if (column.ValueType.IsNumericType()) // Ввод численных значений
            {
                var typeRange = Utils.GetNumericTypeRange(column.ValueType);
                propEditor = new NumericUpDown()
                {
                    Minimum = Convert.ToDecimal(typeRange.Item1),
                    Maximum = Convert.ToDecimal(typeRange.Item2)
                };
            }
            else if (column.ValueType == typeof(string)) // Ввод строковых значений
            {
                propEditor = new TextBox();
            }
            else if (column.ValueType == typeof(DateTime)) // Выбор значений даты и времени
            {
                propEditor = new DateTimePicker();
            }

            return propEditor;
        }

        /// <summary>
        /// Формирует делегат, устанавливающий значения заданного свойства записи.
        /// </summary>
        /// <param name="column">Колонка, соотвутствующая заданному свойству.</param>
        /// <returns>Делегат, устанавливающий значения заданного свойства записи.</returns>
        private Action<object, object> CreatePropertySetter(DataGridViewColumn column)
        {
            return (entry, value) =>
            {
                if (column.ValueType.IsNumericType())
                    value = Utils.ConvertToNumeric(value, column.ValueType);

                PropertyInfo prop = _entryType.GetProperty(column.DataPropertyName);
                prop.SetValue(entry, value);
            };
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
