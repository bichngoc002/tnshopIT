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
    public interface ISystemConfigRepository : IRepository<SystemConfig> { }

    public class SystemConfigRepository : RepositoryBase<SystemConfig>, ISystemConfigRepository
    {
        public SystemConfigRepository(DbFactory dbFactory) : base(dbFactory) { }
    }
}
