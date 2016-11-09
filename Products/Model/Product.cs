using System.Collections.Generic;

namespace Model
{
    public class Product
    {
        public int IdProduct { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int IdCategory { get; set; }
        public Category Category { get; set; }

        public ICollection<Sale> Sale { get; set; }
    }
}
