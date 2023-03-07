using TaskClassification.Business.Features.Authentication.Models;

namespace TaskClassification.Business.Features.Authentication.Abstract
{
    public interface IAuthManager
    {
        Task<BaseResponse<JwtModel>> AuthenticateAsync(string username, string password);
    }
}
