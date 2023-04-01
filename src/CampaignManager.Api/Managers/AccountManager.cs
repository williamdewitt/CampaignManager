using CampaignManager.Engines;
using CampaignManager.Interfaces;
using CampaignManager.Interfaces.Models;

namespace CampaignManager.Managers;

public class AccountManager : IAccountManager
{
  private readonly IAccountEngine _engine;

  public AccountManager(IAccountEngine engine)
  {
    _engine = engine;
  }

  public Task<Guid> DepositAsync(Guid accountId, decimal amount)
  {
    throw new NotImplementedException();
  }

  public Task<Account> GetAccountAsync(Guid accountId)
  {
    throw new NotImplementedException();
  }

  public Task<IEnumerable<Account>> GetAccountsAsync()
  {
    throw new NotImplementedException();
  }

  public async Task<Guid> RegisterAccountAsync(Account account)
  {
    return await _engine.CreateAccountAsync(account);
  }
}