using Bogus;
using CampaignManager.Engines;
using CampaignManager.Interfaces;
using CampaignManager.Interfaces.Models;
using CampaignManager.Managers;
using FluentAssertions;
using NSubstitute;

namespace CampaignManager.Api.Tests;

public class AccountTests
{
  readonly IAccountEngine _engine;

  public AccountTests()
  {
    _engine = Substitute.For<IAccountEngine>();
  }

  [Fact]
  public async Task GIVEN_ValidAccountDetails_WHEN_CreatingAnAccount_SHOULD_ReturnAnAccountId()
  {
    // Arrange
    var account = new Faker<Account>()
      .CustomInstantiator(f =>
        new Account(
          f.Person.FirstName,
          f.Person.LastName,
          f.Person.Email,
          f.Internet.Password(),
          new Wallet(0)))
      .Generate();

    _engine.CreateAccountAsync(Arg.Any<Account>()).Returns(Guid.NewGuid());

    var accountManager = new AccountManager(_engine);

    // Act
    var accountId = await accountManager.RegisterAccountAsync(account);

    // Assert
    accountId.Should().NotBeEmpty();
  }
}