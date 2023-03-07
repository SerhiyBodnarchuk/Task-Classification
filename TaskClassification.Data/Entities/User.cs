using Microsoft.AspNetCore.Identity;

namespace TaskClassification.Data.Entities
{
    public class User : IdentityUser<int>
    {
        public User() : base()
        {
            Teams = new HashSet<TeamUser>();
        }

        public virtual ICollection<TeamUser> Teams { get; set; }
    }
}
