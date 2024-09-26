using Microsoft.AspNetCore.Mvc;

namespace WelcomeApi.Controllers
{
    [Route("api/q6")]
    [ApiController]
    public class q6Controller : ControllerBase
    {
        [HttpGet("hexagon")]
        public double hexagon(double side)
        {
            var result=(3*Math.Sqrt(3)/2)*Math.Pow(side,2);
            return result;
        }
    }
}
