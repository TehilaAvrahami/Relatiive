﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
