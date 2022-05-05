using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using BL;
using DAL;
using DAL.DBfiles;

namespace API.Controllers
{
    public class UserController : ApiController
    {
        //GET: api/User
        public List<User> Get()
        {
            return BL.UserManager.GetUsers();
        }

        // GET: api/User/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        [HttpPost]
        [Route("api/User/SignUp")]
        public User SignUp([FromBody]User user) //הרשמה
        {
            return UserManager.SignUp(user);
        }

        [HttpPost]
        [Route("api/User/SignIn")]
        public User SignIn([FromBody]User user)  //התחברות
        {
            return UserManager.SignIn(user);

        }

        [HttpPost]
        [Route("api/User/loadPictures")]
        public int LoadPictures()
        {
            HttpPostedFile file = HttpContext.Current.Request.Files[0];
            string path = HttpContext.Current.Server.MapPath("~/Content/Files/" + file.FileName);
            file.SaveAs(path);
            Console.WriteLine("path\n"+path);
            int electionId = int.Parse(HttpContext.Current.Request.Params["electionId"]);
            Console.ReadLine();
            return 7;
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
