namespace TaskClassification.Api.Models.Ticket
{
    public record TicketViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Result { get; set; }
    }
}
