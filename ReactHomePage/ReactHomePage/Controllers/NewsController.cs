using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ReactHomePage.Helpers;

namespace ReactHomePage.Controllers {
    [ApiController]
    [Route ("api/[controller]")]
    public class NewsController : ControllerBase {
        private IConfiguration configuration;
        private IHttpClientFactory _factory;
        public NewsController (IConfiguration config, IHttpClientFactory factory) {
            configuration = config;
            _factory = factory;
        }

        [HttpGet ("GetNews")]
        public async Task<IActionResult> GetNewsApi (string searchTerm) {
            var client = _factory.CreateClient(HttpClientHelper.News);
            var news = await client.GetStringAsync ($"");

            return Ok ();
        }

    }
}