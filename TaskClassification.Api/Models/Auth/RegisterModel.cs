using System.ComponentModel.DataAnnotations;
using TaskClassification.Shared.Constants;

namespace TaskClassification.Api.Models.Auth
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

        public string? Role { get; set; } = UserRoles.User;
    }
}
