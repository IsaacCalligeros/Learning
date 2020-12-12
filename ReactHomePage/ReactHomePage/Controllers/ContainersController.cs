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
using ReactHomePage.Helpers;
using ReactHomePage.Models;
using ReactHomePage.Services.Container;

namespace ReactHomePage.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContainersController : ControllerBase
    {
        private readonly IContainerService _containersService;

        public ContainersController(IContainerService containerService)
        {
            _containersService = containerService;
        }

        //[HttpPost]
        //[Route("SaveContainers")]
        //public async Task<bool> SaveContainers(IEnumerable<BaseContainer> containers)
        //{
        //    var user = User.GetUserDetails();
        //    containers.ToList().ForEach(u => u.UserId = user.UserId);
        //    var containersSaved = await _containersService.SaveContainers(containers);
        //    return containersSaved;
        //}

        [HttpPost]
        [Route("SaveContainer")]
        public async Task<bool> SaveContainer(BaseContainer container)
        {
            var user = User.GetUserDetails();
            container.UserId = user.UserId;
            var containersSaved = await _containersService.SaveContainer(container);
            return containersSaved;
        }

        [HttpDelete]
        [Route("Delete/{layoutId}")]
        public async Task<bool> DeleteContainer(string layoutId)
        {
            var user = User.GetUserDetails();

            var containersSaved = await _containersService.DeleteContainerByLayoutId(layoutId);
            return containersSaved;
        }

        [HttpPost]
        [Route("UpdateContainers")]
        public async Task<bool> updateContainers(List<BaseContainer> containers)
        {
            var user = User.GetUserDetails();
            containers.ForEach(c => c.UserId = user.UserId);

            var layoutIds = containers.Select(l => l.Layout.I);
            var dbContainers = _containersService.GetUserContainers(user.UserId).ToList();
            if (dbContainers.Count() == 0)
            {
                return false;
            }

            dbContainers.ForEach(dbc => dbc.Layout = containers.Where(c => c.Layout.I == dbc.Layout.I).FirstOrDefault()?.Layout);

            var containersSaved = await _containersService.UpdateContainer(containers);

            return containersSaved;
        }

        [HttpGet]
        [Route("GetContainers")]
        public IEnumerable<BaseContainer> GetContainers()
        {
            var user = User.GetUserDetails();
            return _containersService.GetUserContainers(user.UserId);
        }
    }
}