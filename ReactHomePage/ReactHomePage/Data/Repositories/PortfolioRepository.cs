using ReactHomePage.Data;
using ReactHomePage.Data.Repositories.Interfaces;
using ReactHomePage.Entities.Models;


namespace ReactHomePage.Data.Repositories
{
    public class PortfolioRepository : Repository<Portfolio>, IPortfolioRepository
    {
        private readonly ApplicationDbContext _context;

        public PortfolioRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}