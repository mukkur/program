using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        public static List<string> Data = new List<string> { "Value1", "Value2" };
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return Data[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            Data.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            Data[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            Data.RemoveAt(id);
        }
    }
}