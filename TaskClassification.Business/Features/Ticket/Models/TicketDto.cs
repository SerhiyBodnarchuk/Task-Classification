namespace TaskClassification.Business.Features.Ticket.Models
{
    public record TicketDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Result { get; set; }
    }
}
