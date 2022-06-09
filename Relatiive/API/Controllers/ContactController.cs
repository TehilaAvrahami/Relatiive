using BL;
using DAL.DBfiles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.IO;

namespace API.Controllers
{
    public class ContactController : ApiController
    {
        [HttpPost]
        [Route("api/Contact/Contact")]
        public Contact ContactForm([FromBody]Contact contact) //יצירת טופס 
        {
            return UserManager.ContactForm(contact);
        }

        [RoutePrefix("api/file")]
        public class FileController : ApiController
        {
            [Route("upload")]
            [HttpPost]
            public string uploadFile()
            {
                HttpPostedFile file = HttpContext.Current.Request.Files[0];
                string path = HttpContext.Current.Server.MapPath("~/Content/Files/" + file.FileName);
                file.SaveAs(path);
                Image image = Image.FromFile(System.Web.HttpContext.Current.Server.MapPath("~/Content/Files/" + file.FileName));
                return "ok";


            }
        }
    }
}
