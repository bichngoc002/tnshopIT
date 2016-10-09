using AutoMapper;
using TnShopIt.Model.Models;
using TnShopIt.Web.Models;

namespace TnShopIt.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Post, TagViewModel>();
        }
    }
}