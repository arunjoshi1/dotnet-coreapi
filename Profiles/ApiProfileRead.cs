using api.Dtos;
using api.Models;
using AutoMapper;

namespace api.Profiles
{
    public class ApiProfileRead : Profile
    {
        public ApiProfileRead()
        {
            CreateMap<ApiModel, ApiDto>();
        }
    }
}
