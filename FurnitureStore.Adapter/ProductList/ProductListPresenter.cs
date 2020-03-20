using System.Linq;
using FurnitureStore.Interact.ProductList;

namespace FurnitureStore.Adapter.ProductList
{
    public class ProductListPresenter : IProductListOutput
    {
        private readonly IProductList productList;

        public ProductListPresenter(IProductList productList)
        {
            this.productList = productList;
        }
        public void GotProducts(GetProductResponse getProductResponse)
        {
            productList.Products = getProductResponse.Products.Select(x => new ProductsModel
            {
                Id = x.Id,
                Desription = x.Description,
                Name = x.Name,
                Price = x.Price
            }).ToList();
        }
    }
}
