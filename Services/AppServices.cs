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
                Console.WriteLine($"Transfer successful to {recipientName}!");
                Console.WriteLine($"New balance: {_bankAccount.GetCurrentBalance():0.00}");
            }
            else
            {
                Console.WriteLine("Insufficient balance for the transfer.");
            }
        }

        public void ShowCardDetails()
        {
            Console.WriteLine($"Card Number: {_customer.Card.Number.Substring(12)}");
            Console.WriteLine($"Expiration Date: {_customer.Card.ExpirationDate:MM/yyyy}");
            Console.WriteLine($"Brand: {_customer.Card.Brand}");
            Console.WriteLine($"Limit: R$ {_customer.Card.Limit:N2}");
        }
    }
}
