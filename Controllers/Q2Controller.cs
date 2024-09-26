using Microsoft.AspNetCore.Mvc;

namespace WelcomeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2Controller : ControllerBase
    {
        [HttpGet(template: "greeting")]
        public string greeting(string name)
        {
            // Return the welcome message as a response.
            return $"Hi {name}!";
        }
    }
}
