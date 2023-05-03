using Microsoft.EntityFrameworkCore;
using MVC_projeto.Models;

namespace MVC_projeto.Database
{
    public class BandDBContext : DbContext 
    {
        BandDBContext(DbContextOptions<BandDBContext> options) : base(options)
        {

        }

        public DbSet<BandModel> Bands { get; set; }
    }
}
