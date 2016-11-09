using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Controller
{
    public class SaleController
    {

        public ICollection<DataSale> GetAllByDate(DateTime date)
        {
            var context = Model.SingletonContext.GetContext();

            var items = context.Sales.Include("Products")
                                .Where(_ => DbFunctions.TruncateTime(_.DateSale) == DbFunctions.TruncateTime(date))
                                .ToList();

            var collection = new List<DataSale>();

            foreach (var item in items)
            {
                foreach (var product in item.Products)
	            {
		             collection.Add(new DataSale {
                            NameProduct = product.Name,
                            Price = product.Price,
                            IdSale = item.IdSale,
                            DateSale = item.DateSale
                        });
	            }   
            } 
            return collection;
        }
        
    }

    public class DataSale
    {
        public int IdSale { get; set; }
        public DateTime DateSale { get; set; }
        public string NameProduct { get; set; }
        public decimal Price { get; set; }
    }
}
