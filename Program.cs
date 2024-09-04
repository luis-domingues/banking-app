using BankingApp.Models;
using BankingApp.Services;
using BankingApp.Views;
using BankingApp.Models;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                FirstName = "Insert",
                LastName = "Name",
                Card = new Card
                {
                    Number = "1234567890123456",
                    ExpirationDate = new DateTime(2025, 12, 31),
                    Brand = "Visa",
                    Limit = 5000
                }
            };

            BankAccount bankAccount = new BankAccount(500);

            AppServices appServices = new AppServices(bankAccount, customer);
            AppInterface display = new AppInterface(appServices);

            try
            {
                Console.WriteLine($"Welcome! {customer.FullName()}\n");
                display.MenuDisplay();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            Console.ReadKey();

        }
    }
}
