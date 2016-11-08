using System.Collections.Generic;
using System.Linq;
using Model;

namespace Controller
{
    public class ProductController
    {
        public void Add(Product product)
        {
            var context = SingletonContext.GetContext();
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void Remove(int idProduct)
        {
            var context = SingletonContext.GetContext();
            var productToRemove = context.Products.Find(idProduct);
            context.Products.Remove(productToRemove);
            context.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
            var context = SingletonContext.GetContext();
            return context.Products.Include("Category").ToList();
        }
    }
}
