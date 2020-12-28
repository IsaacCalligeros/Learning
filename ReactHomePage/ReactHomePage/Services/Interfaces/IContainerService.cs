using ReactHomePage.Models;
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
        Task<bool> UpdateContainer(IEnumerable<BaseContainer> container);
        IEnumerable<BaseContainer> GetUserContainers(int userId);
    }
}
