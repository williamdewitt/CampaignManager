using CampaignManager.Interfaces;
using CampaignManager.Interfaces.Models;

namespace CampaignManager.Engines;

public class AccountEngine : IAccountEngine
{
  public Task<Guid> CreateAccountAsync(Account account)
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
}
