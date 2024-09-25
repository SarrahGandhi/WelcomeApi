using Microsoft.AspNetCore.Mvc;

namespace WelcomeApi.Controllers
{
    [Route("api/q6")]
    [ApiController]
    public class Q6Controller : ControllerBase
    {
        /// <summary>
        /// Returns a greeting message.
        /// </summary>
        /// <returns>A string containing the greeting message.</returns>
        /// <example>GET: http://localhost:5249/api/q2/greeting?name=Gary</example>
        [HttpGet("hexagon")]
        public IActionResult Greeting(int side)
        {
            // Return the welcome message as a response.
            var result=(3*Math.Sqrt(3)/2)*Math.Pow(side,2);
            return Ok(result);
        }
    }
}
