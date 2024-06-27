using System;
using NLog;
using AppBancario.Models;

namespace AppBancario.Models
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================");
            Console.Write("Por favor, insira seus dados corretamente.\nDigite seu nome: ");
            string name = Console.ReadLine();

            Console.Clear();

            ClientAccount conta_cliente = new ClientAccount(name);
            conta_cliente.AccountAccess();

            bool access = true;
            while (access)
            {
                Console.WriteLine("\nO que deseja fazer?");
                Console.Write("\n[1].  Ver saldo bancário\n[2].  Realizar saque\n[3].  Realizar depósito\n[4].  Transferir dinheiro\n[5].  Sair da conta\n");
                int selectSection = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (selectSection)
                {
                    case 1:
                        conta_cliente.ShowBalance();
                        break;

                    case 2:
                        Console.Write("\nValor do saque: ");
                        decimal amount;
                        try
                        {
                            amount = Convert.ToDecimal(Console.ReadLine());
                            if (conta_cliente.WithdrawMoney(amount))
                            {
                                conta_cliente.ShowBalance();
                            }
                        }
                        catch (FormatException erroAmount)
                        {
                            Console.WriteLine($"Erro de saque: {erroAmount.Message}");
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nDigite o valor que deseja depositar: ");
                        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                        if (conta_cliente.Deposit(depositAmount))
                        {
                            conta_cliente.ShowBalance();
                        }
                        break;

                    case 4:
                        Console.WriteLine("Esta opção ainda está em desenvolvimento");
                        break; //under development...

                    case 5:
                        Console.WriteLine("Obrigado por utilizar o nosso serviço!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Selecione uma opção válida.");
                        break;
                }
            }
        }
    }
}