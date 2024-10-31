using Microsoft.AspNetCore.Mvc;

namespace GetApp2._0.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            // Return a simple string message
            return "Hello from the Microservice!";
        }
    }
}