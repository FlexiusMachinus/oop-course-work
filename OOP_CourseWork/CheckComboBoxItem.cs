using System;
using System.Windows.Forms;

namespace OOP_CourseWork
{
    /// <summary>
    /// Представляет значение, входящее в состав элемента управления <see cref="CheckComboBox"/>,
    /// которое можно отмечать по принципу <see cref="CheckBox"/>.
    /// </summary>
    public class CheckComboBoxItem
    {
        public CheckComboBoxItem(string text, bool defaultCheckState = false)
        {
            Text = text;
            Checked = defaultCheckState;
        }

        /// <summary>
        /// Отображаемый текст.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Определяет состояние элемента.
        /// </summary>
        public bool Checked { get; set; }
    }
}
