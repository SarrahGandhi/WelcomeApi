using Microsoft.AspNetCore.Mvc;

namespace WelcomeApi.Controllers
{
    [Route("api/q5")]
    [ApiController]
    public class q5Controller : ControllerBase
    {
        /// <summary>
        /// Returns a knock knock joke.
        /// </summary>
        /// <returns>A string containing the knock knock joke.</returns>
        /// <example>GET: http://localhost:5249/api/q2/greeting?name=Gary</example>
        [HttpPost("secret")]
        public string Secret([FromBody]int secret)
        {
            // Return the cube result as a response.
            return "Shh.. the secret is " +secret;
        }
    }
}
