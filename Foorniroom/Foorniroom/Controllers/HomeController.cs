using Microsoft.AspNetCore.Mvc;

namespace Foorniroom
{
    public class HomeController : Controller
    {
        [HttpGet("hello")] // Маршрут для вызова метода по URL /hello
        public IActionResult Hello()
        {
            return Content("Hello word!");
        }
    }
}
