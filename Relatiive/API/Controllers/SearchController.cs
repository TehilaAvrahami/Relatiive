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
        [HttpPost]
        [Route("api/Search")]
        // GET: api/Search
        //public static string GetPath()
        //{
        //    string path = ContactController.uploadFile();
        //   return CalcAlgoritm.start(path);
        //}

        //[HttpPost]
        //[Route("api/Search/GetUserId")]
        //public static List<Contact> GetUserId()
        //{
        //   return BL.UserManager.RturnForm(GetPath());
        //}

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
