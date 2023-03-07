namespace TaskClassification.Data.Entities
{
    public class Team
    {
        public Team()
        {
            Repositories = new HashSet<Repository>();
            Users = new HashSet<TeamUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Repository> Repositories { get; set; }
        public virtual ICollection<TeamUser> Users { get; set; }
    }
}
