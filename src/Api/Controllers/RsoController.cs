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
        public string ListRsos() => Guid.NewGuid().ToString();

        [HttpPost("create")]
        public async Task<Response<RSO>> CreateRso([FromBody] RSO rso)
        {
            this.logger.LogInformation("trying to create an RSO");
            var response = new Response<RSO>() {
                hasError = false,
                error = ""
            };

            var data = this.unitOfWork.RSOs.CreateRSO(rso);

            if (response.data == null) {
                response.hasError = true;
                response.error = "invalid rso";
            }

            return response;
        }

        [HttpPost("join")]
        public string JoinRso() => Guid.NewGuid().ToString();

    }
}
