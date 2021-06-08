using System;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace OOP_CourseWork
{
    /// <summary>
    /// Основная форма приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        private const string MessageBoxHeader = "База данных";
        private const int WelcomeWindowTimeBeforeExit = 10;

        private readonly List<BindingSource> _bindingSources;
        private readonly List<DataGridView> _grids;
        private readonly List<Button> _addButtons;
        private readonly List<Button> _deleteButtons;

        // Словарь, где каждому источнику данных соответствует значение, определяющее, применена ли для него фильтрация
        private Dictionary<BindingSource, bool> _filterFlags;

        // Контекст для работы с базой данных
        private ShopContext _db;

        public MainForm()
        {
            InitializeComponent();

            var mediaTypeColumn = _productsGrid.Columns[4] as DataGridViewComboBoxColumn;
            mediaTypeColumn.DataSource = Enum.GetValues(typeof(MediaType));
            mediaTypeColumn.ValueType = typeof(MediaType);

            _grids = new List<DataGridView>() { _productsGrid, _transactionsGrid, _categoriesGrid, _subjectsGrid };
            _bindingSources = new List<BindingSource>() { _productBindingSource, _transactionBindingSource, _categoryBindingSource, _subjectBindingSource };

            _filterFlags = new Dictionary<BindingSource, bool>();
            foreach (var bindingSource in _bindingSources)
                _filterFlags.Add(bindingSource, false);

            _addButtons = new List<Button>() { _addProductButton, _addTransactionButton, _addCategoryButton, _addSubjectButton };
            _deleteButtons = new List<Button>() { _deleteProductButton, _deleteTransactionButton, _deleteCategoryButton, _deleteSubjectButton };
        }

        /// <summary>
        /// Определяет, загружена ли база данных.
        /// </summary>
        public bool IsDatabaseLoaded => (_db != null);

        /// <summary>
        /// Показывает заставку при отображеннии формы.
        /// </summary>
        private void MainFormShown(object sender, EventArgs e)
        {
            using (var welcomeForm = new WelcomeForm(WelcomeWindowTimeBeforeExit))
            {
                welcomeForm.ShowDialog(this);
            }
        }

        /// <summary>
        /// При закрытии формы отображает диалог, позволяющий сохранить базу данных (если изменения не были внесены).
        /// </summary>
        private void MainFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsDatabaseLoaded || !_db.ChangeTracker.HasChanges())
                return;

            DialogResult result = MessageBox.Show("Данные не были сохранены. Сохранить?", MessageBoxHeader,
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                SaveDataBase();
                _db.Dispose();
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Создает базу данных при нажатии на соответствующую опции в меню "База данных".
        /// Если база данных уже существует, отображает диалог, позволяющий загрузить данные на форму.
        /// </summary>
        private void CeateDbToolStripMenuItemClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            using (var db = new ShopContext())
            {
                if (db.Database.Exists())
                {
                    DialogResult result = MessageBox.Show("База данных уже существует. Загрузить?", MessageBoxHeader,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Yes)
                        LoadDataBase();
                }
                else
                {
                    db.Database.Create();
                    MessageBox.Show("База данных успешно создана.", MessageBoxHeader);

                    LoadDataBase();
                }
            };
        }

        /// <summary>
        /// Инициализирует контекст базы данных и источники данных, а также включает необходимые элементы управления.
        /// </summary>
        private void LoadDataBase()
        {
            _db = new ShopContext();

            foreach (var dbSet in _db.DbSets)
                dbSet.Load();

            _productBindingSource.DataSource = _db.Products.Local.ToBindingList();
            _transactionBindingSource.DataSource = _db.Transactions.Local.ToBindingList();
            _categoryBindingSource.DataSource = _db.Categories.Local.ToBindingList();
            _subjectBindingSource.DataSource = _db.Subjects.Local.ToBindingList();

            ProductId.DataSource = _productBindingSource.DataSource;
            CategoryId.DataSource = _categoryBindingSource.DataSource;
            SubjectId.DataSource = _subjectBindingSource.DataSource;

            for (int i = 0; i < _grids.Count; i++)
                _grids[i].DataSource = _bindingSources[i];

            _createDbToolStripMenuItem.Enabled = false;
            _loadDbToolStripMenuItem.Enabled = false;
            _saveDbToolStripMenuItem.Enabled = true;
            _closeDbToolStripMenuItem.Enabled = true;
            _deleteDbToolStripMenuItem.Enabled = true;
            _applyFilterToolStripMenuItem.Enabled = true;
            _resetFilterToolStripMenuItem.Enabled = true;

            foreach (var button in _addButtons)
                button.Enabled = true;

            TabControlSelectedIndexChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Удаляет базу данных и закрывает соединение.
        /// </summary>
        private void DeleteDataBase(ShopContext db)
        {
            db.Database.Delete();
            CloseDataBase();
        }

        /// <summary>
        /// Сохраняет базу данных (при успешной валидации) либо выводит сообщение об ошибке.
        /// </summary>
        private void SaveDataBase()
        {
            var errors = _db.GetValidationErrors();
            if (errors.Any())
            {
                string message = errors.First().ValidationErrors.First().ErrorMessage;
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _db.SaveChanges();
        }

        /// <summary>
        /// Закрывает соединение с базой данных и обнуляет источники, а также выключает часть элементов управления.
        /// </summary>
        private void CloseDataBase()
        {
            foreach (var grid in _grids)
                grid.DataSource = null;

            _db.Dispose();
            _db = null;

            _createDbToolStripMenuItem.Enabled = true;
            _loadDbToolStripMenuItem.Enabled = true;
            _saveDbToolStripMenuItem.Enabled = false;
            _closeDbToolStripMenuItem.Enabled = false;
            _deleteDbToolStripMenuItem.Enabled = false;
            _applyFilterToolStripMenuItem.Enabled = false;
            _resetFilterToolStripMenuItem.Enabled = false;

            foreach (var button in _addButtons)
                button.Enabled = false;
        }

        /// <summary>
        /// Загружает базу данных при нажатии на соответствующую опции в меню "База данных".
        /// Если база данных еще не инициализирована, отображает диалог, позволяющий создать новую базу данных.
        /// Если база данных уже загружена, отображает соотвутствующее сообщение.
        /// </summary>
        private void LoadDbToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (IsDatabaseLoaded)
            {
                MessageBox.Show("База данных уже загружена!", MessageBoxHeader);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            using (var db = new ShopContext())
            {
                if (!db.Database.Exists())
                {
                    DialogResult result = MessageBox.Show("База данных не инициализирована. Создать?", MessageBoxHeader,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.No)
                        return;

                    db.Database.Create();
                }
            }

            LoadDataBase();
        }

        /// <summary>
        /// Сохраняет базу данных при нажатии на соответствующую опции в меню "База данных".
        /// Оображает сообщение об успешном либо неуспешном выполнении операции.
        /// </summary>
        private void SaveDbToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (!IsDatabaseLoaded)
            {
                MessageBox.Show("База данных не загружена!", MessageBoxHeader);
                return;
            }

            SaveDataBase();
            MessageBox.Show("База данных успешно сохранена.", MessageBoxHeader);
        }

        /// <summary>
        /// Закрывает соединение с базой данных при нажатии на соответствующую опции в меню "База данных".
        /// Если база данных не загружена, отображает соотвутствующее сообщение.
        /// При наличии несохраненных изменений, отображает диалог, позволяющий сохранить базу данных.
        /// </summary>
        private void CloseDbToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (!IsDatabaseLoaded)
            {
                MessageBox.Show("База данных не загружена!", MessageBoxHeader);
                return;
            }

            if (_db.ChangeTracker.HasChanges())
            {
                DialogResult result = MessageBox.Show("Данные не были сохранены. Сохранить?", MessageBoxHeader,
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                    SaveDataBase();

                if (result == DialogResult.Cancel)
                    return;
            }

            CloseDataBase();
        }

        /// <summary>
        /// Удаляет базу данных при нажатии на соответствующую опции в меню "База данных".
        /// Оображает сообщение об успешном либо неуспешном выполнении операции.
        /// </summary>
        private void DeleteDbToolStripMenuItemClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            using (var db = new ShopContext())
            {
                if (!db.Database.Exists())
                {
                    MessageBox.Show("База данных не инициализирована!", MessageBoxHeader);
                    return;
                }

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить базу данных?", MessageBoxHeader,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    DeleteDataBase(db);
                    MessageBox.Show("База данных успешно удалена.", MessageBoxHeader);
                }
            }
        }

        /// <summary>
        /// Отображает форму для выбора параметров фильтрации при выборе соотвутствующей опции меню "Фильтр и поиск"
        /// </summary>
        private void ApplyFilterToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Индекс текущей закладки на форме
            int index = _tabControl.SelectedIndex;
            // Таблица на выбранной вкладке формы
            DataGridView grid = _grids[index];

            // Отобразить форму для выбора параметров фильтрации
            using (var applyFilterForm = new ApplyFilterForm(grid))
            {
                DialogResult result = applyFilterForm.ShowDialog(this);

                // При подтверждении параметров применить фильтр
                if (result == DialogResult.OK)
                {
                    // Выбранные параметры фильтрации
                    IColumnFilterer filterer = applyFilterForm.ColumnFilterer;
                    if (filterer != null)
                    {
                        // Тип данных таблицы 
                        Type sourceType = ListBindingHelper.GetListItemType((grid.DataSource as BindingSource)?.DataSource);

                        // Определение типа для создания соотвутствующих листов привязки
                        if (sourceType == typeof(Product))
                        {
                            // Аналогично для каждого типа:
                            // Получаем список фильтрируемых данных
                            IEnumerable<Product> products = _bindingSources[index].OfType<Product>();
                            // Применяем фильтр
                            IEnumerable<Product> filteredProducts = products.Where(product => filterer.FilterValue(product));
                            // Выбираем в качестве источника данных список привязки с отфильтрованными значениями
                            _bindingSources[index].DataSource = new ObservableCollection<Product>(filteredProducts).ToBindingList();
                        }
                        else if (sourceType == typeof(Transaction))
                        {
                            IEnumerable<Transaction> transactions = _bindingSources[index].OfType<Transaction>();
                            IEnumerable<Transaction> filteredTransactions = transactions.Where(transaction => filterer.FilterValue(transaction));
                            _bindingSources[index].DataSource = new ObservableCollection<Transaction>(filteredTransactions).ToBindingList();
                        }
                        else if (sourceType == typeof(Category))
                        {
                            IEnumerable<Category> categories = _bindingSources[index].OfType<Category>();
                            IEnumerable<Category> filteredCategories = categories.Where(category => filterer.FilterValue(category));
                            _bindingSources[index].DataSource = new ObservableCollection<Category>(filteredCategories).ToBindingList();
                        }
                        else if (sourceType == typeof(Subject))
                        {
                            IEnumerable<Subject> subjects = _bindingSources[index].OfType<Subject>();
                            IEnumerable<Subject> filteredSubjects = subjects.Where(subject => filterer.FilterValue(subject));
                            _bindingSources[index].DataSource = new ObservableCollection<Subject>(filteredSubjects).ToBindingList();
                        }

                        // Указываем, что данные для заданного источника были отфильтрованы
                        _filterFlags[_bindingSources[index]] = true;
                    }
                }
            }
        }

        /// <summary>
        /// Сбрасывает примененный фильтр при выборе соотвутствующей опции меню "Фильтр и поиск"
        /// </summary>
        private void ResetFilterToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Индекс текущей закладки на форме
            int index = _tabControl.SelectedIndex;

            // Выбираем исходный список привязки в качестве источника данных
            IBindingList bindingList = _db.DbSets.ElementAt(index).GetLocalViewBindingList();
            _bindingSources[index].DataSource = bindingList;

            // Указываем, что данные для заданного источника больше не отфильтрованы
            _filterFlags[_bindingSources[index]] = false;
        }

        /// <summary>
        /// Отображает форму для добавления новых записей при нажатии на соответствующую кнопку на форме.
        /// </summary>
        private void AddEntryButtonClick(object sender, EventArgs e)
        {
            // Индекс текущей закладки на форме
            int index = _tabControl.SelectedIndex;
            // Таблица на выбранной вкладке формы
            DataGridView grid = _grids[index];
            // Список привязки, являющийся источником данных таблицы
            IBindingList bindingList = _bindingSources[index].DataSource as IBindingList;
            // Тип данных источника
            Type sourceType = bindingList.GetItemType();

            // Обображаем форму для добавления новых записей
            using (var addEntryForm = new AddEntryForm(grid))
            {
                // До тех пор, пока не пройдет валидация, либо операция не будет отменена
                bool isValid = true;
                do
                {
                    DialogResult result = addEntryForm.ShowDialog(this);
                    if (result != DialogResult.OK)
                        break;

                    object newEntry = addEntryForm.NewEntry;
                    if (newEntry != null)
                    {
                        // Добавляем значение в таблицу
                        bindingList.Add(newEntry);

                        // Производим валидацию
                        var errors = _db.GetValidationErrors();
                        isValid = !errors.Any();

                        // При наличии ошибок удаляем запись и выводим сообщение
                        if (!isValid)
                        {
                            bindingList.RemoveAt(bindingList.Count - 1);

                            string message = errors.First().ValidationErrors.First().ErrorMessage;
                            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                while (!isValid);
            }
        }

        /// <summary>
        /// Удаляет выбранные записи при нажатии на соответствующую кнопку на форме.
        /// </summary>
        private void DeleteEntryButtonClick(object sender, EventArgs e)
        {
            int index = _tabControl.SelectedIndex;
            foreach (DataGridViewRow row in _grids[index].SelectedRows)
            {
                if (row.Index == -1)
                    continue;

                int rowIndex = row.Index;
                DbSet dbSet = _db.DbSets.ElementAt(index);

                // Если значение не отслеживается контекстом БД, вручную прикрепляем его к контексту
                if (_db.Entry(row.DataBoundItem).State == EntityState.Detached)
                    dbSet.Attach(row.DataBoundItem);

                // Удаляемзначение из базы данных
                dbSet.Remove(row.DataBoundItem);

                // Если данные отфильтрованы, вручную удаляем строки из таблицы
                if (_filterFlags[_bindingSources[index]])
                    _grids[index].Rows.RemoveAt(rowIndex);
            }
        }

        /// <summary>
        /// Включает либо выключает кнопку удаления записей при изменении выделения внутри таблицы.
        /// </summary>
        private void GridSelectionChanged(object sender, EventArgs e)
        {
            DataGridView grid = _grids[_tabControl.SelectedIndex];
            _deleteButtons[_tabControl.SelectedIndex].Enabled = (grid.SelectedRows.Count > 0);
        }

        /// <summary>
        /// Отображает опции для настройки вида таблицы при выборе соответствующей опции меню "Вид".
        /// </summary>
        private void TabControlSelectedIndexChanged(object sender, EventArgs e)
        {
            _viewToolStripMenuItem.DropDownItems.Clear();

            DataGridView grid = _grids[_tabControl.SelectedIndex];
            int i = 0;

            // По CheckBox на каждую колонку
            foreach (DataGridViewColumn column in grid.Columns)
            {
                var item = new ToolStripMenuItem(column.HeaderText)
                {
                    CheckOnClick = true,
                    Checked = grid.Columns[i++].Visible
                };

                item.CheckedChanged += new EventHandler(ViewToolStripMenuItemCheckedChanged);
                _viewToolStripMenuItem.DropDownItems.Add(item);
            }
        }

        /// <summary>
        /// Изменяет вид таблицы при изменении состояния CheckBox в меню "Вид".
        /// </summary>
        private void ViewToolStripMenuItemCheckedChanged(object sender, EventArgs e)
        {
            int i = 0;
            foreach (ToolStripMenuItem item in _viewToolStripMenuItem.DropDownItems)
            {
                _grids[_tabControl.SelectedIndex].Columns[i++].Visible = item.Checked;
            }
        }

        /// <summary>
        /// Вызывает событие нажатия на кнопку удаления при нажатии клавиши Delete.
        /// </summary>
        private void GridKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                DeleteEntryButtonClick(sender, EventArgs.Empty);
        }

        /// <summary>
        /// Производит валидацию измененного значения ячейки и возвращает его  к исходному при возникновении ошибок.
        /// </summary>
        private void GridCellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var grid = sender as DataGridView;
            var cell = grid?.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewTextBoxCell;

            if (cell == null)
                return;

            // Исходное значение
            object initialValue = cell.Value;

            // Присваиваем новое значение
            cell.Value = e.FormattedValue;
            // Проверяем на ошибки валидации
            var errors = _db.GetValidationErrors();

            // При наличии ошибок выводим сообщение, возвращаем исходное значение и отменяем редактирование ячейки.
            if (errors.Any())
            {
                string message = errors.First().ValidationErrors.First().ErrorMessage;
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cell.Value = initialValue;

                e.Cancel = true;
                grid.CancelEdit();
            }
        }

        /// <summary>
        /// Локализирует значение типа MediaType при форматировании ячейки таблицы.
        /// </summary>
        private void ProductGridCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                e.Value = ((MediaType)e.Value).ToLocalizedString();
            }
        }
    }
}
