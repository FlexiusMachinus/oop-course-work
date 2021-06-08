using System;
using System.Windows.Forms;

namespace OOP_CourseWork
{
    /// <summary>
    /// Представляет элемент управления для выбора даты и времени, а также их форматирования.
    /// </summary>
    public class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
    {
        public object EditingControlFormattedValue
        {
            get => Value.ToShortDateString();
            set
            {
                if (value is string str && DateTime.TryParse(str, out DateTime date))
                    Value = date;
            }
        }

        // Реализация интерфейсов DateTimePicker и IDataGridViewEditingControl
        public DataGridView EditingControlDataGridView { get; set; }
        public int EditingControlRowIndex { get; set; }
        public bool EditingControlValueChanged { get; set; }
        public bool RepositionEditingControlOnValueChange => false;
        public Cursor EditingPanelCursor => base.Cursor;
        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context) => EditingControlFormattedValue;

        /// <summary>
        /// Изменяет элемент управления для согласования с заданным стилем ячейки.
        /// </summary>
        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
            this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
        }

        /// <summary>
        /// Определяет, является ли заданная клавиша обычной клавишей ввода.
        /// </summary>
        public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey)
        {
            switch (key & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;

                default:
                    return !dataGridViewWantsInputKey;
            }
        }

        /// <summary>
        /// Подготавливает выбранную ячейку к редактированию.
        /// </summary>
        public void PrepareEditingControlForEdit(bool selectAll)
        {
            // NO-OP
        }

        /// <summary>
        /// Вызывает необходимые события при изменении значения .
        /// </summary>
        protected override void OnValueChanged(EventArgs eventargs)
        {
            EditingControlValueChanged = true;
            EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnValueChanged(eventargs);
        }
    }
}
