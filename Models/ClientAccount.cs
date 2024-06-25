using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBancario.Models
{
    public class ClientAccount
    {
        public string ClientName { get; set; }
        public decimal Balance { get; set; }

        public ClientAccount(string clientName, decimal initialBalance = 0M)
        {
            ClientName = clientName;
            Balance = initialBalance;
        }

        public void AccountAccess()
        {
            Console.WriteLine($"Olá, {ClientName}! Tudo bem?");
        }

        public void ShowBalance()
        {
            Console.WriteLine($"\nSALDO DISPONÍVEL: {Balance:c}");
        }

        public bool WithdrawMoney(decimal amount)
        {
            try
            {
                if (amount > Balance)
                {
                    Console.WriteLine("SALDO INSUFICIENTE");
                    return false;
                }

                Balance -= amount;
                Console.WriteLine($"\nSAQUE DE {amount:c} REALIZADO!");
                return true;
            }
            catch (Exception erroAmount)
            {
                Console.WriteLine($"ERRO DE SAQUE {erroAmount.Message}");
                return true;
            }
        }
    }
}