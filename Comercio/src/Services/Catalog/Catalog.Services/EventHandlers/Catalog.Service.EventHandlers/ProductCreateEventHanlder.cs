using Catalog.Domain;
using Catalog.Persistence;
using Catalog.Service.EventHandlers.Commands;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.Service.EventHandlers
{
    public class ProductCreateEventHanlder : 
                 INotificationHandler<ProductCreateCommand>
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ApplicationDbContext _applicationDbContext;




        public ProductCreateEventHanlder(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public async Task Handle(ProductCreateCommand command, CancellationToken cancellationToken)
        {
            await _applicationDbContext.AddAsync(new Product
            {
                Name = command.Name,
                Description = command.Description,
                Price = command.Price
            });


            await _applicationDbContext.SaveChangesAsync();
        }

       
    }
}
