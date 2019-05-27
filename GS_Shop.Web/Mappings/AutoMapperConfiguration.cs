using AutoMapper;
using GS_Shop.Model.Model;
using GS_Shop.Web.Models;

namespace GS_Shop.Web.Mapping
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostViewModel>(); //map từ đối tượng kiểu Post sáng kiểu PostViewModel
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<PostTag, PostTagViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
        }
    }
}