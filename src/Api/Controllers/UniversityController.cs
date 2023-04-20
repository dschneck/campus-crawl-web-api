using Microsoft.AspNetCore.Mvc;
using DataAccess.Entities;
using DataAccess.Models;
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

        [HttpGet]
        public async Task<Response<IEnumerable<University>>> GetUniversities()
        {

            var response = new Response<IEnumerable<University>>()
            {
                hasError = false,
                error = ""
            };

            response.data = await this.unitOfWork.Universities.GetUniversitiesAsync();

            if (response.data == null)
            {
                response.hasError = true;
                response.error = "couldnt get universities";
            }

            return response;
        }

        [HttpPost]
        public async Task<string> CreateUniversityProfile([FromBody] University uni)
        {
            var ret = await this.unitOfWork.Universities.CreateUniversity(uni);
            await this.unitOfWork.SaveAllAsync();
            this.logger.LogInformation($"just created a new university with this id {ret}.");
            return ret;
        }

        [HttpPut]
        public string UpdateUniversityProfile() => Guid.NewGuid().ToString();
    }

}
