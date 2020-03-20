using System.Collections.Generic;

namespace FurnitureStore.Domain.Model
{
    public class Basket
    {
        public int Id { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
