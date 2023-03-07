using TaskClassification.Business.Features.Repository.Abstract;
using TaskClassification.Business.Features.Repository.Models;
using TaskClassification.Data;

namespace TaskClassification.Business.Features.Repository.Implementation
{
    public class RepositoryService : IRepositoryService
    {
        private readonly DatabaseContext _context;

        public RepositoryService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<BaseResponse<RepositoryDto>> GetRepositoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse<IEnumerable<RepositoryDto>>> GetPagedRepositoriesAsync(int limit, int offset, string search)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse> CreateRepositoryAsync(RepositoryDto repository)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse> UpdateRepositoryAsync(RepositoryDto repository)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse> DeleteRepositoryAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
