using HealthyPet.API.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthyPet.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options): base(options){}
        public DbSet<VetConsult> VetConsults { get; set; }
    }
}