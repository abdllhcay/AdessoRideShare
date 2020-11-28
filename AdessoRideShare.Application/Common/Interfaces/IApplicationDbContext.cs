using AdessoRideShare.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace AdessoRideShare.Application.Common.Interfaces
{
    public interface  IApplicationDbContext
    {
        DbSet<Trip> Trips { get; set; }
        DbSet<City> Cities { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
