using Catalog.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.ProductID);

            entityTypeBuilder.Property(x => x.Name)
                             .IsRequired()
                             .HasMaxLength(100);


            entityTypeBuilder.Property(x => x.Description)
                             .IsRequired()
                             .HasMaxLength(500);





            var products = new List<Product>();
            var random = new Random();


            for(var i = 1; i<= 100; i++)
            {
                products.Add(new Product
                {
                    ProductID = i,
                    Name = $"Product {i}",
                    Description = $"Description for product {i}",
                    Price = random.Next(100, 1000)

                });
            }

            entityTypeBuilder.HasData(products);

        }
    }
}
