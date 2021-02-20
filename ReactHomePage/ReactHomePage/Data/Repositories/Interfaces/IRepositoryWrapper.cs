﻿using ReactHomePage.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactHomePage.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
        IWeatherRepository Weather { get; }
        INewsRepository News { get; }
        IEquityRepository Equities { get; }
        IContainerRepository Containers { get; }
        IPortfolioRepository Portfolios { get; }
        ILayoutRepository Layouts { get; }

        Task<bool> SaveAsync(string savingEntity);
        Task<bool> SaveAsync();
        bool SaveChanges();
    }
}