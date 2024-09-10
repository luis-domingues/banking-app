using BankingApp.Models;
using BankingApp.Models;

namespace BankingApp.Services
{
        internal class AppServices
    {
        private readonly BankAccount _bankAccount;
        private readonly Customer _customer;

        public AppServices(BankAccount bankAccount, Customer customer)
        {
            this._bankAccount = bankAccount;
            this._customer = customer;
        }

        public void ShowCurrentBalance()
        {
            Console.WriteLine($"Current account balance: {_bankAccount.GetCurrentBalance():0.00}");
        }

        public void TransferFunds(string recipientName, decimal amount)
        {
            bool success = _bankAccount.Pay(amount);
            if (success)
            {
                Console.WriteLine($"\n\u001b[32mTransfer successful to {recipientName}!\u001b[0m");
                Console.WriteLine($"\u001b[33mNew balance: {_bankAccount.GetCurrentBalance():0.00}\u001b[0m");
            }
            else
            {
                Console.WriteLine("\n\u001b[31mInsufficient balance for the transfer.\u001b[0m");
            }
        }

        public void ShowCardDetails()
        {
            
            Console.WriteLine($"\u001b[34mCard Number:\u001b[0m {_customer.Card.Number.Substring(12)}");
            Console.WriteLine($"\u001b[34mExpiration Date:\u001b[0m {_customer.Card.ExpirationDate:MM/yyyy}");
            Console.WriteLine($"\u001b[34mBrand:\u001b[0m {_customer.Card.Brand}");
            Console.WriteLine($"\u001b[34mLimit:\u001b[0m R$ {_customer.Card.Limit:N2}");
        }
    }
}
