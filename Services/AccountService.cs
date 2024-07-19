using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingApp.Models;

namespace BankingApp.Services
{
    public class AccountService : IAccountService
    {
        private readonly List<Account> _accounts;
        private int _nextId;

        public AccountService()
        {
            _accounts = new List<Account>();
            _nextId = 1;
        }

        public void CreateAccount(string customerName, decimal initialBalance)
        {
            var account = new Account(_nextId++, customerName, initialBalance);
            _accounts.Add(account);
            Console.WriteLine($"Conta criada com sucesso! ID da Conta: {account.Id}");
        }

        public decimal GetBalance(int accountId)
        {
            var account = _accounts.FirstOrDefault(a => a.Id == accountId);
            if (account != null)
            {
                return account.Balance;
            }
            else
            {
                Console.WriteLine("Conta não encontrada!");
                return 0;
            }
        }

        public void Transfer(int fromAccountId, int toAccountId, decimal amount)
        {
            var fromAccount = _accounts.FirstOrDefault(a => a.Id == fromAccountId);
            var toAccount = _accounts.FirstOrDefault(a => a.Id == toAccountId);

            if (fromAccount == null || toAccount == null)
            {
                Console.WriteLine("Uma ou ambas as contas não foram encontradas!");
                return;
            }

            if (fromAccount.Balance < amount)
            {
                Console.WriteLine("Saldo insuficiente!");
                return;
            }

            fromAccount.Balance -= amount;
            toAccount.Balance += amount;
            Console.WriteLine("Transferência realizada com sucesso!");
        }

        public void DeleteAccount(int accountId)
        {
            var account = _accounts.FirstOrDefault(a => a.Id == accountId);
            if (account != null)
            {
                _accounts.Remove(account);
                Console.WriteLine("Conta deletada com sucesso!");
            }
            else
            {
                Console.WriteLine("Conta não encontrada!");
            }
        }
    }
}