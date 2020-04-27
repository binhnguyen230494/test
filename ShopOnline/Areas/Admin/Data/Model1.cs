namespace ShopOnline.Areas.Admin.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=OnlineShop")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Link> Links { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Link>()
                .Property(e => e.LinkDescription)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);
        }
    }
}
