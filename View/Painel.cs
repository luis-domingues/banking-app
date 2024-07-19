using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApp.View
{
    public class Painel
    {
        public void InitialPainel()
        {
            Console.WriteLine("Olá! É bom ter você por aqui (:");
            Console.WriteLine("__________________________________");
            Console.WriteLine("1. Criar Conta");
            Console.WriteLine("2. Acessar Saldo");
            Console.WriteLine("3. Realizar Transferência");
            Console.WriteLine("4. Deletar Conta");
            Console.WriteLine("5. Sair");
        }
    }
}