using TaskClassification.Business.Features.Team.Abstract;
using TaskClassification.Business.Features.Team.Models;
using TaskClassification.Data;

namespace TaskClassification.Business.Features.Team.Implementation
{
    public class TeamService : ITeamService
    {
        private readonly DatabaseContext _context;

        public TeamService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<BaseResponse<TeamDto>> GetTeamAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse<IEnumerable<TeamDto>>> GetPagedTeamsAsync(int limit, int offset, string search)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse> AddUserToTheTeamAsync(int teamId, int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse> RemoveUserFromTheTeamAsync(int teamId, int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse> AddRepositoryToTheTeamAsync(int teamId, int repositoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse> RemoveRepositoryFromTheTeamAsync(int teamId, int repositoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse> CreateTeamAsync(TeamDto team)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse> UpdateTeamAsync(TeamDto team)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse> DeleteTeamAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
