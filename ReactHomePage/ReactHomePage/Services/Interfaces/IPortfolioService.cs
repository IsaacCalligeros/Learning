﻿using ReactHomePage.Entities.Models;
using ReactHomePage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactHomePage.Services.Interfaces
{
    public interface IPortfolioService
    {
        public Portfolio GetPortfolio(int userId);
        public bool CreatePortfolio(Portfolio portfolio);
        public bool DeletePortfolio(int portfolioId);
    }
}
