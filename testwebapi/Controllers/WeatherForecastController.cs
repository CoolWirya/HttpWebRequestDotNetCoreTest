using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text;

namespace testwebapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class WeatherForecastController : ControllerBase
    {
        string SessionID = "";

        [HttpPost("HlrLocation")]
        public IActionResult GetLocation(string msisdn)
        {
            api api = new api();
            api.HLRLogin("");
            api.HLRLocation(msisdn, "");
            string output = api.HLRLogout("");

            return Ok(output);
        }



    }
}