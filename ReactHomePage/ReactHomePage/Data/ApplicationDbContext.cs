using ReactHomePage.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactHomePage.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Weather> Weather { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<BaseContainer> Containers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<BaseContainer>()
            //    .HasKey(x => new { x.ContainerId, x.Layout });
            //modelBuilder.Entity<BaseContainer>()
            //    .HasOne(p => p.Layout);
        }
    }
}
