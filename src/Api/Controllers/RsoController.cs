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

        [HttpGet("{userId}")]
        public async Task<Response<ICollection<RSO>>> GetRsosForUserId([FromRoute] string userId)
        {
            var response = new Response<ICollection<RSO>>()
            {
                hasError = false,
                error = ""
            };

            var memberEntries = await this.unitOfWork.Members.GetAllByUserId(userId);
            this.logger.LogWarning($"got the following number of members {memberEntries.Count()}");
            response.data = new List<RSO>();

            foreach (var member in memberEntries) {
                var tmp = await this.unitOfWork.RSOs.GetRsoById(member.RsoId);
                this.logger.LogWarning($"rsoId got : {tmp?.Name}");
                response.data.Add(tmp);
                this.logger.LogWarning($"now data has this many items: {response.data.Count()}");
            }

            if (response.data == null)
            {
                response.hasError = true;
                response.error = "couldnt get rsos";
            }

            return response;
        }

        [HttpPost]
        public async Task<Response<IEnumerable<RSO>>> GetRsos([FromBody] string universityId)
        {
            var response = new Response<IEnumerable<RSO>>()
            {
                hasError = false,
                error = ""
            };

            response.data = await this.unitOfWork.RSOs.GetRsosFromUniversityId(universityId);

            if (response.data == null)
            {
                response.hasError = true;
                response.error = "couldnt get rsos";
            }

            return response;
        }

        [HttpPost("create")]
        public async Task<Response<RSO>> CreateRso([FromBody] RsoModel rso)
        {
            this.logger.LogInformation("trying to create an RSO");
            var response = new Response<RSO>() {
                hasError = false,
                error = ""
            };

            var entity = new RSO() {
                Name = rso.Name,
                Description = rso.Description,
                Status = rso.Status,
                Id = rso.Id,
                University = await this.unitOfWork.Universities.GetUniversityById(rso.UniversityId),
                UniversityId = rso.UniversityId
            };

            response.data = await this.unitOfWork.RSOs.CreateRSO(entity);
            await this.unitOfWork.SaveAllAsync();

            if (response.data == null) {
                response.hasError = true;
                response.error = "invalid rso";
            }

            return response;
        }

        [HttpPost("join/{rsoId}")]
        public async Task<Response<bool>> JoinRso([FromBody] string userId, [FromRoute] string rsoId)
        {
            var response = new Response<bool>() {
                hasError = false,
                error = ""
            };

            var entity = new Member() {
                Id = Guid.NewGuid().ToString(),
                UserId = userId,
                RsoId = rsoId,
                User = await this.unitOfWork.Users.GetUserById(userId),
                RSO = await this.unitOfWork.RSOs.GetRsoById(rsoId)
            };
            this.logger.LogCritical(entity.User.Id);
            this.logger.LogCritical(entity.RSO.Id);

            response.data = await this.unitOfWork.Members.JoinRso(entity);
            await this.unitOfWork.SaveAllAsync();

            if (response.data == false) {
                response.hasError = true;
                response.error = "issue";
            }

            return response;
        }

        [HttpPost("leave/{rsoId}")]
        public async Task<Response<bool>> LeaveRso([FromBody] string userId, [FromRoute] string rsoId)
        {
            var response = new Response<bool>() {
                hasError = false,
                error = ""
            };

            response.data = await this.unitOfWork.Members.LeaveRso(userId, rsoId);
            await this.unitOfWork.SaveAllAsync();

            if (response.data == false) {
                response.hasError = true;
                response.error = "issue";
            }

            return response;
        }

    }
}
