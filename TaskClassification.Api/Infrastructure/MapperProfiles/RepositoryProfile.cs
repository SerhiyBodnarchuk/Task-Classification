using AutoMapper;
using TaskClassification.Api.Models.Repository;
using TaskClassification.Business.Features.Repository.Models;

namespace TaskClassification.Api.Infrastructure.MapperProfiles
{
    public class RepositoryProfile : Profile
    {
        public RepositoryProfile()
        {
            CreateMap<RepositoryViewModel, RepositoryDto>().ReverseMap();
        }
    }
}
