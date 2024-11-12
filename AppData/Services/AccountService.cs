using AppData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<IEnumerable<Account>> GetAllAccountsAsync()
        {
            return await _accountRepository.GetAllAccountsAsync();
        }

        public async Task<Account> GetAccountByIdAsync(Guid id)
        {
            return await _accountRepository.GetAccountByIdAsync(id);
        }

        public async Task<Account> GetAccountByUsernameAsync(string username)
        {
            return await _accountRepository.GetAccountByUsernameAsync(username);
        }

        public async Task AddAccountAsync(Account account)
        {
            await _accountRepository.AddAccountAsync(account);
        }

        public async Task UpdateAccountAsync(Account account)
        {
            await _accountRepository.UpdateAccountAsync(account);
        }

        public async Task DeleteAccountAsync(Guid id)
        {
            await _accountRepository.DeleteAccountAsync(id);
        }
    }

}
