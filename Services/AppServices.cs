using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingApp.Models;

namespace BankingApp.Services
{
    internal class AppServices
    {
        Customer customer = new Customer();
        BankInfos bankInfos = new BankInfos();

        public void ViewCurrentAccountBalance()
        {
            Console.WriteLine($"Current account balance: {bankInfos.ShowBalance()}");
        }
        public void BankTransferArea()
        {
            Console.Write("Enter the recipient's name: ");
            string recipientName = Console.ReadLine();
            Console.WriteLine($"\nWhat is the transaction value for {recipientName}?\n");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount))
            {
                bool success = bankInfos.Transfer(amount);
                if (success)
                {
                    Console.WriteLine("Transfer successful!");
                    Console.WriteLine($"New balance: ${bankInfos.ShowBalance()}");
                }
                else
                {
                    Console.WriteLine("Insufficient balance for the transfer.");
                }
            }
        }
    }
}