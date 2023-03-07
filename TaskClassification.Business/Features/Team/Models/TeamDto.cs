namespace TaskClassification.Business.Features.Team.Models
{
    public record TeamDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
