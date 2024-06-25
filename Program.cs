using System;
using AppBancario.Models;

namespace AppBancario.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================");
            Console.Write("Por favor, insira seus dados corretamente.\nDigite seu nome: ");
            string name = Console.ReadLine();

            Console.Clear();

            ClientAccount conta_cliente = new ClientAccount();
            conta_cliente.ClientName = name;
            conta_cliente.ShowBalance();
            conta_cliente.AccountAccess();

            Console.WriteLine("\nO que deseja fazer?");
            Console.Write("\n[1].  Ver saldo bancário\n[2].  Realizar saque\n[3].  Realizar depósito\n[4].  Transferir dinheiro\n[5].  Sair da conta\n");
            int selectSection = Convert.ToInt32(Console.ReadLine());

            switch(selectSection)
            {
                case 1:
                    selectSection = 1;
                    conta_cliente.ShowBalance();
                    break;
                case 2:
                    selectSection = 2;
                    break; //under development...
                case 3:
                    selectSection = 3;
                    break; //under development...
                case 4:
                    selectSection = 4;
                    break; //under development.. 
                case 5:
                    selectSection = 5;
                    break; //under development...
                default:
                    selectSection = 0;
                    break; //under development...
            }
        }
    }
}