using GS_Shop.Data.Infrastructure;
using GS_Shop.Model.Model;
using System.Collections.Generic;
using System.Linq;

namespace GS_Shop.Data.Repositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory>  //interface này dùng để định nghĩa các phương thức cần phải thêm k nằm trong RepositoryBase
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);  //trả ra 1 list ProductCategory
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository // kế thừa thông qua RepositoryBase mà k cần phải sử dụng hết tất cả các phương thức trong Interface IRepository
    {
        public ProductCategoryRepository(DbFactory dbFactory) : base(dbFactory) //nhận đối tượng truyền vào là 1 đối tượng DbFactory
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategorys.Where(x => x.Alias == alias);
        }
    }
}