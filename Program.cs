using System;
using NLog;
using AppBancario.Models;
using BankingApp.Models;

namespace AppBancario.Models
{
    class Program
    {   
        public static void Main(string[] args) 
{
    Console.WriteLine("It's good to see you here!\nSelect the two options below: ");
    Console.Write("\n[1]  Access your account\n[2]  Open an account now\n");
    int selectOption = Convert.ToInt32(Console.ReadLine());

    Console.Clear();

    switch (selectOption)
    {
        case 1:
            Console.WriteLine("Is comming...");
            break;
        case 2:
            Console.Write("User registration\n________________________________________________\n");
            Costumer costumer = new Costumer();
            Account accountInfos = new Account();

            Console.Write("Enter your Document Number (CPF or SSN): ");
            long inputDocNumber = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine(costumer.GetDocNumber(inputDocNumber));
            
            Console.Write("Enter your first name: ");
            string fname = Console.ReadLine();
            Console.Write("Now, enter your last name: ");
            string lname = Console.ReadLine();
            //Console.WriteLine($"Hello, {costumer.FullName(fname, lname)}");

            Console.Write("Enter your date af birth: (yyyy.MM.dd) ");
            DateTime datetime = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine($"Your birth year: {costumer.GetDateOfBirth(datetime).ToString("yyyy-MM-dd")}");

            Console.Write("Now, create your account password\nThe password must be 8 characters long\n\n");
            string inputPassword = accountInfos.GetPassword();
            Console.WriteLine($"Hello, {costumer.FullName(fname, lname)}! It's good to have you with us. You can now access your account online");
            break;
        default:
            Console.WriteLine("Is comming...");
            break;
    }
}   
    }
}