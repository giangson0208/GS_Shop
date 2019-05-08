namespace GS_Shop.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private GS_ShopDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory) //gọi hàm Init
        {
            this.dbFactory = dbFactory;
        }

        public GS_ShopDbContext DbContext //gọi hàm Init
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}