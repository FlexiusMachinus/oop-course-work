using System;

namespace OOP_CourseWork
{
    /// <summary>
    /// Представляет объект, выполняющий фильтрацию данных.
    /// </summary>
    /// <typeparam name="T">Тип свойства, по которому идет фильтрация</typeparam>
    public class ColumnFilterer<T> : IColumnFilterer
    {
        public ColumnFilterer(Func<object, T> propertyGetter, Predicate<T> filterPredicate)
        {
            PropertyGetter = propertyGetter;
            FilterPredicate = filterPredicate;
        }

        /// <summary>
        /// Делегат, возвращающий значение свойства, по которому идет фильтрация.
        /// </summary>
        public Func<object, T> PropertyGetter { get; private set; }

        /// <summary>
        /// Предикат фильтрации.
        /// </summary>
        public Predicate<T> FilterPredicate { get; private set; }

        public bool FilterValue(object value) => FilterPredicate(PropertyGetter(value));
    }
}
