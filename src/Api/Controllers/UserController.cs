using Microsoft.AspNetCore.Mvc;

namespace campus_crawl_web_api.Controllers {

    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private ILogger<UserController> logger;

        public UserController(ILogger<UserController> logger) {
            this.logger = logger;
        }

        [HttpPost("login")]
        public string GetUser() => Guid.NewGuid().ToString();

        [HttpPost("register")]
        public string PostUser() => Guid.NewGuid().ToString();

    }
}
