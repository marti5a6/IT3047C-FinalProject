using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MuSeek.Models
{
    internal class MusicConfig : IEntityTypeConfiguration<Music>
    {
        public void Configure(EntityTypeBuilder<Music> entity)
        {
            entity.HasData(
                new Music { MusicId = 1, Title = "Song Title", Year = 2022, ArtistId = 1 }
            );
        }
    }
}