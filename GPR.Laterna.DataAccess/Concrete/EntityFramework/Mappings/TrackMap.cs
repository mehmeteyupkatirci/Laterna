using GPR.Laterna.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.DataAccess.Concrete.EntityFramework.Mappings
{
    public class TrackMap : EntityTypeConfiguration<Track>
    {
        public TrackMap()
        {
            ToTable(@"tracks", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("id");
            Property(x => x.SpotId).HasColumnName("spot_id");
            Property(x => x.AlbumId).HasColumnName("album_id");
            Property(x => x.Name).HasColumnName("name");
            Property(x => x.DiscNumber).HasColumnName("disc_number");
            Property(x => x.DurationMs).HasColumnName("duration_ms");
            Property(x => x.PreviewUrl).HasColumnName("preview_url");
            Property(x => x.Popularity).HasColumnName("popularity");
            Property(x => x.Images).HasColumnName("images");
            Property(x => x.CreatedAt).HasColumnName("created_at");
            Property(x => x.UpdatedAt).HasColumnName("updated_at");
        }
    }
}
