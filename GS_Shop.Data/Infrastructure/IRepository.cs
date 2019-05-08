using System;
using System.Linq;
using System.Linq.Expressions;

namespace GS_Shop.Data.Infrastructure
{
    public interface IRepository<T> where T : class   //định nghĩa các phương thức có sẵn
    {   //sử dụng cho tất cả các class trong project
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void DeleteMulti(Expression<Func<T, bool>> where);

        T GetSingleById(int id);

        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null); //includes: thêm các bảng con vào

        IQueryable<T> GetAll(string[] includes = null);

        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);

        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 0, string[] includes = null);

        int Count(Expression<Func<T, bool>> where);

        bool CheckContains(Expression<Func<T, bool>> predicate);
    }
}