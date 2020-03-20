using FurnitureStore.Interact;

namespace FurnitureStore.Adapter.Product
{
    public class ProductController
    {
        private readonly IProductInput productInput;
        private readonly IProductGateway productGateway;

        public ProductController(IProductInput productInput, IProductGateway productGateway)
        {
            this.productInput = productInput;
            this.productGateway = productGateway;
        }
    }
}
