namespace OOP_CourseWork
{
    /// <summary>
    /// Предоставляет предикат для фильтрации данных.
    /// </summary>
    public interface IColumnFilterer
    {
        bool FilterValue(object value);
    }
}
