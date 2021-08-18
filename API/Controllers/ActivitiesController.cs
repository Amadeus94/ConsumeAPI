using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ActivitiesController : ControllerBase
    {
        private readonly IActivityRepository _activityRepository;
        public ActivitiesController(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ActivityEntity>>> getActivities()
        {
            return Ok(await _activityRepository.GetActivitiesAsync());
        }

        // Route Parameter
        // api/users/3
        [HttpGet("{id}")]
        public async Task<ActionResult<ActivityEntity>> getActivityAsync(int id)
        {
            return Ok(await _activityRepository.GetActivityAsync(id));
        }
    }

}