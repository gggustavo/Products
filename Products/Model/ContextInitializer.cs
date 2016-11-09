using System.Data.Entity;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Model
{
    class ContextInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            AddCategories(context);
            AddProduts(context);
            AddSale(context);

            base.Seed(context);
        }

        private static void AddCategories(Context context)
        {
            context.Categories.Add(new Category {Name = "Category 1"});
            context.Categories.Add(new Category {Name = "Category 2"});
            context.Categories.Add(new Category {Name = "Category 3"});
            context.Categories.Add(new Category {Name = "Category 4"});
            context.Categories.Add(new Category {Name = "Category 5"});
            context.Categories.Add(new Category {Name = "Category 6"});
            context.SaveChanges();
        }

        private static void AddProduts(Context context)
        {
            context.Products.Add(new Product
            {
                Name = "Product 1",
                IdCategory = 1,
                Price = 1200
            });

            context.Products.Add(new Product
            {
                Name = "Product 2",
                IdCategory = 2,
                Price = 2200
            });

            context.Products.Add(new Product
            {
                Name = "Product 3",
                IdCategory = 3,
                Price = 5000
            });

            context.Products.Add(new Product
            {
                Name = "Product 4",
                IdCategory = 2,
                Price = 1000
            });

            context.SaveChanges();
        }

        private static void AddSale(Context context) {

            var products = context.Products.Where(_ => _.IdProduct <= 4).ToList();

            var sale = new Sale
            {
                DateSale = DateTime.Now,
                Products = products
            };

            context.Sales.Add(sale);
            context.SaveChanges();
            
        }        
    }
}
