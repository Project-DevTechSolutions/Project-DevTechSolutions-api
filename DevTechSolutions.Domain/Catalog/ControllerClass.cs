using Microsoft.AspNetCore.Mvc;
using DevTechSolutions.Domain.Catalog;
using System.Threading.Tasks;

namespace DevTechSolutions.Api.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase {
        [HttpGet]
        public IActionResult GetItems() {
            return Ok("hello world.");
        }
    }
}

