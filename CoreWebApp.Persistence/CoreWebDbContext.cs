using CoreWebApp.Application.Interfaces;
using CoreWebApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CoreWebApp.Persistence {
    public class CoreWebDbContext : DbContext, ICoreWebAppContext {
        public CoreWebDbContext(DbContextOptions<CoreWebDbContext> options) : base(options) {
        }
        public DbSet<Designation> Designation { get; set; }
        public DbSet<SystemUser> SystemUser { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Incident> Incident { get; set; }
        public DbSet<IncidentActivity> IncidentActivity { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken()) {
            foreach (var entity in ChangeTracker.Entries<EntityBase>()) {
                switch (entity.State) {
                    case EntityState.Added:
                        entity.Entity.CreatedOn = DateTime.Now;
                        entity.Entity.ModifiedOn = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entity.Entity.ModifiedOn = DateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.ApplyConfigurationsFromAssembly(typeof(CoreWebDbContext).Assembly);
        }
    }
}
