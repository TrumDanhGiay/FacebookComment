using FacebookComment.Facebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace FacebookComment.Controllers
{
    public class ValuesController : ApiController
    {
        public void Get()
        {
            var accessToken = "EAAFD6vZBCbeMBAP4XYeAwIFRa0lWPkGqIwyjmOnQ9rPAd62qsyQQCG2hxiJnOEjcDHby6wCSSkptptF8A0CLOp8619zWP5axmICSXPCaTnvQWTMfuF16YioSS7FHtbOWcV9adiqY0x8yWiIT16tQN8qM65iKAhAdrFaYkPmAQpEXo20ZBTdrRFhPQdZBRxiYFrgrCOU9gZDZD";
            var facebookClient = new FacebookClient();
            var facebookService = new FacebookService(facebookClient);
            var getAccountTask = facebookService.GetAccountAsync(accessToken);

            Task.WaitAll(getAccountTask);
            Console.WriteLine(""{account.Id} {account.Name}");

            var postOnWallTask = facebookService.PostOnWallAsync(accessToken, "Hello from C# .NET Framework MVC!");
            Task.WaitAll(postOnWallTask);
        }


        public string Get(int id)
        {
            return "value";
        }


        public void Post([FromBody] string value)
        {
        }


        public void Put(int id, [FromBody] string value)
        {
        }


        public void Delete(int id)
        {
        }
    }
}
