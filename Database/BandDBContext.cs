using Microsoft.EntityFrameworkCore;
using MVC_projeto.Models;

namespace MVC_projeto.Database
{
    public class BandDbcontext : DbContext
    {
        public BandDbcontext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<BandModel> Bands { get; set; }
    }
}
