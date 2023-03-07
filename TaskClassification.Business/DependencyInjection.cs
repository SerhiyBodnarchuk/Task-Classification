using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaskClassification.Business.Features.Authentication.Abstract;
using TaskClassification.Business.Features.Authentication.Implementation;
using TaskClassification.Business.Features.Repository.Abstract;
using TaskClassification.Business.Features.Repository.Implementation;
using TaskClassification.Business.Features.Team.Abstract;
using TaskClassification.Business.Features.Team.Implementation;
using TaskClassification.Business.Features.Ticket.Abstract;
using TaskClassification.Business.Features.Ticket.Implementation;
using TaskClassification.Business.Features.User.Abstract;
using TaskClassification.Business.Features.User.Implementation;

namespace TaskClassification.Business
{
    public static class DependencyInjection
    {
        public static void AddBusiness(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IAuthManager, AuthManager>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ITeamService, TeamService>();
            services.AddTransient<IRepositoryService, RepositoryService>();
            services.AddTransient<ITicketService, TicketService>();
        }
    }
}
