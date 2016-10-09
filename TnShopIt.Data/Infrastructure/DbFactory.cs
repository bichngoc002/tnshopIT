namespace TnShopIt.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TnShopItDbContext dbContext;

        public TnShopItDbContext Init()
        {
            //Kiểm tra nếu null sẽ khởi tạo new mới.
            return dbContext ?? (dbContext = new TnShopItDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}