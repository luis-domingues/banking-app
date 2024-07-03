using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NLog;

namespace AppBancario.Models
{
    public class ClientAccount
    {
        public string ClientName { get; set; }
        public int ClientNumberAccess { get; set; }
        public decimal Balance { get; set; }

        public ClientAccount(string clientName, int clientNumberAccess, decimal initialBalance = 100M)
        {
            ClientName = clientName;
            ClientNumberAccess = clientNumberAccess;
            Balance = initialBalance;
        }

        public void AccountAccess()
        {
            Console.WriteLine($"Olá, {ClientName}! Tudo bem?");
        }

        public void ShowBalance()
        {
            Console.WriteLine($"SALDO DISPONÍVEL: {Balance:c}");
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

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public bool Deposit(decimal depositAmount)
        {
            try
            {
                if (depositAmount <= 0)
                {
                    Console.Clear();
                    throw new ArgumentException("Valor do depósito deve ser positivo.");
                }

                Balance += depositAmount;
                Console.WriteLine($"Depósito de {depositAmount:c} realizado com sucesso!");
                return true;
            }
            catch (FormatException erroDeposit)
            {
                logger.Error($"ERRO DE DEPÓSITO. DIGITE UM NÚMERO VÁLIDO. {erroDeposit}");
                Console.Write("ERRO DE DEPÓSITO. DIGITE UM NÚMERO VÁLIDO.");
                return false;
            }
            catch (OverflowException erroSurplusValue)
            {
                logger.Error($"ERRO DE VALOR. O DEPÓSITO EXCEDE O LIMETE DA CONTA. {erroSurplusValue}");
                Console.Write($"ERRO DE VALOR. O DEPÓSITO EXCEDE O LIMETE DA CONTA.");
                return false;
            }
            catch (ArgumentException erroDecimalPositive)
            {
                logger.Error($"ERRO DE DEPÓSITO. DIGITE UM VALOR POSITIVO. {erroDecimalPositive}");
                Console.Write($"ERRO DE DEPÓSITO. DIGITE UM VALOR POSITIVO.");
                return false;
            }
            catch (Exception erroGenericExecution)
            {
                logger.Error($"Erro inesperado durante o depósito. {erroGenericExecution}");
                Console.WriteLine($"Erro inesperado durante o depósito.");
                return false;
            }
        }

        public bool Transfer(decimal amountMoneyTranfer, string nameAccountTransfer)
        {
            try
            {
                if (amountMoneyTranfer <= 0 || !decimal.TryParse(amountMoneyTranfer.ToString(), out decimal amount))
                {
                    logger.Error("Valor da transferência inválido. Digite um valor decimal positivo.");
                    return false;
                }

                if (amountMoneyTranfer > Balance)
                {
                    logger.Error("Saldo insuficiente para realizar a transferência.");
                    return false;
                }

                Balance -= amountMoneyTranfer;
                Console.WriteLine($"SUCESSO!\nO você transferiu {amountMoneyTranfer:c} para {nameAccountTransfer}.");
                return true;
            }
            catch (Exception erroTransfer)
            {
                logger.Error($"Erro ao realizar transferência. {erroTransfer}");
                return false;
            }
        }
    }
}