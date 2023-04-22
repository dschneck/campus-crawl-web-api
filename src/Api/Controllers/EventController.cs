using Microsoft.AspNetCore.Mvc;

namespace campus_crawl_web_api.Controllers
{
    [ApiController]
    [Route("events")]
    public class EventController : ControllerBase
    {
        private ILogger<EventController> logger;

        public EventController(ILogger<EventController> logger)
        {
            this.logger = logger;
        }

        [HttpPost("search")]
        public string SearchEvents() => Guid.NewGuid().ToString();

        [HttpGet("{userId}/comments/list")]
        public string ListEvents() => Guid.NewGuid().ToString();

        [HttpPost("{eventId}/comments/comment")]
        public string CreateComment() => Guid.NewGuid().ToString();

        [HttpPut("{eventId}/comments/comment")]
        public string EditComment() => Guid.NewGuid().ToString();

        [HttpDelete("{eventId}/comments/comment")]
        public string DeleteComment() => Guid.NewGuid().ToString();

        [HttpPost("{eventId}/ratings/rating")]
        public string CreateRating() => Guid.NewGuid().ToString();

        [HttpPut("{eventId}/ratings/{ratingId}")]
        public string EditRating() => Guid.NewGuid().ToString();
    }
}
