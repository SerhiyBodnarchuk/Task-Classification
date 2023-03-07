namespace TaskClassification.Data.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Result { get; set; }
        public int StatusId { get; set; }
        public int RepositoryId { get; set; }
        public virtual Repository Repository { get; set; }
    }
}
