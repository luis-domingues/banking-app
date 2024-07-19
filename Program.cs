using System;
using NLog;
using AppBancario.Models;
using BankingApp.Models;
using BankingApp.Services;
using BankingApp.View;

namespace AppBancario.Models
{
    class Program
    {
        public static void Main(string[] args)
        {
            Painel painel = new Painel();
            IAccountService accountService = new AccountService();

            while (true)
            {
                painel.InitialPainel();
                string option = Console.ReadLine();

                Console.Clear();

                switch (option)
                {
                    case "1":
                        Console.Write("Digite o nome do cliente: ");
                        string name = Console.ReadLine();
                        Console.Write("Digite o saldo inicial: ");
                        decimal initialBalance = decimal.Parse(Console.ReadLine());
                        accountService.CreateAccount(name, initialBalance);
                        break;
                    case "2":
                        Console.Write("Digite o ID da conta: ");
                        int accountId = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Saldo: {accountService.GetBalance(accountId)}");
                        break;
                    case "3":
                        Console.Write("Digite o ID da conta de origem: ");
                        int fromAccountId = int.Parse(Console.ReadLine());
                        Console.Write("Digite o ID da conta de destino: ");
                        int toAccountId = int.Parse(Console.ReadLine());
                        Console.Write("Digite o valor a ser transferido: ");
                        decimal amount = decimal.Parse(Console.ReadLine());
                        accountService.Transfer(fromAccountId, toAccountId, amount);
                        break;
                    case "4":
                        Console.Write("Digite o ID da conta: ");
                        accountId = int.Parse(Console.ReadLine());
                        accountService.DeleteAccount(accountId);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}