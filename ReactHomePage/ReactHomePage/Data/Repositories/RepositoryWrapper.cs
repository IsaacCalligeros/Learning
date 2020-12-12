using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using ReactHomePage.Repositories.Interfaces;
using ReactHomePage.Data;
using ReactHomePage.Models;
using ReactHomePage.Data.Repositories;

namespace ReactHomePage.Data.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        //Based off of https://code-maze.com/net-core-web-development-part4/#comments

        private ApplicationDbContext _dataContext;
        private IWeatherRepository _weather;
        private INewsRepository _news;
        private IStockRepository _stock;
        private IContainerRepository _container;

        private readonly IHttpContextAccessor _httpContextAccessor;

        public RepositoryWrapper(ApplicationDbContext dataContext, IHttpContextAccessor httpContextAccessor)
        {
            _dataContext = dataContext;
            _httpContextAccessor = httpContextAccessor;
        }

        public IWeatherRepository Weather
        {
            get
            {
                if (_weather == null)
                {
                    _weather = new WeatherRepository(_dataContext);
                }

                return _weather;
            }
        }

        public INewsRepository News
        {
            get
            {
                if (_news == null)
                {
                    _news = new NewsRepository(_dataContext);
                }

                return _news;
            }
        }

        public IStockRepository Stocks
        {
            get
            {
                if (_stock == null)
                {
                    _stock = new StockRepository(_dataContext);
                }

                return _stock;
            }
        }

        public IContainerRepository Containers
        {
            get
            {
                if (_container == null)
                {
                    _container = new ContainerRepository(_dataContext);
                }

                return _container;
            }
        }

        public async Task<bool> SaveAsync(string savingEntity)
        {
            addAuditableFields(_dataContext, savingEntity);
            return await _dataContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> SaveAsync()
        {
            return await _dataContext.SaveChangesAsync() > 0;
        }

        private void addAuditableFields(ApplicationDbContext data, string savingEntity)
        {
            var entries = data.ChangeTracker
                .Entries()
                .Where(e => e.Entity is Auditables && (e.State == EntityState.Added || e.State == EntityState.Modified));

            //var userId1 = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var currentUserName = !string.IsNullOrEmpty(savingEntity)
                ? savingEntity
                : "Anonymous";

            foreach (var entityEntry in entries)
            {
                ((Auditables)entityEntry.Entity).DateUpdated = DateTime.UtcNow;
                ((Auditables)entityEntry.Entity).UpdatedBy = currentUserName;

                if (entityEntry.State == EntityState.Added)
                {
                    ((Auditables)entityEntry.Entity).DateCreated = DateTime.UtcNow;
                    ((Auditables)entityEntry.Entity).CreatedBy = currentUserName;
                }
            }
        }
    }
}