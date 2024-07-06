using Microsoft.AspNetCore.Mvc;

namespace Pet.Commerce.Project.DevTools
{
    [ApiController]
    public class DevToolsController : Controller
    {
        public DevToolsController()
        {
        }

        [HttpGet("test-check")]
        public async Task<ActionResult> TestCheck(CancellationToken cancellationToken)
        {
            return Ok();
        }
    }
}
