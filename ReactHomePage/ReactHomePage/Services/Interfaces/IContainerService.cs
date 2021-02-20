using ReactHomePage.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactHomePage.Services.Container
{
    public interface IContainerService
    {
        Task<bool> SaveContainers(IEnumerable<BaseContainer> containers);
        Task<bool> SaveContainer(BaseContainer container);
        Task<bool> DeleteContainerByLayoutId(string i);
        Task<bool> UpdateContainers(IEnumerable<BaseContainer> container, int userId);
        IEnumerable<BaseContainer> GetUserContainers(int userId);
    }
}
