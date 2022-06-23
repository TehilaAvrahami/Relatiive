using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BL.connectWithPythonServer
{
    public class AiClient
    {
        static readonly AiClient client = new AiClient();

        public static async Task startAsync(string path)
        {
           // var data = new FormUrlEncodedContent(values);
            var url = "https://dlearning.co.il/detect";
            HttpClient client = new HttpClient();
            var stringContent = new StringContent(path);
            var response = await client.PostAsync(url, stringContent);

            var result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);

           
        }
    }
}