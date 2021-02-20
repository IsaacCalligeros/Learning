using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ReactHomePage.Entities.Models;
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
            var res = await _repo.SaveAsync();
            return res;
        }

        public async Task<bool> SaveContainer(BaseContainer container)
        {
            _repo.Containers.Create(container);
            var res = await _repo.SaveAsync();
            return res;
        }

        public async Task<bool> DeleteContainerByLayoutId(string i)
        {
            var container = _repo.Containers.FindByCondition(c => c.Layout.I == i).FirstOrDefault();
            if(container != null)
            {
                _repo.Containers.Delete(container);
                var res = await _repo.SaveAsync();
                return res;
            }

            return false;
        }

        public async Task<bool> UpdateContainers(IEnumerable<BaseContainer> containers, int userId)
        {
            foreach (var container in containers)
            {
                _repo.Layouts.Update(container.Layout);
            }
            return await _repo.SaveAsync();
        }

        public IEnumerable<BaseContainer> GetUserContainers(int userId)
        {

            return _repo.Containers.GetUserContainers(userId);
        }
    }
}
