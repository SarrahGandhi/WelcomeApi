using Microsoft.AspNetCore.Mvc;

namespace WelcomeApi.Controllers
{
    [Route("api/q1")]
    [ApiController]
    public class Q1Controller : ControllerBase
    {
        /// <summary>
        /// Returns a welcome message.
        /// </summary>
        /// <returns>A string containing the welcome message.</returns>
        /// <example>GET: http://localhost:5000/api/q1/welcome</example>
        [HttpGet("welcome")]
        public IActionResult Welcome()
        {
            // Return the welcome message as a response.
            return Ok("Welcome to 5125!");
        }
    }
}
