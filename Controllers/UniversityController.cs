using Microsoft.AspNetCore.Mvc;

namespace campus_crawl_web_api.Controllers
{
    [ApiController]
    [Route("universities")]
    public class UniversityController
    {
        private ILogger<UniversityController> logger;

        public UniversityController(ILogger<UniversityController> logger)
        {
            this.logger = logger;
        }

        [HttpPost]
        public string CreateUniversityProfile() => Guid.NewGuid().ToString();

        [HttpPut]
        public string UpdateUniversityProfile() => Guid.NewGuid().ToString();
    }

}
