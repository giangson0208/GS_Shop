using GS_Shop.Data.Infrastructure;
using GS_Shop.Data.Repositories;
using GS_Shop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS_Shop.Service
{
    public interface IErrorService
    {
        Error Add(Error error);
        void SaveChanges();
    }
    public class ErrorService : IErrorService
    {
        IErrorRepository _errorRepository;
        IUnitOfWork _unitOfWork;
        public ErrorService(IErrorRepository errorRepository, IUnitOfWork unitOfWork)
        {
            this._errorRepository = errorRepository; //gán vào biến nội tại và thao tác trong các phương thức
            this._unitOfWork = unitOfWork;
        }
        public Error Add(Error error)
        {
            return _errorRepository.Add(error);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }
    }
}
