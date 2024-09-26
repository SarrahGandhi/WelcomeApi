using Microsoft.AspNetCore.Mvc;
using System;

namespace WelcomeApi.Controllers
{
    [Route("api/q7")]
    [ApiController]
    public class q7Controller : ControllerBase
    {
        /// <summary>
        /// Returns a greeting message.
        /// </summary>
        /// <returns>A string containing the greeting message.</returns>
        /// <example>GET: http://localhost:5249/api/q2/greeting?name=Gary</example>
        [HttpGet("timemachine")]
        public string timemachine(int days)
        {
            // Return the welcome message as a response.
            DateTime thisDay = DateTime.Today;
            DateTime result = thisDay.AddDays(days);




            return result.ToString("yyyy-MM-dd");
        }
}
}
