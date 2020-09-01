using ReactHomePage.Data;
using ReactHomePage.Models;
using ReactHomePage.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ReactHomePage.Repositories
{
    public class NewsRepository : Repository<News>, INewsRepository
    {
        private readonly ApplicationDbContext _context;

        public NewsRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }


    }
}