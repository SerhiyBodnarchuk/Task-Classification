using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using TaskClassification.Business.Features.Authentication.Abstract;
using TaskClassification.Business.Features.Authentication.Models;
using TaskClassification.Shared.Options;

namespace TaskClassification.Business.Features.Authentication.Implementation
{
    public class AuthManager : IAuthManager
    {
        private readonly UserManager<Data.Entities.User> _userManager;
        private readonly JwtOptions _jwtOptions;

        public AuthManager(UserManager<Data.Entities.User> userManager, IOptions<JwtOptions> jwtOptions)
        {
            _userManager = userManager;
            _jwtOptions = jwtOptions.Value;
        }

        public async Task<BaseResponse<JwtModel>> AuthenticateAsync(string username, string password)
        {
            var response = new BaseResponse<JwtModel>();

            var user = await _userManager.FindByNameAsync(username);
            if (user == null || !await _userManager.CheckPasswordAsync(user, password))
            {
                response.ToFailed("Can't authenticate user with such credentials.");
                return response;
            }
                
            var userRoles = await _userManager.GetRolesAsync(user);

            var authClaims = new List<Claim>
            {
                new(ClaimTypes.Name, user.UserName),
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            authClaims.AddRange(userRoles.Select(userRole => new Claim(ClaimTypes.Role, userRole)));

            var token = GenerateToken(authClaims);

            response.Result = new JwtModel
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = token.ValidTo
            };

            return response;
        }

        private JwtSecurityToken GenerateToken(IEnumerable<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.Secret));

            var token = new JwtSecurityToken(
                issuer: _jwtOptions.ValidIssuer,
                audience: _jwtOptions.ValidAudience,
                expires: DateTime.Now.AddMinutes(_jwtOptions.ExpireInMinutes),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );

            return token;
        }
    }
}
