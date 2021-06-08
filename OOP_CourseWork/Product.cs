using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOP_CourseWork
{
    /// <summary>
    /// Представляет аудио-видео товар.
    /// </summary>
    public class Product
    {
        public Product(int id, string name, Category category, Subject subject, MediaType mediaType, int price, int quantity)
        {
            Id = id;
            Name = name;
            Category = category;
            CategoryId = Category.Id;
            Subject = subject;
            SubjectId = Subject.Id;
            MediaType = mediaType;
            Price = price;
            Quantity = quantity;
        }

        // Закрытый конструктор для автоматического создания экземпляров класса
        private Product()
        {
        }

        [Key]
        [ReadOnly(true)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("Название")]
        [MaxLength(64, ErrorMessage = "Максимальная длина названия - 32 символа.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Строка не должна быть пустой.")]
        public string Name { get; set; }

        [DisplayName("Категория")]
        public int CategoryId { get; set; }

        [Browsable(false)]
        public Category Category { get; set; }

        [DisplayName("Тематика")]
        public int SubjectId { get; set; }

        [Browsable(false)]
        public Subject Subject { get; set; }

        [DisplayName("Тип носителя")]
        [EnumDataType(typeof(MediaType))]
        public MediaType MediaType { get; set; }

        [DisplayName("Цена")]
        [Range(0, int.MaxValue, ErrorMessage = "Цена товара не может быть меньше нуля!")]
        public int Price { get; set; }

        [DisplayName("Количество")]
        [Range(0, int.MaxValue, ErrorMessage = "Количество товара не может быть меньше нуля!")]
        public int Quantity { get; set; }

        [NotMapped]
        public string DetailedName => ToString();

        public override string ToString() => $"{Name} ({Category}, {Subject}, {MediaType})";
    }
}
