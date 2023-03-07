using Microsoft.AspNetCore.Identity;
using TaskClassification.Business.Features.User.Abstract;

namespace TaskClassification.Business.Features.User.Implementation
{
    public class UserService : IUserService
    {
        private readonly UserManager<Data.Entities.User> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public UserService(UserManager<Data.Entities.User> userManager, RoleManager<IdentityRole<int>> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<BaseResponse> CreateUserAsync(string userName, string email, string password, string role)
        {
            var response = new BaseResponse();

            var userExists = await _userManager.FindByNameAsync(userName);
            if (userExists != null)
            {
                response.ToFailed("User already exists.");
                return response;
            }

            var user = new Data.Entities.User
            {
                Email = email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = userName
            };

            var creationResult = await _userManager.CreateAsync(user, password);

            if (!creationResult.Succeeded)
            {
                response.ToFailed("User creation failed. Please check user details and try again.");
                return response;
            }

            if (await _roleManager.RoleExistsAsync(role))
            {
                await _userManager.AddToRoleAsync(user, role);
            }

            return response;
        }
    }
}
