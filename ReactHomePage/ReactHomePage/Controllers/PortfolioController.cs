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
using ReactHomePage.Entities.Models;
using ReactHomePage.Helpers;
using ReactHomePage.Models;
using ReactHomePage.Services.Container;
using ReactHomePage.Services.Interfaces;

namespace ReactHomePage.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PortfolioController : ControllerBase
    {
        private readonly IPortfolioService _portfolioService;

        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        [HttpGet]
        [Route("GetPortfolio")]
        public Portfolio GetPortfolio()
        {
            var user = User.GetUserDetails();
            return _portfolioService.GetPortfolio(user.UserId);
        }

        [HttpPost]
        [Route("CreatePortfolio")]
        public ActionResult CreatePortfolio(Portfolio portfolio)
        {
            var user = User.GetUserDetails();
            portfolio.UserId = user.UserId;

            var addRes = _portfolioService.CreatePortfolio(portfolio);
            return Ok(addRes);
        }

        [HttpDelete]
        [Route("AddPortfolio")]
        public ActionResult DeletePortfolio(int portfolioId)
        {
            var user = User.GetUserDetails();
            var dbModel = _portfolioService.GetPortfolio(user.UserId);
            var delRes = _portfolioService.DeletePortfolio(portfolioId);
            return Ok(delRes);
        }
    }
}