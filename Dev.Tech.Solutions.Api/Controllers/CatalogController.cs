using Microsoft.AspNetCore.Mvc;
using Dev.Tech.Solutions.Domain.Catalog;

namespace Dev.Tech.Solutions.Api.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase {
        [HttpGet]
        public IActionResult GetItems() {
            
            var items = new List<Item>() {

                new Item ("Shirts", "Ohio State shirt.", "Nike", 29.99m),
                new Item ("Shirts", "Ohio State shirt.", "Nike", 44.99m)
            };

            return Ok(items);
        }

        [HttpGet ("{id:int}")]
        public IActionResult GetItems(int id) {
    
            var item = new Item ("Shirts", "Ohio State shirt.", "Nike", 29.99m);
            item.Id = id;            

            return Ok(item);
        }

        [HttpPost]
        public IActionResult Post(Item item) {        

            return Created("/catalog/42", item);
        }

        




    }
}