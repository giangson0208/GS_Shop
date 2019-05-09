using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS_Shop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
