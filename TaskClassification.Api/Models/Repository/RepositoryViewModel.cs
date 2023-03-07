namespace TaskClassification.Api.Models.Repository
{
    public record RepositoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
