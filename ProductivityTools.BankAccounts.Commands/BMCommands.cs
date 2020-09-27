using Microsoft.EntityFrameworkCore;
using ProductivityTools.BankAccounts.Database;
using ProductivityTools.BankAccounts.Contract;
using ProductivityTools.DateTimeTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ProductivityTools.BankAccounts.Commands
{
    public class BMCommands : IBMCommands
    {
        MilleniumContext Context;
        IDateTimePT currentdate;

        public BMCommands(MilleniumContext context, IDateTimePT date)
        {
            this.Context = context;
            this.currentdate = date;
        }

        public void SaveBasicData(BasicData basicData)
        {
            basicData.Date = currentdate.Now;
            var currentRecord = this.Context.BasicData.AsNoTracking().FirstOrDefault(x =>
            x.Date.Date == this.currentdate.Now.Date
            && x.Bank==basicData.Bank
            && x.Account==basicData.Account);
            if (currentRecord == null)
            {
                this.Context.BasicData.Add(basicData);
            }
            else
            {
                basicData.BasicDataId = currentRecord.BasicDataId;
                this.Context.Update(basicData);
            }
            this.Context.SaveChanges();
        }

        private void SaveTransaction(Transaction transaction)
        {
            var currentRecord = this.Context.Transaction.AsNoTracking().FirstOrDefault(x => x.AugmentTransactionId == transaction.AugmentTransactionId);
            if (currentRecord == null)
            {
                this.Context.Transaction.Add(transaction);
            }
            else
            {
                transaction.TransactionId = currentRecord.TransactionId;
                this.Context.Update(transaction);
            }
            this.Context.SaveChanges();
        }

        public void SaveTransactions(List<Transaction> transactions)
        {
            foreach (var transaction in transactions)
            {
                SaveTransaction(transaction);
            }
        }
    }
}
