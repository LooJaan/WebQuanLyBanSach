using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly MyDbContext _context;

        public AccountRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Account>> GetAllAccountsAsync()
        {
            return await _context.accounts.ToListAsync();
        }

        public async Task<Account> GetAccountByIdAsync(Guid id)
        {
            return await _context.accounts.FindAsync(id);
        }

        public async Task<Account> GetAccountByUsernameAsync(string username)
        {
            return await _context.accounts.FirstOrDefaultAsync(a => a.UserName == username);
        }

        public async Task AddAccountAsync(Account account)
        {
            await _context.accounts.AddAsync(account);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAccountAsync(Account account)
        {
            _context.accounts.Update(account);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAccountAsync(Guid id)
        {
            var account = await _context.accounts.FindAsync(id);
            if (account != null)
            {
                _context.accounts.Remove(account);
                await _context.SaveChangesAsync();
            }
        }
    }

}
