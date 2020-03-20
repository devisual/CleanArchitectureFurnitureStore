using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureStore.Interact.ProductList
{
    public class ProductListInteractor : IProductListInput
    {
        private readonly IProductListOutput productOutput;
        private readonly IProductGateway productGateway;

        public ProductListInteractor(IProductListOutput productOutput, IProductGateway productGateway)
        {
            this.productOutput = productOutput;
            this.productGateway = productGateway;
        }
        public void GettingProducts(GetProductRequest getProductRequest)
        {
            productOutput.GotProducts(new GetProductResponse
            {
                Products = productGateway.GetProducts()
            });
        }
    }
}
