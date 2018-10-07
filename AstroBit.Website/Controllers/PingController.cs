using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AstroBit.Website.Controllers
{
    public class PingController : ApiController
    {
        // GET: api/Ping
        public IEnumerable<string> Get()
        {
            return Enum
                .GetNames(typeof(Zodiac))
                .Select(x => (Zodiac)Enum.Parse(typeof(Zodiac), x))
                .Select(x => x.GetSign());
        }

        // GET: api/Ping/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Ping
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Ping/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Ping/5
        public void Delete(int id)
        {
        }
    }
}
