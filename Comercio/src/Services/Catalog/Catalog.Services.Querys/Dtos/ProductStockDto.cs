using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Services.Queries.Dtos
{
    public class ProductStockDto
    {
        public int ProductInStockId { get; set; }

        public int ProductId { get; set; }

        public int Stock { get; set; }
    }
}
