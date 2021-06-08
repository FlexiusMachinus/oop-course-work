using System;
using System.Data.Entity;
using System.Collections.Generic;

namespace OOP_CourseWork
{
    /// <summary>
    /// Представляет контекст базы данных аудио-видео товаров.
    /// </summary>
    public class ShopContext : DbContext
    {
        /// <summary>
        /// Создает контекст базы данных, используя строку подключения, предопределенную в конфиге приложения.
        /// </summary>
        public ShopContext() : base("MyDbConnection")
        {
        }

        /// <summary>
        /// Набор данных типа <see cref="Product"/>.
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Набор данных типа <see cref="Transaction"/>.
        /// </summary>
        public DbSet<Transaction> Transactions { get; set; }

        /// <summary>
        /// Набор данных типа <see cref="Category"/>.
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Набор данных типа <see cref="Subjects"/>.
        /// </summary>
        public DbSet<Subject> Subjects { get; set; }

        /// <summary>
        /// Перечислитель со всеми наборами данных, входящими в контекст. 
        /// </summary>
        public IEnumerable<DbSet> DbSets
        {
            get
            {
                yield return Products;
                yield return Transactions;
                yield return Categories;
                yield return Subjects;
            }
        }

        /// <summary>
        /// Устанавливает внешние ключи таблиц базы данных и связи "один ко многим" при инициализации модели базы данных.
        /// </summary>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasRequired<Category>(p => p.Category).WithMany().HasForeignKey(p => p.CategoryId);
            modelBuilder.Entity<Product>().HasRequired<Subject>(p => p.Subject).WithMany().HasForeignKey(p => p.SubjectId);
            modelBuilder.Entity<Transaction>().HasRequired<Product>(t => t.Product).WithMany().HasForeignKey(t => t.ProductId);
        }
    }
}
