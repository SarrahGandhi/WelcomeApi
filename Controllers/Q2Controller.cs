using Microsoft.AspNetCore.Mvc;

namespace WelcomeApi.Controllers
{
    [Route("api/q2")]
    [ApiController]
    public class Q2Controller : ControllerBase
    {
        /// <summary>
        /// Returns a greeting message.
        /// </summary>
        /// <returns>A string containing the greeting message.</returns>
        /// <example>GET: http://localhost:5249/api/q2/greeting?name=Gary</example>
        [HttpGet("greeting")]
        public IActionResult Greeting(string name)
        {
            // Return the welcome message as a response.
            return Ok("Hi " + name);
        }
    }
}
