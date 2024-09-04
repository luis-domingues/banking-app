using BankingApp.Models;

namespace BankingApp.Models
{
    internal class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }

        public Card Card { get; set; }
    }
}
