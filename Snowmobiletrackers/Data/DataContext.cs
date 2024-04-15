using Microsoft.EntityFrameworkCore;
using Snowmobiletrackers.Entities;

namespace Snowmobiletrackers.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {

        }

        public DbSet<Game> Games {  get; set; }    
    }
}
