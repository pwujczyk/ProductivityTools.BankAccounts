using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductivityTools.BankAccounts.Commands;
using ProductivityTools.BankAccounts.Contract;

namespace ProductivityTools.BankAccounts.Api.Controllers
{
    [ApiController]
    [Route("Account")]
    public class AccountController : Controller
    {
        private readonly IBMCommands Commands;

        public AccountController(IBMCommands commands)
        {
            this.Commands = commands;
        }

        [HttpPost("BasicData")]
        public IActionResult BasicData(BasicData basicData)
        {
            this.Commands.SaveBasicData(basicData);
            return Ok();
        }
    }
}