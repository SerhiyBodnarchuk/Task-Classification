namespace TaskClassification.Business.Features.User.Abstract
{
    public interface IUserService
    {
        Task<BaseResponse> CreateUserAsync(string userName, string email, string password, string role);
    }
}
