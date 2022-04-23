using Microsoft.EntityFrameworkCore;

namespace MuSeek.Models
{
    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options)
            : base(options)
        {
        }

        public DbSet<Music> music { get; set; }

        public DbSet<Artist> artist { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MusicConfig());
            modelBuilder.ApplyConfiguration(new ArtistConfig());
        }
    }
}