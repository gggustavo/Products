using System.Collections.Generic;
using System.Linq;
using Model;

namespace Controller
{
    public class CategoryController
    {
        public void Add(Category category)
        {
            var context = SingletonContext.GetContext();
            context.Categories.Add(category);
            context.SaveChanges();
        }

        public void Remove(int idCategory)
        {
            var context = SingletonContext.GetContext();
            var categoryToRemove = context.Categories.Find(idCategory);
            context.Categories.Remove(categoryToRemove);
            context.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
            var context = SingletonContext.GetContext();
            return context.Categories.ToList();
        }
    }
}
