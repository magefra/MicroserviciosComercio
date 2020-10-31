using Microsoft.EntityFrameworkCore;
using Service.Common.Collection;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace Service.Common.Paging
{
    public static class PagingExension
    {

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="page"></param>
        /// <param name="take"></param>
        /// <returns></returns>
        public static async Task<DataCollection<T>> GetPagedAsync<T>(
            this IQueryable<T> query,
            int page,
            int take
            )
        {
            var original = page;

            page--;

            if (page > 0)
                page = page * take;

            var result = new DataCollection<T>
            {
                Items = await query.Skip(page).Take(take).ToListAsync(),
                Total = await query.CountAsync(),
                Page = original
            };


            if(result.Total > 0)
            {
                result.Pages = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(result.Total) / take));
            }

            return result;
        }
      
    }
}
