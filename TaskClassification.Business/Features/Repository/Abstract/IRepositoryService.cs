using TaskClassification.Business.Features.Repository.Models;

namespace TaskClassification.Business.Features.Repository.Abstract
{
    public interface IRepositoryService
    {
        Task<BaseResponse<RepositoryDto>> GetRepositoryAsync(int id);
        Task<BaseResponse<IEnumerable<RepositoryDto>>> GetPagedRepositoriesAsync(int limit, int offset, string search);
        Task<BaseResponse> CreateRepositoryAsync(RepositoryDto repository);
        Task<BaseResponse> UpdateRepositoryAsync(RepositoryDto repository);
        Task<BaseResponse> DeleteRepositoryAsync(int id);
    }
}
