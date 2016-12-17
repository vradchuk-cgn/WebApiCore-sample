using Microsoft.EntityFrameworkCore;
using WebApi.DataAccess.Tables;

namespace WebApi.DataAccess
{
    public class KpiDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<MURegion> MuRegions { get; set; }
    }
}