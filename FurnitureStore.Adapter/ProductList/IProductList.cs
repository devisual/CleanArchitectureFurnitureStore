﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureStore.Adapter.ProductList
{
    public interface IProductList
    {
        IList<ProductsModel> Products { get; set; }
    }
}
