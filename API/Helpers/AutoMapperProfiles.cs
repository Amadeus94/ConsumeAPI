using API.Entities;
using ApiLibrary.Models;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<ActivityModel, ActivityEntity>();
        }
    }
}