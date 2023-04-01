namespace CampaignManager.Interfaces.Models;

public class Wallet
{
  public Guid Id { get; }
  public decimal Balance { get; init; }

  public Wallet(decimal balance)
  {
    Balance = balance;
  }
}