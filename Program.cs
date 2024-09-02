using System;

namespace BankingApp
{
    class Program 
    {
        static void Main(string[] args) 
        {
            CCustomer customer = new Customer
            {
                FirstName = "John",
                LastName = "Doe",
                Card = new Card
                {
                    Number = "1234567890123456",
                    ExpirationDate = new DateTime(2025, 12, 31),
                    Brand = "Visa",
                    Limit = 5000
                }
            };

            AppInterface display = new AppInterface();

            try
            {
                Console.WriteLine($"Welcome! {customer.FullName()}\n");
                display.MenuDisplay();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}