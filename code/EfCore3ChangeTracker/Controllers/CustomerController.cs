using Microsoft.AspNetCore.Mvc;

namespace EfCore3ChangeTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {

        public IActionResult Get()
        {
            return Ok();
        }

    }
}
