using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Services.Queries.Dtos
{
    public class ProductDtos
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }


        public decimal Price { get; set; }

        public ProductStockDto Stock { get; set; }
    }
}
