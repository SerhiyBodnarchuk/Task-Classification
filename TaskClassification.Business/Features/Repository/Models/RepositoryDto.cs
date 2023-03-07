namespace TaskClassification.Business.Features.Repository.Models
{
    public record RepositoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
