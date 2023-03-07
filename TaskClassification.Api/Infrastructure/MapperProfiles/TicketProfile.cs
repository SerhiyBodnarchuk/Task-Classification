using AutoMapper;
using TaskClassification.Api.Models.Ticket;
using TaskClassification.Business.Features.Ticket.Models;

namespace TaskClassification.Api.Infrastructure.MapperProfiles
{
    public class TicketProfile : Profile
    {
        public TicketProfile()
        {
            CreateMap<TicketViewModel, TicketDto>().ReverseMap();
        }
    }
}
