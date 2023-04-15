using Microsoft.AspNetCore.Mvc;

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

        [HttpGet("create")]
        public string CreateRso() => Guid.NewGuid().ToString();

        [HttpPost("join")]
        public string JoinRso() => Guid.NewGuid().ToString();

    }
}
