namespace TaskClassification.Data.Entities
{
    public class Repository
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}
