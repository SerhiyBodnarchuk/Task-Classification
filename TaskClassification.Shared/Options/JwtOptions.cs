namespace TaskClassification.Shared.Options
{
    public class JwtOptions
    {
        public string ValidIssuer { get; set; }
        public string ValidAudience { get; set; }
        public string Secret { get; set; }
        public int ExpireInMinutes { get; set; }
    }
}
