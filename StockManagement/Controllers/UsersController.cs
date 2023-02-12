using MediatR;
using Microsoft.AspNetCore.Mvc;
using StockManagement.Applications.Queries.GetUserDetails;
using StockManagement.Models;
using System.Diagnostics.Eventing.Reader;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsersController(IMediator _mediator)
        {
            this._mediator = _mediator ?? throw new ArgumentNullException();
        }

        //[HttpGet]
        //public async Task<ActionResult<List<Users>>> GetUserDetails([FromQuery] GetUserDetailsQuery query)
        //{
        //    var users = await _mediator.Send(query);

        //    return Ok(users);
        //}
        [Route("{isActive:bool}")]
        [HttpGet]
        [ProducesResponseType(typeof(List<Users>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetUserDetails(bool isActive)
        {
            var response = await _mediator.Send(new GetUserDetailsQuery() { IsActive = isActive });
            return Ok(response);
        }
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<Users> Get()
        {
            return new List<Users>() { new Users() { Id = Guid.NewGuid(), FirstName = "Parthi", LastName = "Karanan",Email="parthi.k@gmail.com" },
                                       new Users() { Id = Guid.NewGuid(), FirstName = "Aadhvik", LastName = "Parthi",Email="aadhvik.parthi@gmail.com" }};
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
