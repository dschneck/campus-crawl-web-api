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

        public RsoController(ILogger<RsoController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public string ListRsos() => Guid.NewGuid().ToString();

        [HttpPost("create")]
        public async Task<Response<RSO>> CreateRso([FromBody] RSO rso)
        {
            return new Response<RSO>();
        }

        [HttpPost("join")]
        public string JoinRso() => Guid.NewGuid().ToString();

    }
}
