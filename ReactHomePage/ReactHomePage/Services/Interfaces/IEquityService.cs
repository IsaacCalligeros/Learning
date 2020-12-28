using ReactHomePage.Entities.Dtos.Equities;
using ReactHomePage.Entities.Models;
using ReactHomePage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactHomePage.Services.Interfaces
{
    public interface IEquityService
    {
        public Task<bool> AddEquity(int portfolioId, int userId, Equity equity);

        public Task<bool> DeleteEquity(int portfolioId, int equityId, int userId);

        public List<ASXCompanies> GetASXCompanies(string searchTerm);
    }
}
