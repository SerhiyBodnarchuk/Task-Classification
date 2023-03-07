using AutoMapper;
using TaskClassification.Api.Models.Team;
using TaskClassification.Business.Features.Team.Models;

namespace TaskClassification.Api.Infrastructure.MapperProfiles
{
    public class TeamProfile : Profile
    {
        public TeamProfile()
        {
            CreateMap<TeamViewModel, TeamDto>().ReverseMap();
        }
    }
}
