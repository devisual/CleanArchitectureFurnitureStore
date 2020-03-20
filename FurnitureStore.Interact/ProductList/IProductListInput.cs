using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureStore.Interact.ProductList
{
    public interface IProductListInput
    {
        void GettingProducts(GetProductRequest getProductRequest);
    }

    public class GetProductRequest
    {

    }
}
