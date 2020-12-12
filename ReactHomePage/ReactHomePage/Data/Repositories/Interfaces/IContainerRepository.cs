using ReactHomePage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ReactHomePage.Repositories.Interfaces
{
    public interface IContainerRepository : IRepository<BaseContainer>
    {
        IEnumerable<BaseContainer> GetUserContainers(string userId);
    }
}