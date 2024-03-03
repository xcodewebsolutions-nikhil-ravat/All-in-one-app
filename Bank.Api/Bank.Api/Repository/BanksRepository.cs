using Bank.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace Bank.Api.Repository
{
    public interface IBanksRepository
    {
        Task<List<Banks>> GetBanks();
    }

    public class BanksRepository : IBanksRepository
    {
        private readonly BanksDbContext _context;

        public BanksRepository(BanksDbContext context)
        {
            _context = context;
        }

        public async Task<List<Banks>> GetBanks()
        {
            return await _context.Banks.ToListAsync();
        }
    }
}
