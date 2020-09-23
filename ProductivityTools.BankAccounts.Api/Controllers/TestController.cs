using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace ProductivityTools.BankAccounts.Api.Controllers
{
    [ApiController]
    [Route("Test")]
    public class TestController : Controller
    {
        [HttpPost("Hi")]
        public string Index(object str)
        {
            JObject json = JObject.Parse(str.ToString());
            string r = $"Hello {json["name"]}";
            return r;
        }
    }
}