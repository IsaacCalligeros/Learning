using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using IEXSharp;
using IEXSharp.Model;
using IEXSharp.Model.Shared.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ReactHomePage.Entities.Dtos.Equities;
using ReactHomePage.Helpers;
using ReactHomePage.Models;
using ReactHomePage.Services.Interfaces;
using static ReactHomePage.Entities.Dtos.Equities.StockPriceData;

namespace ReactHomePage.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class EquityController : ControllerBase
    {
        private readonly IEquityService _equityService;
        private IHttpClientFactory _factory;
        private IConfiguration _config;

        public EquityController(IEquityService equityService, IHttpClientFactory factory, IConfiguration config)
        {
            _equityService = equityService;
            _factory = factory;
            _config = config;
        }

        [HttpPost]
        [Route("AddEquity")]
        public async Task<ActionResult> AddEquity(Equity equity)
        {
            var user = User.GetUserDetails();
            var addRes = await _equityService.AddEquity(user.UserId, equity);
            return Ok(addRes);
        }

        [HttpDelete]
        [Route("DeleteEquity")]
        public async Task<ActionResult> DeleteEquity(int equityId)
        {
            var user = User.GetUserDetails();
            var addRes = await _equityService.DeleteEquity(equityId, user.UserId);
            return Ok(addRes);
        }

        [HttpGet]
        [Route("GetAsxCompanies")]
        public List<Company> GetAsxCompanies(string searchTerm)
        {
            return _equityService.GetASXCompanies(searchTerm);
        }

        [HttpGet("GetCompany")]
        public async Task<Quote> GetCompany(string companyTicker, string exchangeCode = "-AT")
        {
            using (var iexCloudClient =
                new IEXCloudClient(_config["iexPublic"], _config["iexPrivate"], signRequest: false, useSandBox: false))
            {
                
                var res = await iexCloudClient.StockPrices.QuoteAsync(companyTicker + exchangeCode);
                if(res.Data != null)
                {
                    return res.Data;
                }
                return null;
            }
        }
    }
}
