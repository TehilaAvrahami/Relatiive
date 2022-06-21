using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL.connectWithPythonServer;

namespace API.Controllers
{
    [RoutePrefix("api/Search/")]
    public class SearchController : ApiController
    {
        [HttpPost]
        [Route("GetUser/{path}")]
        // GET: api/Search
        public string GetUserId(string path)
        {
            return CalcAlgoritm.start(path);
        }


        // POST: api/Search
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Search/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Search/5
        public void Delete(int id)
        {
        }
    }
}
