using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MVC_empty
{
    public class GlobalVari
    {
        public static HttpClient WebApiClient = new HttpClient();

        static GlobalVari()
        {
       
            WebApiClient.BaseAddress = new Uri("http://localhost:54931/api/");
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}