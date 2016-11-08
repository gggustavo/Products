using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Model
{
    public class Context : DbContext
    {
        public Context() : base("name=Default")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer(new ContextInitializer());
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Product>()
                .HasKey(_ => _.IdProduct)
                .HasRequired(_ => _.Category);

            modelBuilder.Entity<Category>().HasKey(_ => _.IdCategory);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

 
    }
}
