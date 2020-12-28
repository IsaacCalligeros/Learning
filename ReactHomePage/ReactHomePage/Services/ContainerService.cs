using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ReactHomePage.Models;
using ReactHomePage.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactHomePage.Services.Container
{
    public class ContainerService : ServiceBaseHelper, IContainerService
    {
        private readonly IRepositoryWrapper _repo;
        private readonly IMapper _mapper;

        public ContainerService(IRepositoryWrapper repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<bool> SaveContainers(IEnumerable<BaseContainer> containers)
        {
            _repo.Containers.CreateRange(containers);
            await _repo.SaveAsync();
            return true;
        }

        public async Task<bool> SaveContainer(BaseContainer container)
        {
            _repo.Containers.Create(container);
            await _repo.SaveAsync();
            return true;
        }

        public async Task<bool> DeleteContainerByLayoutId(string i)
        {
            var container = _repo.Containers.FindByCondition(c => c.Layout.I == i).FirstOrDefault();
            if(container != null)
            {
                _repo.Containers.Delete(container);
                await _repo.SaveAsync(); 
            }
            
            return false;
        }

        public async Task<bool> UpdateContainer(IEnumerable<BaseContainer> containers)
        {
            foreach (var container in containers)
            {
                _repo.Containers.Update(container);
            }
            await _repo.SaveAsync();
            return true;
        }

        public IEnumerable<BaseContainer> GetUserContainers(int userId)
        {

            return _repo.Containers.GetUserContainers(userId);
        }
    }
}
