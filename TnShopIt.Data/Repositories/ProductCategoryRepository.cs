using System.Collections.Generic;
using System.Linq;
using TnShopIt.Data.Infrastructure;
using TnShopIt.Model.Models;


namespace TnShopIt.Data.Repositories
{
    //Để định nghĩa các phương thức mà k có sẵn trong Repository
    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {
        //Định nghĩa phương thức không có sẵn trong Repository
        IEnumerable<ProductCategory> GetAlias(string alias);
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}