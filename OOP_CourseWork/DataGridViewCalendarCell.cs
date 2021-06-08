using System;
using System.Windows.Forms;

namespace OOP_CourseWork
{
    /// <summary>
    /// Представляет инструменты для редактирования даты и времени в <see cref="DataGridView"/> элемента управления.
    /// </summary>
    public class DataGridViewCalendarCell : DataGridViewTextBoxCell
    {
        public DataGridViewCalendarCell(): base() => Style.Format = "d";

        public override Type EditType => typeof(CalendarEditingControl);
        public override Type ValueType => typeof(DateTime);
        public override object DefaultNewRowValue => DateTime.Now;

        /// <summary>
        /// Присоединяет и инициализирует элемент управления.
        /// </summary>
        /// <param name="rowIndex">Индекс строки</param>
        /// <param name="initialFormattedValue">Начальное значение</param>
        /// <param name="cellStyle">Стиль ячейки</param>
        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle cellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, cellStyle);
            CalendarEditingControl calendarControl = DataGridView.EditingControl as CalendarEditingControl;
            calendarControl.Value = (Value == null) ? (DateTime)DefaultNewRowValue : (DateTime)Value;
        }
    }
}
