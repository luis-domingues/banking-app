using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApp.Models
{
    internal class BankInfos
    {
        private decimal balance { get; set; }

        public BankInfos()
        {
            this.balance = 100;
        }
        public decimal ShowBalance()
        {
            return balance;
        }

        public bool Transfer(decimal amount) 
        {
            if(amount <= balance)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}