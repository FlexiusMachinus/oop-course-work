using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace OOP_CourseWork
{
    /// <summary>
    /// Представляет элемент управления "поле со списком", значения которого можно отмечать по принципу <see cref="CheckBox"/>.
    /// </summary>
    public class CheckComboBox : ComboBox
    {
        public CheckComboBox()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            DropDownStyle = ComboBoxStyle.DropDownList;
            FlatStyle = FlatStyle.Flat;
        }

        /// <summary>
        /// Текст, отображаемый при отсутствии выделения.
        /// </summary>
        public string PlaceholderText { get; set; }

        /// <summary>
        /// Изменяет состояние дочерних элементов при нажатии на них.
        /// </summary>
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            if (SelectedIndex == -1)
                return;

            CheckComboBoxItem item = (CheckComboBoxItem)SelectedItem;
            item.Checked = !item.Checked;
            DroppedDown = true;
        }

        /// <summary>
        /// Переопределяет отрисовку дочерних элементов.
        /// </summary>
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (!DroppedDown || e.Index == -1)
            {
                SizeF stringSize = e.Graphics.MeasureString(PlaceholderText, Font);
                PointF point = new PointF(e.Bounds.X + e.Bounds.Width / 2 - stringSize.Width / 2, e.Bounds.Y);
                e.Graphics.DrawString(PlaceholderText, Font, Brushes.Black, point);
                return;
            }

            if (e.Index == -1 || !(Items[e.Index] is CheckComboBoxItem))
                return;

            CheckComboBoxItem item = (CheckComboBoxItem)Items[e.Index];
            CheckBoxState checkBoxState = item.Checked ? CheckBoxState.CheckedNormal : CheckBoxState.UncheckedNormal;
            bool isItemFocused = (e.State & DrawItemState.Focus) == 0;
            CheckBoxRenderer.DrawCheckBox(e.Graphics, new Point(e.Bounds.X, e.Bounds.Y), e.Bounds, item.Text, Font, isItemFocused, checkBoxState);
        }
    }
}
