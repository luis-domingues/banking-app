using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingApp.Models;

namespace BankingApp.Services
{
    internal class AppServices
    {
        private readonly BankAccount _bankAccount;

        public AppServices(BankAccount bankAccount)
        {
            this._bankAccount = bankAccount;
        }
        
        public void ShowCurrentBalance()
        {
            Console.WriteLine($"Current account balance: {bankAccount.GetCurrentBalance():0.00}");
        }
        
        public void TransferFunds(string recipientName, decimal amount)
        {
            if(decimal.TryParse(Console.ReadLine(), out decimal transferAmount))
            {
                bool success = bankAccount.Withdraw(transferAmount);
                if (success)
                {
                    Console.WriteLine($"Transfer successful to {recipientName}!");
                    Console.WriteLine($"New balance: ${bankAccount.GetCurrentBalance():0.00}");
                }
                else
                {
                    Console.WriteLine("Insufficient balance for the transfer.");
                }
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a numeric value.");
            }
        }
        public void ShowCardDetails()
        {
            Console.WriteLine($"Número do cartão: {customer.Card.Number.Substring(12)}");
            Console.WriteLine($"Validade: {customer.Card.ExpirationDate:MM/yyyy}");
            Console.WriteLine($"Bandeira: {customer.Card.Brand}");
            Console.WriteLine($"Limite disponível: R$ {customer.Card.Limit:N2}");
        }
        
    }
}