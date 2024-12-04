using Microsoft.AspNetCore.Mvc;

namespace TestApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {
        [HttpPost("concatenate")]
        public IActionResult ConcatenateStrings(string firstString, string secondString)
        {
            if (string.IsNullOrEmpty(firstString) || string.IsNullOrEmpty(secondString))
            {
                return BadRequest("Both strings must be non-empty");
            }

            string result = firstString + secondString;
            return Ok(result);  
        }
    }
}
