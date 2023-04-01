using CampaignManager.Interfaces.Enums;

namespace CampaignManager.Interfaces.Models;

public class Account
{
  public Guid Id { get; }

  public string FirstName { get; init; }

  public string LastName { get; init; }

  public string Email { get; init; }

  public string Password { get; init; }

  public Wallet Wallet { get; init; }

  public AccountStatus Status { get; }

  public Account(
    string firstName, 
    string lastName, 
    string email, 
    string password, 
    Wallet wallet)
  {
    FirstName = firstName;
    LastName = lastName;
    Email = email;
    Password = password;
    Wallet = wallet;
    Status = AccountStatus.Active;
  }
}