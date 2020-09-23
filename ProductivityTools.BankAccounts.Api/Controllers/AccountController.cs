using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductivityTools.Bank.Millenium.Objects;

namespace ProductivityTools.BankAccounts.Api.Controllers
{
    [ApiController]
    [Route("Account")]
    public class AccountController : Controller
    {
        [HttpPost("BasicData")]
        public IActionResult BasicData(BasicData basicData)
        {
            return View();
        }
    }
}