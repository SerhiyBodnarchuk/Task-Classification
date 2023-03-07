namespace TaskClassification.Business.Features.Authentication.Models
{
    public class JwtModel
    {
        public string Token { get; set; } 
        public DateTime Expiration { get; set; } 
    }
}
