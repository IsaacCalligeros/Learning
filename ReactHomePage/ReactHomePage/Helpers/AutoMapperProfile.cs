using AutoMapper;
using ReactHomePage.Entities.Models;
using ReactHomePage.Models;
using System.Linq;

namespace ReactHomePage.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<News, News>();
            CreateMap<Layout, Layout>();
            CreateMap<BaseContainer, BaseContainer>();
        }
    }
}