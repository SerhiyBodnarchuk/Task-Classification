using TaskClassification.Business.Features.Ticket.Models;

namespace TaskClassification.Business.Features.Ticket.Abstract
{
    public interface ITicketService
    {
        Task<BaseResponse<TicketDto>> GetTicketAsync(int id);
        Task<BaseResponse<IEnumerable<TicketDto>>> GetPagedTicketsAsync(int limit, int offset, string search);
        Task<BaseResponse> UpdateTicketAsync(TicketDto ticket);
        Task<BaseResponse> DeleteTicketAsync(int id);
    }
}
