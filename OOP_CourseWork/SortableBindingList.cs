using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace OOP_CourseWork
{
    /// <summary>
    /// Представляет переопределенный <see cref="BindingList{T}"/> с поддержкой сортировки.
    /// </summary>
    public class SortableBindingList<T> : BindingList<T>
    {
        public SortableBindingList() : base()
        {
        }

        public SortableBindingList(IList<T> list) : base(list)
        {
        }

        protected override bool SupportsSortingCore => true;

        protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
        {
            // Если тип заданного свойство не реализует интерфейс IComparable, сортировка невозможна
            if (property.PropertyType.GetInterface("IComparable") == null)
                return;

            // Делегат для сравнения объектов 
            var comparison = new Comparison<T>((t1, t2) =>
            {
                object propValue1 = property.GetValue(t1);
                object propValue2 = property.GetValue(t2);
                
                if (property.GetValue(t1) == null && property.GetValue(t2) == null)
                    return 0;

                // Приводим ненулевой объект к IComparable и вызываем метод сравнения
                int result = (propValue1 != null) ? ((IComparable)propValue1).CompareTo(propValue2) : ((IComparable)propValue2).CompareTo(propValue1);

                // Возвращаем результат с учетом направления сортировки
                return (direction == ListSortDirection.Descending) ? -result : result;
            });

            // Выполняем сортировку
            List<T> itemsList = (List<T>)Items;
            itemsList.Sort(comparison);
        }
    }
}
