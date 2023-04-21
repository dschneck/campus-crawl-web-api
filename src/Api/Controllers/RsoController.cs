using Microsoft.AspNetCore.Mvc;
using DataAccess.Intefaces;
using DataAccess.Entities;
using DataAccess.Models;

namespace campus_crawl_web_api
{
    [ApiController]
    [Route("rsos")]
    public class RsoController
    {
        private ILogger<RsoController> logger;
        private ICampusCrawlUnitOfWork unitOfWork;

        public RsoController(ILogger<RsoController> logger, ICampusCrawlUnitOfWork unitOfWork)
        {
            this.logger = logger;
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public string GetRsos() => Guid.NewGuid().ToString();

        [HttpPost("create")]
        public async Task<Response<RSO>> CreateRso([FromBody] RsoModel rso)
        {
            this.logger.LogInformation("trying to create an RSO");
            var response = new Response<RSO>() {
                hasError = false,
                error = ""
            };

            var entity = new RSO() {
                Name = rso.Name,
                Description = rso.Description,
                Status = rso.Status,
                Id = rso.Id,
                University = await this.unitOfWork.Universities.GetUniversityById(rso.UniversityId),
                UniversityId = rso.UniversityId
            };

            var data = this.unitOfWork.RSOs.CreateRSO(entity);
            this.logger.LogInformation("IM HERE NOWWWWW");
            await this.unitOfWork.SaveAllAsync();

            if (response.data == null) {
                response.hasError = true;
                response.error = "invalid rso";
            }

            return response;
        }

        [HttpPost("join/{rsoId}")]
        public async Task<Response<bool>> JoinRso([FromBody] string userId, [FromRoute] string rsoId)
        {
            var response = new Response<bool>() {
                hasError = false,
                error = ""
            };

            response.data = true;
            return response;
        }

    }
}
