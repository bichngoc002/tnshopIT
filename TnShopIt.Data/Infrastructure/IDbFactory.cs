using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TnShopIt.Data.Infrastructure
{
    //Là lớp giao tiếp khởi tạo các đối tượng Entity, Không khởi tạo trực tiếp.  s
    public interface IDbFactory : IDisposable
    {
        TnShopItDbContext Init();
    }
}
