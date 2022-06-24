using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL.connectWithPythonServer;
using DAL.DBfiles;

namespace API.Controllers
{
    //[RoutePrefix("api/Search")]
    public class SearchController : ApiController
    {

        [HttpGet]
        [Route("api/Search/GetUserId")]
        public static List<Contact> GetUserId(string id)
        {
            return BL.UserManager.RturnForm(id);
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
