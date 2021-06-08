using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOP_CourseWork
{
    /// <summary>
    /// Представляет транзакцию, связанную с определенным товаром.
    /// </summary>
    public class Transaction
    {
        public Transaction(int id, Product product, DateTime purchaseDate)
        {
            Id = id;
            Product = product;
            ProductId = product.Id;
            PurchaseDate = purchaseDate;
        }

        // Закрытый конструктор для автоматического создания экземпляров класса
        private Transaction()
        {
        }

        [Key]
        [ReadOnly(true)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("Товар")]
        public int ProductId { get; set; }

        [Browsable(false)]
        public Product Product { get; set; }

        [DisplayName("Дата покупки")]
        public DateTime PurchaseDate { get; set; }
    }
}
