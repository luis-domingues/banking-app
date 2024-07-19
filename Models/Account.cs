using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApp.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public decimal Balance { get; set; }

        public Account(int id, string customerName, decimal balance)
        {
            Id = id;
            CustomerName = customerName;
            Balance = balance;
        }
    }
}