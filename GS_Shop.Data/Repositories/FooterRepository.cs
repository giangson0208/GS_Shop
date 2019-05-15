using GS_Shop.Data.Infrastructure;
using GS_Shop.Model.Model;

namespace GS_Shop.Data.Repositories
{
    public interface IFooterRepository : IRepository<Footer> //interface này dùng để định nghĩa các phương thức cần phải thêm k nằm trong RepositoryBase
    {
    }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository //RepositoryBase cần truyền vào 1 kiểu theo tác
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory) //nhận đối tượng truyền vào là 1 đối tượng DbFactory
        {
            //nếu không có phương thức đặc thù mà chỉ dùng chung các pt trong RepositoryBase thì chỉ cần Contructor này thôi
        }
    }
}