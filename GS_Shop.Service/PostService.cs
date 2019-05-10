using GS_Shop.Data.Infrastructure;
using GS_Shop.Data.Repositories;
using GS_Shop.Model.Model;
using System.Collections.Generic;

namespace GS_Shop.Service
{
    public interface IPostService
    {
        void Add(Post post);    //thêm bản ghi

        void Update(Post post); //sửa

        void Delete(int id);    //xóa

        IEnumerable<Post> GetAll(); //lấy tất cả bản ghi

        Post GetById(int id);   //lấy bản ghi theo ID

        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow); //lấy bản ghi đã phân trang

        IEnumerable<Post> GetByTagPaging(string tag, int page, int pageSize, out int totalRow); //lấy bản ghi theo tag đã phân trang

        void SaveChanges();
    }

    public class PostService : IPostService
    {
        private IPostRepository _postRepository;
        private IUnitOfWork _unitOfWork;

        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork) //Mối lần khởi tạo class Service thì phải truyền 2 cái đối tượng của IPostRepository và IUnitOfWork
        {
            this._postRepository = postRepository; //gán vào biến nội tại và thao tác trong các phương thức
            this._unitOfWork = unitOfWork;
        }

        public void Add(Post post)
        {
            _postRepository.Add(post);
        }

        public void Delete(int id)
        {
            _postRepository.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postRepository.GetAll(new string[] { "PostCategory" }); //lấy được ra đối tượng category theo cái Post truyền vào
            //VD : select bài viết và select đc cả cái category của nó để sau này show ra chi tiết tin tức có thể show ra tên danh mục
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Post GetById(int id)
        {
            return _postRepository.GetSingleById(id);
        }

        public IEnumerable<Post> GetByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }
    }
}