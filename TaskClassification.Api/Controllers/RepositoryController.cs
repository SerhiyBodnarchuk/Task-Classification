using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskClassification.Api.Models.Repository;
using TaskClassification.Business.Features.Repository.Abstract;
using TaskClassification.Business.Features.Repository.Models;

namespace TaskClassification.Api.Controllers
{
    [Authorize]
    public class RepositoryController : BaseApiController
    {
        private readonly IRepositoryService _repositoryService;
        private readonly IMapper _mapper;

        public RepositoryController(IRepositoryService repositoryService, IMapper mapper)
        {
            _repositoryService = repositoryService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRepository([FromRoute] int id)
        {
            var result = await _repositoryService.GetRepositoryAsync(id);

            return Ok(result.Result);
        }

        [HttpGet("repositories")]
        public async Task<IActionResult> GetPagedRepositories([FromQuery] int limit = 10, [FromQuery] int offset = 0, [FromQuery] string search = "")
        {
            var result = await _repositoryService.GetPagedRepositoriesAsync(limit, offset, search);

            return Ok(result.Result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRepository(RepositoryViewModel repositoryModel)
        {
            var repository = _mapper.Map<RepositoryDto>(repositoryModel);

            var result = await _repositoryService.CreateRepositoryAsync(repository);

            return result.IsSuccessful
                ? StatusCode(201)
                : StatusCode(StatusCodes.Status500InternalServerError, result.Message);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRepository(RepositoryViewModel repositoryModel)
        {
            var repository = _mapper.Map<RepositoryDto>(repositoryModel);

            var result = await _repositoryService.UpdateRepositoryAsync(repository);

            return result.IsSuccessful
                ? Accepted()
                : StatusCode(StatusCodes.Status500InternalServerError, result.Message);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteRepository(int id)
        {
            var result = await _repositoryService.DeleteRepositoryAsync(id);

            return result.IsSuccessful
                ? NoContent()
                : StatusCode(StatusCodes.Status500InternalServerError, result.Message);
        }
    }
}
