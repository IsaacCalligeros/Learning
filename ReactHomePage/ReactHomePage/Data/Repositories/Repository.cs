using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ReactHomePage.Data;
using ReactHomePage.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ReactHomePage.Data.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {

        protected ApplicationDbContext DataContext;
        public Repository(ApplicationDbContext context)
        {
            DataContext = context;
        }

        public async Task<bool> SaveAll()
        {
            return await DataContext.SaveChangesAsync() > 0;
        }

        public IQueryable<T> FindAll()
        {
            return DataContext.Set<T>().AsNoTracking();
        }

        public async Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match)
        {
            return await DataContext.Set<T>().Where(match).ToListAsync();
        }

        public T FindById<T>(object id) where T : class
        {
            return DataContext.Set<T>().Find(id);
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return DataContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            DataContext.Set<T>().Add(entity);
        }

        public void CreateRange(IEnumerable<T> entities)
        {
            DataContext.Set<T>().AddRange(entities);
        }

        public void Update(T entity)
        {
            DataContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            DataContext.Set<T>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            DataContext.Set<T>().RemoveRange(entities);
        }
    }
}