using Foorniroom.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Foorniroom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly INewService _newService;

        public MessageController(INewService newService)
        {
            _newService = newService;
        }

        [HttpGet]
        public IActionResult GetMessage()
        {
            var message = _newService.GetGreeting();
            return Ok(message);
        }
    }
}
