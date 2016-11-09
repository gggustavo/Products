using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Sale
    {
        public int IdSale { get; set; }
        public DateTime DateSale { get; set; }
                        
        public ICollection<Product> Products  { get; set; }



    }
}
