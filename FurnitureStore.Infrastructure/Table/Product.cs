using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureStore.Infrastructure.Table
{
    public class Product
    {
        public int Id { get; set; }
        public DateTime? Created { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public int? ModifiedBy { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
    }
}
