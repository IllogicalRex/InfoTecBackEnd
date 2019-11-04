using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoTecBackEnd.Models;
using Microsoft.AspNetCore.Mvc;

namespace InfoTecBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectBankController : ControllerBase
    {
        BankProjectModel bank = null;
        public ProjectBankController() {
            bank = new BankProjectModel() {Id = 1, Nombre = "joel",  Direccion = "lo que sea"};
        }
        // GET api/values
        [HttpGet]
        public ActionResult<BankProjectModel> Get()
        {
            if (bank == null) {
                return NotFound();
            }
            return bank;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
