using Microsoft.AspNetCore.Mvc;
using DataAccess.Entities;
using DataAccess.Intefaces;

namespace campus_crawl_web_api.Controllers
{
    [ApiController]
    [Route("universities")]
    public class UniversityController
    {
        private ILogger<UniversityController> logger;
        private ICampusCrawlUnitOfWork unitOfWork;

        public UniversityController(ILogger<UniversityController> logger, ICampusCrawlUnitOfWork unitOfWork)
        {
            this.logger = logger;
            this.unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<string> CreateUniversityProfile([FromBody] University uni)
        {
            var ret = await this.unitOfWork.university.CreateUniversity(uni);
            await this.unitOfWork.SaveAllAsync();
            this.logger.LogInformation($"just created a new university with this id {ret}.");
            return ret;
        }

        [HttpPut]
        public string UpdateUniversityProfile() => Guid.NewGuid().ToString();
    }

}
