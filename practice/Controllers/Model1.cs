namespace practice.Controllers
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<item> items { get; set; }
        public virtual DbSet<store> stores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<item>()
                .Property(e => e.item_name)
                .IsUnicode(false);

            modelBuilder.Entity<store>()
                .Property(e => e.book_name)
                .IsUnicode(false);

            modelBuilder.Entity<store>()
                .Property(e => e.author_name)
                .IsUnicode(false);
        }
    }
}
