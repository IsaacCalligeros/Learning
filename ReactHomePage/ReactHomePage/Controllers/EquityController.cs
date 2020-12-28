using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ReactHomePage.Dtos.News;
using ReactHomePage.Entities.Dtos.Equities;
using ReactHomePage.Entities.Models;
using ReactHomePage.Helpers;
using ReactHomePage.Models;
using ReactHomePage.Services.Container;
using ReactHomePage.Services.Interfaces;

namespace ReactHomePage.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EquityController : ControllerBase
    {
        private readonly IEquityService _equityService;

        public EquityController(IEquityService equityService)
        {
            _equityService = equityService;
        }

        [HttpPost]
        [Route("AddEquity")]
        public async Task<ActionResult> AddEquity(int portfolioId, Equity equity)
        {
            var user = User.GetUserDetails();
            var addRes = await _equityService.AddEquity(portfolioId, user.UserId, equity);
            return Ok(addRes);
        }

        [HttpDelete]
        [Route("DeleteEquity")]
        public async Task<ActionResult> DeleteEquity(int portfolioId, int equityId)
        {
            var user = User.GetUserDetails();
            var addRes = await _equityService.DeleteEquity(portfolioId, equityId, user.UserId);
            return Ok(addRes);
        }

        [HttpGet]
        [Route("GetAsxCompanies")]
        public List<ASXCompanies> GetAsxCompanies(string searchTerm)
        {
            return _equityService.GetASXCompanies(searchTerm);
        }
    }
}