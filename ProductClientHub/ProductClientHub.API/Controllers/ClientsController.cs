using Microsoft.AspNetCore.Mvc;
using ProductClientHub.API.UseCases.Clients.Register;
using ProductClientHub.Comunication.Requests;
using ProductClientHub.Comunication.Responses;

namespace ProductClientHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        [HttpPost]
        ~[ProducesResponseType(typeof(ResponseClientJson), StatusCodes.Status201Created)]
        public IActionResult Register([FromBody] ResquestClientJson resquest)
        {
            var useCase = new RegisterClientUseCase();

            var response = useCase.Execute(resquest);

            return Created(string.Empty, response);
        }

        [HttpPut]
        public IActionResult Update()
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
        public IActionResult GetById([FromRoute] Guid id)
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }
    }
}