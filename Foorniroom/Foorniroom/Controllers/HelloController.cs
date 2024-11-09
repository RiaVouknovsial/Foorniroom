using Foorniroom.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Foorniroom.Controllers
{
    public class HelloController : ControllerBase
    {
        private readonly INewService _newService;

        public HelloController(INewService newService)
        {
            _newService = newService;
        }

        [HttpGet]
        public IActionResult GetMessage()
        {
            var message = _newService.GetMessage();
            return Ok(message);
        }
    }
}
