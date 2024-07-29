using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using Asp.Versioning;

namespace webapitemplate.Controllers
{
    [ApiVersion(1)]
    [RoutePrefix("api/v{version:apiVersion}/values")]
    public class ValuesController : ApiController
    {
        // GET api/values
        [Route]
        [ApiVersion(1, Deprecated = true)]

        public IEnumerable<string> Get()
        {
            return new[] { "value1", $"Api Version - {Request.GetRequestedApiVersion()?.ToString()}" };
        }

        [Route]
        [ApiVersion(2)]
        public IEnumerable<string> Get_v2()
        {
            return new[] { "value2", $"Api Version - {Request.GetRequestedApiVersion()?.ToString()}" };
        }

        // GET api/values/5
        [Route("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [Route]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [Route("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [Route("{id}")]
        public void Delete(int id)
        {
        }
    }
}
