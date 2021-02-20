using AutoMapper;
using Newtonsoft.Json;
using ReactHomePage.Entities.Dtos.Equities;
using ReactHomePage.Entities.Models;
using ReactHomePage.Helpers;
using ReactHomePage.Models;
using ReactHomePage.Repositories.Interfaces;
using ReactHomePage.Services.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ReactHomePage.Services.Container
{
    public class EquityService : ServiceBaseHelper, IEquityService
    {
        private readonly IRepositoryWrapper _repo;
        private readonly IMapper _mapper;

        public EquityService(IRepositoryWrapper repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        public async Task<bool> AddEquity(int userId, Equity equity)
        {
            var portfolio = _repo.Portfolios.FindById<Portfolio>(equity.PortfolioId);
            if (portfolio.UserId != userId)
            {
                return false;
            }

            _repo.Equities.Create(equity);
            var res = await _repo.SaveAsync();
            return res;
        }

        public async Task<bool> DeleteEquity(int equityId, int userId)
        {
            var equity = _repo.Equities.FindById<Equity>(equityId);
            var portfolio = _repo.Portfolios.FindById<Portfolio>(equity.PortfolioId);
            if (portfolio.UserId != userId)
            {
                return false;
            }

            _repo.Equities.DeleteById<Equity>(equityId);
            var res = await _repo.SaveAsync();
            return res;
        }

        public List<Company> GetASXCompanies(string searchTerm)
        {
            var resourceName = "ReactHomePage.Resources.companies-asx.json";
            var assembly = Assembly.GetExecutingAssembly();
            List<Company> companies = new List<Company>();

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                companies = JsonConvert.DeserializeObject<List<Company>>(result);
            }
            if (searchTerm != null)
            {
                companies = SearchHelper.ContainsSearch<Company>(companies, searchTerm);
            }

            return companies.Take(10).ToList();            
        }
    }
}
