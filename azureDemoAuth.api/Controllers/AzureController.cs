using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace azureDemoAuth.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    //[RequiredScope(RequiredScopesConfigurationKey = "AzureAd:scopes")]
    public class AzureController : ControllerBase
    {


        [HttpGet("[action]")]
        public IActionResult GetData() {

            var currentUser = User;

            var data = new List<string>()
            {
                "a",
                "b",
                "c"
            };

            return  Ok(data);
        
        }


        [Authorize(Roles = "DSI")]
        [HttpGet("[action]")]
        public IActionResult GetDataDSI()
        {

            var currentUser = User;

            var data = new List<string>()
            {
                "a",
                "b",
                "c"
            };

            return Ok(data);

        }
    }
}
