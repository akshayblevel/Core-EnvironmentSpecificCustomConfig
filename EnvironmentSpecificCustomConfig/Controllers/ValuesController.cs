using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EnvironmentSpecificCustomConfig.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private Configuration configuration { get; set; }
        public ValuesController(Configuration configuration)
        {
            this.configuration = configuration;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "ConnectionString", configuration.ConnectionString };
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
