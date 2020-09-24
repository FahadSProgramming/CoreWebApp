using CoreWebApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace CoreWebApp.Application.Interfaces {
    public interface ICoreWebAppContext {
        DbSet<Designation> Designation { get; set; }
        DbSet<SystemUser> SystemUser { get; set; }
        DbSet<Project> Project { get; set; }
        DbSet<Customer> Customer { get; set; }
        DbSet<Contact> Contact { get; set; }
        DbSet<Category> Category { get; set; }
        DbSet<Incident> Incident { get; set; }
        DbSet<IncidentActivity> IncidentActivity { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
