using TaskClassification.Business.Features.Team.Models;

namespace TaskClassification.Business.Features.Team.Abstract
{
    public interface ITeamService
    {
        Task<BaseResponse<TeamDto>> GetTeamAsync(int id);
        Task<BaseResponse<IEnumerable<TeamDto>>> GetPagedTeamsAsync(int limit, int offset, string search);
        Task<BaseResponse> CreateTeamAsync(TeamDto team);
        Task<BaseResponse> UpdateTeamAsync(TeamDto team);
        Task<BaseResponse> DeleteTeamAsync(int id);
        Task<BaseResponse> AddUserToTheTeamAsync(int teamId, int userId);
        Task<BaseResponse> RemoveUserFromTheTeamAsync(int teamId, int userId);
        Task<BaseResponse> AddRepositoryToTheTeamAsync(int teamId, int repositoryId);
        Task<BaseResponse> RemoveRepositoryFromTheTeamAsync(int teamId, int repositoryId);
    }
}
