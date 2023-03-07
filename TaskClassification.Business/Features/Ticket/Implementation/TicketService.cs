using TaskClassification.Business.Features.Ticket.Abstract;
using TaskClassification.Business.Features.Ticket.Models;
using TaskClassification.Data;

namespace TaskClassification.Business.Features.Ticket.Implementation
{
    public class TicketService : ITicketService
    {
        private readonly DatabaseContext _context;

        public TicketService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<BaseResponse<TicketDto>> GetTicketAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse<IEnumerable<TicketDto>>> GetPagedTicketsAsync(int limit, int offset, string search)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse> UpdateTicketAsync(TicketDto ticket)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse> DeleteTicketAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
