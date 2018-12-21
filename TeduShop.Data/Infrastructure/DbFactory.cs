using System;

namespace TeduShop.Data.Infrastructure
{
    internal class DbFactory : Disposable, IDbFactory
    {
        TeduShopDbContext dbContext;
        public TeduShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TeduShopDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}