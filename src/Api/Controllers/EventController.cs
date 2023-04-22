using Microsoft.AspNetCore.Mvc;
using DataAccess.Intefaces;
using DataAccess.Entities;
using DataAccess.Models;

namespace campus_crawl_web_api.Controllers
{
    [ApiController]
    [Route("events")]
    public class EventController : ControllerBase
    {
        private ILogger<EventController> logger;
        private ICampusCrawlUnitOfWork unitOfWork;

        public EventController(ILogger<EventController> logger, ICampusCrawlUnitOfWork unitOfWork)
        {
            this.logger = logger;
            this.unitOfWork = unitOfWork;
        }

        [HttpGet("public/{userId}")]
        public async Task<Response<IEnumerable<Event>>> GetPublicEvents()
        {
            var response = new Response<IEnumerable<Event>>()
            {
                hasError = false,
                error = ""
            };

            response.data = await this.unitOfWork.PublicEvents.GetEvents();

            if (response.data == null)
            {
                response.hasError = true;
                response.error = "couldnt get public events";
            }

            return response;
        }

        [HttpGet("private/{universityId}")]
        public async Task<Response<IEnumerable<Event>>> GetPrivateEvents([FromRoute] string universityId)
        {
            var response = new Response<IEnumerable<Event>>()
            {
                hasError = false,
                error = ""
            };

            response.data = await this.unitOfWork.PrivateEvents.GetEventsByUniversityId(universityId);

            if (response.data == null)
            {
                response.hasError = true;
                response.error = "couldnt get private events";
            }

            return response;
        }

        [HttpGet("rso/{userId}")]
        public async Task<Response<ICollection<Event>>> GetRsoEvents([FromRoute] string userId)
        {
            var response = new Response<ICollection<Event>>()
            {
                hasError = false,
                error = ""
            };

            var members = await this.unitOfWork.Members.GetAllByUserId(userId);
            response.data = new List<Event>();

            foreach (var member in members) {
                response.data.Concat(await this.unitOfWork.RsoEvents.GetEventsByRsoId(member.RsoId));
            }

            if (response.data == null)
            {
                response.hasError = true;
                response.error = "couldnt get rso events";
            }

            return response;
        }

        [HttpGet("{eventId}/comments/list")]
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
