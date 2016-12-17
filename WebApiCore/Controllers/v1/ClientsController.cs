using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.SwaggerGen.Annotations;
using WebApiCore.Models;

namespace WebApiCore.Controllers
{
    [Route("api/v1/client")]
    public class ClientsController : Controller
    {
        List<ClientModel> list = new List<ClientModel>{

        } ;

        // GET api/values
        [HttpGet]
        public IEnumerable<ClientModel> Get()
        {
            return new List<ClientModel> { 
                new ClientModel("WE21", "WE"),
                new ClientModel("CE03", "CE"),
                new ClientModel("CE19", "CE"),
                new ClientModel("WE09", "WE"),
                new ClientModel("CE30", "CE"),
                new ClientModel("WE08", "WE"),
                new ClientModel("NO14", "Nordic"),
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}