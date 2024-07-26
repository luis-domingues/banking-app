using System;

namespace BankingApp
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Customer customer = new Customer();
            AppInterface display = new AppInterface();
            Console.WriteLine($"Welcome! {customer.FullName("INSERT", "NAME")}\n");
            display.MenuDisplay();
        }
    }
}