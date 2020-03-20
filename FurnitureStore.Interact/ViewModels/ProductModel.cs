using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureStore.Interact.ViewModels
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
