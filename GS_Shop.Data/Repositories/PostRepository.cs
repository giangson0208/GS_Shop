using GS_Shop.Data.Infrastructure;
using GS_Shop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GS_Shop.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetAllByTag(string tag, int page, int pageSize, out int totalRow);
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Post> GetAllByTag(string tag, int page, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.Posts   //xây dựng IEnumerable bằng cách join 2 bảng và lấy theo tag
                        join pt in DbContext.PostTags
                        on p.ID equals pt.PostID
                        where pt.TagID == tag && p.Status
                        orderby p.CreatedDate descending
                        select p;
            totalRow = query.Count();   //lấy ra tổng số trang
            query = query.Skip((page - 1) * pageSize).Take(pageSize);//phân trang
            return query;
        }
    }
}