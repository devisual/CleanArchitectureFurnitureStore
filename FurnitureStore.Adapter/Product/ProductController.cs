using FurnitureStore.Interact;
using FurnitureStore.Interact.Product;

namespace FurnitureStore.Adapter.Product
{
    public class ProductController
    {
        private readonly IProductInput productInput;

        public ProductController(IProductInput productInput)
        {
            this.productInput = productInput;
        }
    }
}
