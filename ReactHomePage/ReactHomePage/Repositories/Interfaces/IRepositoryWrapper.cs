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
        IStockRepository Stocks { get; }

        Task<bool> SaveAsync(string savingEntity);
        Task<bool> SaveAsync();
    }
}