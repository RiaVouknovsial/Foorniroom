using Foorniroom.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Foorniroom.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly INewService _newService;

        public HomeController(INewService newService)
        {
            _newService = newService;
        }

        [HttpGet("greeting")]
        public IActionResult GetGreeting()
        {
            var message = _newService.GetGreeting();
            return Ok(message);
        }
    }
}
