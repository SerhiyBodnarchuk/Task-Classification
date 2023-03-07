using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskClassification.Api.Models.Team;
using TaskClassification.Business.Features.Team.Abstract;
using TaskClassification.Business.Features.Team.Models;

namespace TaskClassification.Api.Controllers
{
    [Authorize]
    public class TeamController : BaseApiController
    {
        private readonly ITeamService _teamService;
        private readonly IMapper _mapper;

        public TeamController(ITeamService teamService, IMapper mapper)
        {
            _teamService = teamService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTeam([FromRoute] int id)
        {
            var result = await _teamService.GetTeamAsync(id);

            return Ok(result.Result);
        }

        [HttpGet("teams")]
        public async Task<IActionResult> GetPagedTeams([FromQuery] int limit = 10, [FromQuery] int offset = 0, [FromQuery] string search = "")
        {
            var result = await _teamService.GetPagedTeamsAsync(limit, offset, search);

            return Ok(result.Result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTeam(TeamViewModel teamModel)
        {
            var team = _mapper.Map<TeamDto>(teamModel);

            var result = await _teamService.CreateTeamAsync(team);

            return result.IsSuccessful
                ? StatusCode(201)
                : StatusCode(StatusCodes.Status500InternalServerError, result.Message);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTeam(TeamViewModel teamModel)
        {
            var team = _mapper.Map<TeamDto>(teamModel);

            var result = await _teamService.UpdateTeamAsync(team);

            return result.IsSuccessful
                ? Accepted()
                : StatusCode(StatusCodes.Status500InternalServerError, result.Message);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTeam(int id)
        {
            var result = await _teamService.DeleteTeamAsync(id);

            return result.IsSuccessful
                ? NoContent()
                : StatusCode(StatusCodes.Status500InternalServerError, result.Message);
        }

        [HttpPost("user")]
        public async Task<IActionResult> AddUserToTheTeam(int teamId, int userId)
        {
            var result = await _teamService.AddUserToTheTeamAsync(teamId, userId);

            return result.IsSuccessful
                ? StatusCode(201)
                : StatusCode(StatusCodes.Status500InternalServerError, result.Message);
        }

        [HttpDelete("user")]
        public async Task<IActionResult> RemoveUserFromTheTeam(int teamId, int userId)
        {
            var result = await _teamService.RemoveUserFromTheTeamAsync(teamId, userId);

            return result.IsSuccessful
                ? NoContent()
                : StatusCode(StatusCodes.Status500InternalServerError, result.Message);
        }

        [HttpPost("repository")]
        public async Task<IActionResult> AddRepositoryToTheTeam(int teamId, int repositoryId)
        {
            var result = await _teamService.AddRepositoryToTheTeamAsync(teamId, repositoryId);

            return result.IsSuccessful
                ? StatusCode(201)
                : StatusCode(StatusCodes.Status500InternalServerError, result.Message);
        }

        [HttpDelete("repository")]
        public async Task<IActionResult> RemoveRepositoryFromTheTeam(int teamId, int repositoryId)
        {
            var result = await _teamService.RemoveRepositoryFromTheTeamAsync(teamId, repositoryId);

            return result.IsSuccessful
                ? NoContent()
                : StatusCode(StatusCodes.Status500InternalServerError, result.Message);
        }
    }
}
