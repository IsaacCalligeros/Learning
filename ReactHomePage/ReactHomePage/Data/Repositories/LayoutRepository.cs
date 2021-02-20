using ReactHomePage.Data;
using ReactHomePage.Data.Repositories.Interfaces;
using ReactHomePage.Entities.Models;
using ReactHomePage.Models;
using ReactHomePage.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ReactHomePage.Data.Repositories
{
    public class LayoutRepository : Repository<Layout>, ILayoutRepository
    {
        private readonly ApplicationDbContext _context;

        public LayoutRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }


    }
}