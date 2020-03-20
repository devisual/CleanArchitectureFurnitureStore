using System;
using System.Collections.Generic;
using System.Text;
using FurnitureStore.Interact.ViewModels;

namespace FurnitureStore.Interact.ProductList
{
    public interface IProductListOutput
    {
        void GotProducts(GetProductResponse getProductResponse);
    }

    public class GetProductResponse
    {
        public IEnumerable<ProductModel> Products { get; set; }
    }
}
