using Microsoft.AspNetCore.Mvc;
using DataAccess.Intefaces;
using DataAccess.Entities;
using DataAccess.Models;

namespace campus_crawl_web_api.Controllers {

    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private ILogger<UserController> logger;
        private ICampusCrawlUnitOfWork unitOfWork;

        public UserController(ILogger<UserController> logger, ICampusCrawlUnitOfWork unitOfWork) {
            this.logger = logger;
            this.unitOfWork = unitOfWork;
        }

        [HttpPost("login")]
        public async Task<Response<User>> Login([FromBody] UserCredentials userCredentials)
        {
            this.logger.LogInformation("trying to log someone in");
            var response = new Response<User>() {
                hasError = false,
                error = ""
            };

            this.logger.LogInformation("trying to log someone in");
            response.data = await this.unitOfWork.Users.GetUserFromCredentials(userCredentials);

            if (response.data == null) {
                response.hasError = true;
                response.error = "not a user";
            }

            return response;
        }

        [HttpPost("register")]
        public async Task<Response<User>> Register([FromBody] UserModel user)
        {

            var response = new Response<User>() {
                hasError = false,
                error = ""
            };

            this.logger.LogInformation("trying to log someone in");

            var entity = new User() {
                Id = user.Id,
                UniversityId = user.UniversityId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Password = user.Password,
                University = await this.unitOfWork.Universities.GetUniversityById(user.UniversityId)
            };

            response.data =  await this.unitOfWork.Users.CreateUser(entity);

            await this.unitOfWork.SaveAllAsync();
            return response;
        }
    }
}
