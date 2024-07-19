using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApp.Services
{
    public interface IAccountService
    {
        void CreateAccount(string customerName, decimal initialBalance);
        decimal GetBalance(int accountId);
        void Transfer(int fromAccountId, int toAccountId, decimal amount);
        void DeleteAccount(int accountId);
    }
}