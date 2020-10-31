using Catalog.Persistence;
using Catalog.Services.Queries.Dtos;
using Microsoft.EntityFrameworkCore;
using Service.Common.Collection;
using Service.Common.Mapping;
using Service.Common.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Services.Queries
{


    public interface IProductQueryService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="take"></param>
        /// <param name="products"></param>
        /// <returns></returns>
        Task<DataCollection<ProductDtos>> GetAllAsync(int page,
                                                      int take,
                                                      IEnumerable<int> products = null);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ProductDtos> GetAsync(int id);
    }



    public class ProductQueryService : IProductQueryService
    {

        /// <summary>
        /// 
        /// </summary>
        private readonly ApplicationDbContext _applicationDbContext;


        public ProductQueryService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="take"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        public async Task<DataCollection<ProductDtos>> GetAllAsync(int page,
                                                                   int take,
                                                                   IEnumerable<int> products = null)
        {
            var collection = await _applicationDbContext.Products
                                    .Where(x => products == null || products.Contains(x.ProductID))
                                    .OrderByDescending(x => x.ProductID)
                                    .GetPagedAsync(page, take);


            return collection.MapTo<DataCollection<ProductDtos>>();
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ProductDtos> GetAsync(int id)
        {
            return (await _applicationDbContext.Products.SingleAsync(x => x.ProductID == id)).MapTo<ProductDtos>();
        }
    }
}
