using ReactHomePage.Data;
using ReactHomePage.Models;
using ReactHomePage.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactHomePage.Data.Repositories
{
    public class WeatherRepository : Repository<Weather>, IWeatherRepository
    {
        private readonly ApplicationDbContext _context;

        public WeatherRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }


    }
}