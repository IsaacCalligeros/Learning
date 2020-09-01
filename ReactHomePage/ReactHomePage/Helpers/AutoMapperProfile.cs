using AutoMapper;
using ReactHomePage.Models;
using System.Linq;

namespace ReactHomePage.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<News, News>();
        }
    }
}