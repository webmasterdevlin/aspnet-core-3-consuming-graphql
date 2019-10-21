using System.Threading.Tasks;
using CoreClient.GraphQLClient;
using Microsoft.AspNetCore.Mvc;

namespace CoreClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        private readonly OwnerConsumer _consumer;
 
        public TestsController(OwnerConsumer consumer)
        {
            _consumer = consumer;
        }
 
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var owners = await _consumer.GetAllOwners();
            return Ok(owners);
        }
    }
}