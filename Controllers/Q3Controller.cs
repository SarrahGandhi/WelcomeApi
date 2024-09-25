using Microsoft.AspNetCore.Mvc;

namespace WelcomeApi.Controllers
{
    [Route("api/q3")]
    [ApiController]
    public class Q3Controller : ControllerBase
    {
        /// <summary>
        /// Returns a cube value.
        /// </summary>
        /// <returns>A string containing the cube value message.</returns>
        /// <example>GET: http://localhost:5249/api/q2/greeting?name=Gary</example>
        [HttpGet("cube/{cube1}")]
        public IActionResult cube(int cube1)
        {
            // Return the cube result as a response.
            return Ok(cube1*cube1*cube1);
        }
    }
}
