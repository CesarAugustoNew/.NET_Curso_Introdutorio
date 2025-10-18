using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using ProductClientHub.Communication.Requests;
using ProductClientHub.Communication.Responses;

namespace PorductClientHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {

        [HttpPost]
        [ProducesResponseType(typeof(ResponseClientJson), StatusCodes.Status201Created)]
        public IActionResult Register([FromBody] RequestClientJson request)
        {
            return Ok();
        } 

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute] Guid id)
        {
            return Ok();
        }

        [HttpGet] 
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteById(Guid id)
        {
            return Ok();
        }

    }
}
