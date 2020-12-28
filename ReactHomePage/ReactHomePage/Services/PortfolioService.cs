using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ReactHomePage.Entities.Models;
using ReactHomePage.Models;
using ReactHomePage.Repositories.Interfaces;
using ReactHomePage.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactHomePage.Services.Container
{
    public class PortfolioService : ServiceBaseHelper, IPortfolioService
    {
        private readonly IRepositoryWrapper _repo;
        private readonly IMapper _mapper;

        public PortfolioService(IRepositoryWrapper repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public Portfolio GetPortfolio(int userId)
        {
            return _repo.Portfolios.FindByCondition(p => p.UserId == userId).FirstOrDefault();
        }

        public bool CreatePortfolio(Portfolio portfolio)
        {
            _repo.Portfolios.Create(portfolio);
            return _repo.SaveChanges();
        }

        public bool DeletePortfolio(int portfolioId)
        {
            _repo.Portfolios.DeleteById<Portfolio>(portfolioId);
            return _repo.SaveChanges();
        }

    }
}
