using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaskClassification.Shared.Options;

namespace TaskClassification.Shared
{
    public static class DependencyInjection
    {
        public static void AddShared(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<JwtOptions>(
                 configuration.GetSection("JWT"));
        }
    }
}
