using TnShopIt.Data.Infrastructure;
using TnShopIt.Model.Models;

namespace TnShopIt.Data.Repositories
{
    //Để định nghĩa các phương thức mà k có sẵn trong Repository
    public interface IFooterRepsitory :IRepository<Footer>
    {
    }

    public class FooterRepsitory : RepositoryBase<Footer>, IFooterRepsitory
    {
        public FooterRepsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}