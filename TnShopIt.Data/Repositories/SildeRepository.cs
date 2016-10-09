using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TnShopIt.Data.Infrastructure;
using TnShopIt.Model.Models;

namespace TnShopIt.Data.Repositories
{
    //Để định nghĩa các phương thức mà k có sẵn trong Repository
    public interface ISildeRepository : IRepository<Slide> { }

    public class SildeRepository : RepositoryBase<Slide>,ISildeRepository
    {
        public SildeRepository(DbFactory dbFactory) : base(dbFactory) { }
    }
}
