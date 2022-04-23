using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MuSeek.Models
{
    internal class ArtistConfig : IEntityTypeConfiguration<Music>
    {
        public void Configure(EntityTypeBuilder<Music> entity)
        {
            entity.HasData(
                new Artist { ArtistId = 1, FirstName = "FirstName", LastName = "LastName" }
            );
        }
    }
}