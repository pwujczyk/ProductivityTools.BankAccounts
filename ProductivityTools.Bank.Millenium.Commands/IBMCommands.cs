using ProductivityTools.Bank.Millenium.Objects;
using System.Collections.Generic;

namespace ProductivityTools.Bank.Millenium.Commands
{
    public interface IBMCommands
    {
        void SaveBasicData(BasicData basicData);
        void SaveTransactions(List<Transaction> transactions);
    }
}