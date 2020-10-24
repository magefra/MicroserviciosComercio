using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain
{
    public class Product
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }


        public decimal Price { get; set; }

        public ProductStock Stock { get; set; }
    }
}
