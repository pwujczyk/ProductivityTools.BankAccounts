using ProductivityTools.BankAccounts.Objects;
using System.Collections.Generic;

namespace ProductivityTools.BankAccounts.Commands
{
    public interface IBMCommands
    {
        void SaveBasicData(BasicData basicData);
        void SaveTransactions(List<Transaction> transactions);
    }
}