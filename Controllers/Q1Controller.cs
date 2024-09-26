using Microsoft.AspNetCore.Mvc;

namespace WelcomeApi.Controllers
{
    [Route("api/q1")]
    [ApiController]
    public class q1Controller : ControllerBase
    {
        [HttpGet("welcome")]
        public string Welcome()
        {
            // Return the welcome message as a response.
            return "Welcome to 5125!";
        }
    }
}
