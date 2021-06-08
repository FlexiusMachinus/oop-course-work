using System;

namespace OOP_CourseWork
{
    /// <summary>
    /// Представляет тип накопителя.
    /// </summary>
    public enum MediaType
    {
        CD,
        DVD,
        BluRay,
        VinylRecord
    }

    /// <summary>
    /// Расширяющий метод для типа перечисления <see cref="MediaType"/>.
    /// </summary>
    public static class MediaTypeExtension
    {
        /// <summary>
        /// Возвращает локализированное название заданного типа хранилища.
        /// </summary>
        public static string ToLocalizedString(this MediaType mediaType)
        {
            switch (mediaType)
            {
                case MediaType.DVD:
                    return "DVD";

                case MediaType.BluRay:
                    return "Blu-Ray";

                case MediaType.VinylRecord:
                    return "Виниловая пластинка";

                default:
                case MediaType.CD:
                    return "CD";
            }
        }
    }
}
