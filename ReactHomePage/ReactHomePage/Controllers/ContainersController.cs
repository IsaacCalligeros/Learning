
using System.Collections.Generic;

using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReactHomePage.Entities.Models;
using ReactHomePage.Helpers;
using ReactHomePage.Services.Container;

namespace ReactHomePage.Controllers
{
    [ApiController]
    [Authorize]
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
            if(container.LayoutId == null)
            {
                container.LayoutId = container.Layout.I;
            }
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

            var containersSaved = await _containersService.UpdateContainers(containers, user.UserId);

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