using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using ProductivityTools.BankAccounts.Commands;
using ProductivityTools.BankAccounts.Contract;

namespace ProductivityTools.BankAccounts.Api.Controllers
{
    [ApiController]
    [Route(EndpointNames.AccountControllerName)]
    public class AccountController : Controller
    {
        private readonly IBMCommands Commands;

        public AccountController(IBMCommands commands)
        {
            this.Commands = commands;
        }

        [HttpPost(EndpointNames.BasicDataMethodName)]
        public IActionResult BasicData(BasicData basicData)
        {
            this.Commands.SaveBasicData(basicData);
            return Ok();
        }


        [HttpPost(EndpointNames.SaveTransactionsMethodName)]
        public IActionResult SaveTransactions(List<Transaction> transactions)
        {
            this.Commands.SaveTransactions(transactions);
            return Ok();
        }
    }
}