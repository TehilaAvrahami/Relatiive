using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BL.connectWithPythonServer
{
    public class HttpClient
    {
        public static async Task startAsync(string path)
        {
            //var data = new FormUrlEncodedContent(values);
            var url = "https://dlearning.co.il/detect";
             HttpClient client = new HttpClient();
            var response = await client.PostAsync(url, path);

            var result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
        }
    }
}
