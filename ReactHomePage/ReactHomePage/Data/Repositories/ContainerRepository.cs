using ReactHomePage.Data;
using ReactHomePage.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using ReactHomePage.Entities.Models;

namespace ReactHomePage.Data.Repositories
{
    public class ContainerRepository : Repository<BaseContainer>, IContainerRepository
    {
        private readonly ApplicationDbContext _context;

        public ContainerRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<BaseContainer> GetUserContainers(int userId)
        {
            return _context.Containers
                .Include(u => u.Layout)
                .AsNoTracking()
                .Where(u => u.UserId == userId).ToList();                
        }

    }
}