using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOP_CourseWork
{
    /// <summary>
    /// Представляет тематику товара.
    /// </summary>
    public class Subject
    {
        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // Закрытый конструктор для автоматического создания экземпляров класса
        private Subject()
        {
        }

        [Key]
        [ReadOnly(true)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(32)]
        [DisplayName("Название")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Строка не должна быть пустой.")]
        public string Name { get; set; }

        public override string ToString() => Name;
    }
}
