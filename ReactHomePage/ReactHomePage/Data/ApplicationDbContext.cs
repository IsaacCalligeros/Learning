using ReactHomePage.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReactHomePage.Entities.Models;

namespace ReactHomePage.Data
{
    public class ApplicationDbContext : KeyApiAuthorizationDbContext<ApplicationUser, AppRole, int>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Weather> Weather { get; set; }
        public DbSet<Equity> Equities { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<BaseContainer> Containers { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Layout> Layouts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>(entity => { entity.ToTable(name: "User"); });
            modelBuilder.Entity<AppRole>(entity => { entity.ToTable(name: "Role"); });
            
            modelBuilder.Entity<Portfolio>()
                .HasMany(e => e.Equities);

            modelBuilder.Entity<BaseContainer>()
                .HasOne(b => b.Layout);

            modelBuilder.Entity<Layout>();
        }
    }
}
