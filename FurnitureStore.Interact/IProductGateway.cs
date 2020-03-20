using System;
using System.Collections.Generic;
using System.Text;
using FurnitureStore.Interact.ViewModels;

namespace FurnitureStore.Interact
{
    public interface IProductGateway
    {
        IEnumerable<ProductModel> GetProducts();
    }
}
