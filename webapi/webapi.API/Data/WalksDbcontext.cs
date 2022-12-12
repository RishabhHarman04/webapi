using Microsoft.EntityFrameworkCore;
using webapi.API.Models.Domain;

namespace webapi.API.Data
{
    public class WalksDbcontext: DbContext
    {
        public WalksDbcontext(DbContextOptions<WalksDbcontext> options): base(options) 
        {

        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
} 
