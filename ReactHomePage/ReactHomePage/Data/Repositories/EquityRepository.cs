using ReactHomePage.Data;
using ReactHomePage.Entities.Models;
using ReactHomePage.Models;
using ReactHomePage.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ReactHomePage.Data.Repositories
{
    public class EquityRepository : Repository<Equity>, IEquityRepository
    {
        private readonly ApplicationDbContext _context;

        public EquityRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}