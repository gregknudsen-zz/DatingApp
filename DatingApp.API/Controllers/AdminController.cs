using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {   
        [Authorize(Policy = "RequireAdminRole")]
        [HttpGet("usersWithRoles")]
        public IActionResult GetUsersWithRoles()
        {
            return Ok("Only admins see this");
        }
        [Authorize(Policy = "ModeratePhotoRole")]
        [HttpGet("photosForModerators")]
        public IActionResult GetPhotosForModerators()
        {
            return Ok("Admins or moderators can see this");
        }
    }
}