using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskClassification.Api.Models.Ticket;
using TaskClassification.Business.Features.Ticket.Models;
using TaskClassification.Business.Features.Ticket.Abstract;

namespace TaskClassification.Api.Controllers
{
    [Authorize]
    public class TicketController : BaseApiController
    {
        private readonly ITicketService _ticketService;
        private readonly IMapper _mapper;

        public TicketController(ITicketService ticketService, IMapper mapper)
        {
            _ticketService = ticketService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTicket([FromRoute] int id)
        {
            var result = await _ticketService.GetTicketAsync(id);

            return Ok(result.Result);
        }

        [HttpGet("Tickets")]
        public async Task<IActionResult> GetPagedTickets([FromQuery] int limit = 10, [FromQuery] int offset = 0, [FromQuery] string search = "")
        {
            var result = await _ticketService.GetPagedTicketsAsync(limit, offset, search);

            return Ok(result.Result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTicket(TicketViewModel TicketModel)
        {
            var ticket = _mapper.Map<TicketDto>(TicketModel);

            var result = await _ticketService.UpdateTicketAsync(ticket);

            return result.IsSuccessful
                ? Accepted()
                : StatusCode(StatusCodes.Status500InternalServerError, result.Message);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTicket(int id)
        {
            var result = await _ticketService.DeleteTicketAsync(id);

            return result.IsSuccessful
                ? NoContent()
                : StatusCode(StatusCodes.Status500InternalServerError, result.Message);
        }
    }
}
