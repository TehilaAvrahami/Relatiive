using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BL.connectWithPythonServer
{
    public class CalcAlgoritm
    {
        public static string start(string path) {
            var url = "http://webcode.me";

            var request = WebRequest.Create(url);
            request.Method = "GET";

             var webResponse = request.GetResponse();
             var webStream = webResponse.GetResponseStream();

            var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();

            Console.WriteLine(data);
            return "213289754";
        }
    }
}
