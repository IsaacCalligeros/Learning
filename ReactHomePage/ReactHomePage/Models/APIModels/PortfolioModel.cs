using ReactHomePage.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactHomePage.Models.APIModels
{
    public class PortfolioModel
    {
        public IEnumerable<EquityModel> Equities { get; set; }
        public int Id { get; set; }
        public int UserId { get; set; }

        public PortfolioModel(Portfolio portfolio)
        {
            Id = portfolio.Id;
            UserId = portfolio.UserId;
            Equities = EquityModelHelpers.MapToModelCollection(portfolio.Equities);
        }
    }
}
