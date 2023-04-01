using CampaignManager.Interfaces.Models;

namespace CampaignManager.Interfaces;

public interface IAccountEngine
{
  Task<Guid> CreateAccountAsync(Account account);
  Task<Account> GetAccountAsync(Guid accountId);
  Task<IEnumerable<Account>> GetAccountsAsync();
}