using Microsoft.AspNetCore.Identity;

namespace TaskClassification.Data.Entities
{
    public class TeamUser
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int UserId { get; set; }
        public virtual Team Team { get; set; }
        public virtual User User { get; set; }
    }
}
