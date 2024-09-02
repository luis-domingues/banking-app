namespace BankingApp.Models;

public class Card
{
    public string Number { get; set; }
    public DateTime ExpirationDate { get; set; }
    public string Brand { get; set; }
    public decimal Limit { get; set; }
}