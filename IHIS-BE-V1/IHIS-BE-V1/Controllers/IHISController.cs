using Microsoft.AspNetCore.Mvc;

namespace IHIS_BE_V1.Controllers
{
    [ApiController]
    [Route("IHIS")]
    public class IHISController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(DateTime.Now);
        }
    }
}
