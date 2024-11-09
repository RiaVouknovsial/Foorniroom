using Foorniroom.Interfaces;
using Foorniroom.Services;
using Microsoft.AspNetCore.Mvc;

namespace Foorniroom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IValueRepository _valueService;

        public ValuesController(IValueRepository valueService)
        {
            _valueService = valueService;
        }

        [HttpGet("value")]
        public IActionResult GetValue()
        {
            var value = _valueService.GetValue();
            return Ok(value);
        }
    }
}
