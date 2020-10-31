using Catalog.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Persistence.Configurations
{
    public class ProductStockConfiguration : IEntityTypeConfiguration<ProductStock>
    {
        public void Configure(EntityTypeBuilder<ProductStock> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.ProductInStockId);

            var products = new List<ProductStock>();
            var random = new Random();


            for (var i = 1; i <= 100; i++)
            {
                products.Add(new ProductStock
                {
                    ProductInStockId = i,
                    ProductId = i,
                    Stock = random.Next(100, 1000)

                });
            }

            entityTypeBuilder.HasData(products);

        }
    }
}
