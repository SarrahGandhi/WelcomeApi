using Microsoft.AspNetCore.Mvc;

namespace WelcomeApi.Controllers
{
    [Route("api/q4")]
    [ApiController]
    public class Q4Controller : ControllerBase
    {
        /// <summary>
        /// Returns a knock knock joke.
        /// </summary>
        /// <returns>A string containing the knock knock joke.</returns>
        /// <example>GET: http://localhost:5249/api/q2/greeting?name=Gary</example>
        [HttpPost("knockknock")]
        public IActionResult Postknockknock()
        {
            // Return the cube result as a response.
            return Ok("Who’s there?");
        }
    }
}
