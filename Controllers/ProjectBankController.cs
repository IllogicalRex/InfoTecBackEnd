using MediatR;
using System.Threading.Tasks;
using InfoTecBackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using InfoTecBackEnd.Models.RquestBankProject;
using System.Collections.Generic;

namespace InfoTecBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectBankController : ControllerBase
    {
        private readonly IMediator mediator;
       // BankProjectModel bank = null;
        public ProjectBankController(IMediator mediator) {
            this.mediator = mediator;
          //  bank = new BankProjectModel() {Id = 1, Nombre = "joel",  Direccion = "lo que sea"};
        }
        // GET api/values
        [HttpGet]
        public Task<List<BankProjectModel>> Get()
        {
           
            var query = new GetAllBankProjectRequest();
            var resultado = mediator.Send(query);
            return resultado;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<BankProjectModel>> CreateProject([FromBody] BankProjectRequest value)
        {
            var person = await mediator.Send(value);
            return person;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
