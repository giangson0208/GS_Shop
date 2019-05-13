using GS_Shop.Data.Infrastructure;
using GS_Shop.Data.Repositories;
using GS_Shop.Model.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS_Shop.UnitTest.RepositoryTest
{   
    [TestClass]
    public class PostCategoryRepositoryTest //phải để public thì tool test mới thấy được
    {
        IDbFactory dbFactory; //khai báo thì dùng interface
        IPostCategoryRepository objRepository;
        IUnitOfWork unitOfWork;

        [TestInitialize]
        public void Initialize() //thằng này sẽ chạy đầu tiên để thiết lập tham số đối tượng
        {
            dbFactory = new DbFactory(); //khởi tạo dùng contructor
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }
        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test category";    //xem trong DB trường nào không cho null thì dùng
            category.Alias = "test-category";
            category.Status = true;

            var result = objRepository.Add(category);
            unitOfWork.Commit(); //sau khi commit thành công sẽ sinh ra 1 cái Id = 1
            Assert.IsNotNull(result);   //result not null trả về true
            Assert.AreEqual(1, result.ID);  //so sánh 1 vs Id giống trả về true
        }
        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = objRepository.GetAll().ToList();
            Assert.AreEqual(1, list.Count);
        }
    }
}
