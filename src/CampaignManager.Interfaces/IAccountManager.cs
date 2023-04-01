using CampaignManager.Interfaces.Models;

namespace CampaignManager.Interfaces;

public interface IAccountManager
{
  Task<Guid> RegisterAccountAsync(Account account);
  Task<Account> GetAccountAsync(Guid accountId);
  Task<IEnumerable<Account>> GetAccountsAsync();
  Task<Guid> DepositAsync(Guid accountId, decimal amount);
}
