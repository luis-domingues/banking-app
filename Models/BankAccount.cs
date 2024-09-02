using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApp.Models
{
    internal class BankAccount
    {
        private decimal currentBalance { get; set; }

        public BankAccount(decimal initialBalance = 100M)
        {
            this.currentBalance = initialBalance;
        }
        
        public decimal GetCurrentBalance()
        {
            return currentBalance;
        }

        public bool Pay(decimal amount) 
        {
            if(amount <= 0)
            {
                throw new ArgumentException("The amount to be paid must be positive.");
            }
            
            if (amount <= currentBalance)
            {
                currentBalance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}