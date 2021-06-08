using System;
using System.Reflection;
using System.Data.Entity;
using System.ComponentModel;
using System.Windows.Forms;

namespace OOP_CourseWork
{
    /// <summary>
    /// Содержит вспомогательные методы.
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// Возвращает список привязки для локального представления элементов, хранящихся в заданном наборе данных.
        /// </summary>
        /// <param name="dbSet">Набор данных, для которого нужно получить список привязки.</param>
        /// <returns><see cref="IBindingList"/>, полученный из <see cref="DbSet.Local"/> заданного набора данных.</returns>
        public static IBindingList GetLocalViewBindingList(this DbSet dbSet)
        {
            Type sourceType = ListBindingHelper.GetListItemType(dbSet.Local);
            MethodInfo method = typeof(ObservableCollectionExtensions).GetMethod(nameof(ObservableCollectionExtensions.ToBindingList));
            return method.MakeGenericMethod(sourceType).Invoke(null, new[] { dbSet.Local }) as IBindingList;
        }

        /// <summary>
        /// Возвращает тип данных элементов в указанном списке.
        /// </summary>
        /// <param name="bindingList">Список привязки, тип данных которого нужно получить.</param>
        /// <returns><see cref="Type"/> элементов, содержащихся в списке.</returns>
        public static Type GetItemType(this IBindingList bindingList) => ListBindingHelper.GetListItemType(bindingList);

        /// <summary>
        /// Возвращает тип данных указанного источника.
        /// </summary>
        /// <param name="bindingSource">Источник данных, тип которых нужно получить.</param>
        /// <returns><see cref="Type"/> данных, представленных в <see cref="BindingSource.DataSource"/> источника.</returns>
        public static Type GetDataSourceType(this BindingSource bindingSource) => ListBindingHelper.GetListItemType(bindingSource.DataSource);

        /// <summary>
        /// Возвращает значение, определяющее, вляется ли заданный тип числом.
        /// </summary>
        public static bool IsNumericType(this Type type)
        {
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Decimal:
                case TypeCode.Single:

                case TypeCode.Double:
                    return true;

                default:
                    return false;
            }
        }

        /// <summary>
        /// Конвертирует значение в заданный численный тип.
        /// </summary>
        /// <param name="value">Конвертируемое значение.</param>
        /// <param name="targetType">Численный тип, в который преобразуется значение.</param>
        /// <returns>
        /// Значение типа <paramref name="targetType"/>, приведенное к <see cref="IComparable"/>
        /// (если <paramref name="targetType"/> является численным типом), иначе <see langword="null"/>.
        /// </returns>
        public static IComparable ConvertToNumeric(object value, Type targetType)
        {
            switch (Type.GetTypeCode(targetType))
            {
                case TypeCode.Byte: return Convert.ToByte(value);
                case TypeCode.SByte: return Convert.ToSByte(value);
                case TypeCode.UInt16: return Convert.ToUInt16(value);
                case TypeCode.UInt32: return Convert.ToUInt32(value);
                case TypeCode.UInt64: return Convert.ToUInt64(value);
                case TypeCode.Int16: return Convert.ToInt16(value);
                case TypeCode.Int32: return Convert.ToInt32(value);
                case TypeCode.Int64: return Convert.ToInt64(value);
                case TypeCode.Decimal: return Convert.ToDecimal(value);
                case TypeCode.Single: return Convert.ToSingle(value);
                case TypeCode.Double: return Convert.ToDouble(value);
            }

            return null;
        }

        /// <summary>
        /// Возвращает левую и правую границу допустимого диапазона значений для заданного типа.
        /// </summary>
        /// <param name="numericType">Численный тип, для которого вычисляется диапазон.</param>
        /// <returns>Экземпляр типа <see cref="Tuple{T1, T2}"/>, содержащий минимальное и максимальное значения.</returns>
        public static Tuple<IComparable, IComparable> GetNumericTypeRange(Type numericType)
        {
            switch (Type.GetTypeCode(numericType))
            {
                case TypeCode.Byte: return Tuple.Create<IComparable, IComparable>(Byte.MinValue, Byte.MaxValue);
                case TypeCode.SByte: return Tuple.Create<IComparable, IComparable>(SByte.MinValue, SByte.MaxValue);
                case TypeCode.UInt16: return Tuple.Create<IComparable, IComparable>(UInt16.MinValue, UInt16.MaxValue);
                case TypeCode.UInt32: return Tuple.Create<IComparable, IComparable>(UInt32.MinValue, UInt32.MaxValue);
                case TypeCode.UInt64: return Tuple.Create<IComparable, IComparable>(UInt64.MinValue, UInt64.MaxValue);
                case TypeCode.Int16: return Tuple.Create<IComparable, IComparable>(Int16.MinValue, Int16.MaxValue);
                case TypeCode.Int32: return Tuple.Create<IComparable, IComparable>(Int32.MinValue, Int32.MaxValue);
                case TypeCode.Int64: return Tuple.Create<IComparable, IComparable>(Int64.MinValue, Int64.MaxValue);
                case TypeCode.Single: return Tuple.Create<IComparable, IComparable>(Single.MinValue, Single.MaxValue);
                case TypeCode.Double: return Tuple.Create<IComparable, IComparable>(Byte.MinValue, Double.MaxValue);
                case TypeCode.Decimal: return Tuple.Create<IComparable, IComparable>(Decimal.MinValue, Decimal.MaxValue);

                default:
                    throw new ArgumentException("The specified type must be numeric.");
            }
        }
    }
}
