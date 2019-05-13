using GS_Shop.Model.Model;
using GS_Shop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GS_Shop.Web.Infrastructure.Extentions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoryVM)//copy toàn bộ giá trị PostCategoryViewModel đẩy vào đối tượng postCategory
        {
            postCategory.ID = postCategoryVM.ID;
            postCategory.Name = postCategoryVM.Name;
            postCategory.Alias = postCategoryVM.Alias;
            postCategory.Image = postCategoryVM.Image;
            postCategory.Description = postCategoryVM.Description;
            postCategory.DisplayOrder = postCategoryVM.DisplayOrder;
            postCategory.HomeFlag = postCategoryVM.HomeFlag;
            postCategory.ParentID = postCategoryVM.ParentID;

            postCategory.CreatedBy = postCategoryVM.CreatedBy;
            postCategory.CreatedDate = postCategoryVM.CreatedDate;
            postCategory.UpdateBy = postCategoryVM.UpdateBy;
            postCategory.UpdateDate = postCategoryVM.UpdateDate;
            postCategory.MetaKeyword = postCategoryVM.MetaKeyword;
            postCategory.MetaDescription = postCategoryVM.MetaDescription;
            postCategory.Status = postCategoryVM.Status;


        }
        public static void UpdatePost(this Post post, PostViewModel postVM)
        {
            post.ID = postVM.ID;
            post.Name = postVM.Name;
            post.Alias = postVM.Alias;
            post.CategoryID = postVM.CategoryID;
            post.Image = postVM.Image;
            post.Description = postVM.Description;
            post.Content = postVM.Content;
            post.HomeFlag = postVM.HomeFlag;
            post.HotFlag = postVM.HotFlag;
            post.ViewCout = postVM.ViewCout;

            post.CreatedBy = postVM.CreatedBy;
            post.CreatedDate = postVM.CreatedDate;
            post.UpdateBy = postVM.UpdateBy;
            post.UpdateDate = postVM.UpdateDate;
            post.MetaKeyword = postVM.MetaKeyword;
            post.MetaDescription = postVM.MetaDescription;
            post.Status = postVM.Status;
        }
    }
}