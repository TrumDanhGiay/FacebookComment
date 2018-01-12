using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace FacebookComment.Controllers
{
    public class FacebookController : ApiController
    {
        public HttpResponseMessage Get()
        {
            var querystrings = Request.GetQueryNameValuePairs().ToDictionary(x => x.Key, x => x.Value);
            if (querystrings["hub.verify_token"] == "footer")
            {
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(querystrings["hub.challenge"], Encoding.UTF8, "text/plain")
                };
            }
            return new HttpResponseMessage(HttpStatusCode.Unauthorized);
        }


        public string Get(int id)
        {
            return "value";
        }


        public void Post([FromBody] dynamic value)
        {
            Console.WriteLine(value);
        }


        public void Put(int id, [FromBody] string value)
        {
        }


        public void Delete(int id)
        {
        }
    }
}
