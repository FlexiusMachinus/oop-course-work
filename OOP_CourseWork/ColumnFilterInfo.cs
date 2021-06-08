using System;
using System.Collections;

namespace OOP_CourseWork
{
    /// <summary>
    /// Представляет набор данных, необходимых для определения возможных параметров фильтрации колонки.
    /// Базовый тип для <see cref="ColumnFilterInfo{T}"/>.
    /// </summary>
    public abstract class ColumnFilterInfo
    {
        /// <summary>
        /// Конструктор для типа <see cref="ColumnFilterInfo"/>.
        /// </summary>
        /// <param name="columnName">Название колонки.</param>
        /// <param name="valueType">Тип значений колонки.</param>
        /// <param name="allowedValues">Опциональный конечный набор разрашенных значений.</param>
        public ColumnFilterInfo(string columnName, Type valueType, IEnumerable allowedValues)
        {
            ColumnName = columnName;
            ValueType = valueType;
            AllowedValues = allowedValues;
        }

        /// <summary>
        /// Название колонки.
        /// </summary>
        public string ColumnName { get; private set; }

        /// <summary>
        /// Тип значений колонки.
        /// </summary>
        public Type ValueType { get; private set; }

        /// <summary>
        /// Опциональный конечный набор разрашенных значений.
        /// </summary>
        public IEnumerable AllowedValues { get; private set; }

        /// <summary>
        /// Возвращает значение свойства, значения которого представлены в данной колонке.
        /// </summary>
        /// <param name="obj">Объект, содержащий значение свойства.</param>
        public abstract object GetPropertyValue(object obj);

        /// <summary>
        /// Возвращает значение свойства, значения которого представлены в данной колонке, выполняя приведение к типу <see cref="T"/>.
        /// В случае, если объект не относится к заданному типу, возвращает <see langword="null"/>.
        /// </summary>
        /// <param name="obj">Объект, содержащий значение свойства.</param>
        /// <typeparam name="T">Тип, к которому выполняется приведение.</typeparam>
        public T GetPropertyValue<T>(object obj)
        {
            object value = GetPropertyValue(obj);
            return (value is T) ? (T)value : default;
        }
    }

    /// <summary>
    /// Представляет набор данных, необходимых для определения возможных параметров фильтрации колонки.
    /// </summary>
    public sealed class ColumnFilterInfo<T> : ColumnFilterInfo
    {
        /// <summary>
        /// Создает объект типа <see cref="ColumnFilterInfo"/>.
        /// </summary>
        /// <param name="columnName">Название колонки.</param>
        /// <param name="valueType">Тип значений колонки.</param>
        /// <param name="valueGetter">Делегат, ссылающийся на одно из свойств, значения которого представлены в данной колонке.</param>
        /// <param name="allowedValues">Опциональный конечный набор разрашенных значений.</param>
        public ColumnFilterInfo(string columnName, Type valueType, Func<T, object> valueGetter, IEnumerable allowedValues = null) :
            base(columnName, valueType, allowedValues) => PropertyGetter = valueGetter;

        /// <summary>
        /// Делегат, ссылающийся на одно из свойств, значения которого представлены в данной колонке.
        /// </summary>
        /// <typeparam name="TSource">Тип, к которому относится свойство, возвращаемое делегатом.</typeparam>
        public Func<T, object> PropertyGetter { get; private set; }

        public override object GetPropertyValue(object obj)
        {
            if (!(obj is T t))
                throw new ArgumentException("The specified object had an incorrect type.");

            return PropertyGetter(t);
        }
    }
}