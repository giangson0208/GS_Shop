using GS_Shop.Data.Infrastructure;
using GS_Shop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS_Shop.Data.Repositories
{
    public interface IErrorRepository : IRepository<Error> //interface này dùng để định nghĩa các phương thức cần phải thêm k nằm trong RepositoryBase
    {
    }

    public class ErrorRepositoy : RepositoryBase<Error>, IErrorRepository //RepositoryBase cần truyền vào 1 kiểu theo tác
    {
        public ErrorRepositoy(DbFactory dbFactory) : base(dbFactory) //nhận đối tượng truyền vào là 1 đối tượng DbFactory
        {
            //nếu không có phương thức đặc thù mà chỉ dùng chung các pt trong RepositoryBase thì chỉ cần Contructor này thôi
        }
    }
}
