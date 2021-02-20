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
using ReactHomePage.Models.APIModels;
using ReactHomePage.Services.Container;
using ReactHomePage.Services.Interfaces;

namespace ReactHomePage.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class PortfolioController : ControllerBase
    {
        private readonly IPortfolioService _portfolioService;

        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        [HttpPut]
        [Route("FindOrCreate")]
        public PortfolioModel FindOrCreate()
        {
            var user = User.GetUserDetails();
            var portfolio = _portfolioService.FindOrCreate(user.UserId);
            return new PortfolioModel(portfolio);
        }

        [HttpPost]
        [Route("CreatePortfolio")]
        public ActionResult CreatePortfolio(Portfolio portfolio)
        {
            var user = User.GetUserDetails();
            portfolio.UserId = user.UserId;

            var addRes = _portfolioService.CreatePortfolio(portfolio);
            var dbPortfolio = _portfolioService.GetPortfolio(user.UserId);
            return Ok(new PortfolioModel(dbPortfolio));
        }

        [HttpDelete]
        [Route("DeletePortfolio")]
        public ActionResult DeletePortfolio(int portfolioId)
        {
            var user = User.GetUserDetails();
            var dbModel = _portfolioService.GetPortfolioById(portfolioId);
            if (dbModel.UserId != user.UserId)
            {
                return BadRequest("This Aint yours");
            }
            var delRes = _portfolioService.DeletePortfolio(portfolioId);
            return Ok(delRes);
        }
    }
}