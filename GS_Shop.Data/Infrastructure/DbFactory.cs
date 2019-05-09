namespace GS_Shop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private GS_ShopDbContext DbContext; 

        public GS_ShopDbContext Init() //gọi hàm Init
        {
            return DbContext ?? (DbContext = new GS_ShopDbContext()); //kiểm tra nếu DbContext = null thì sẽ khởi tạo
        }

        protected override void DisposeCore()
        {
            if (DbContext != null){ //nếu khác null thì Dispose
                DbContext.Dispose();
            }
        }
    }
}