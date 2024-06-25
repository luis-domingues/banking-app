using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBancario.Models
{
    public class ClientAccount
    {
        public string ClientName { get; set; }
        private decimal Balance { get; set; }

        public void AccountAccess()
        {
            Console.WriteLine($"\nOlá, {ClientName}! Tudo bem?");
        }

        public void ShowBalance()
        {
            decimal Balance = 1000M;
            Console.WriteLine($"\nSALDO DISPONÍVEL: {Balance:c}");
        }
    }
}