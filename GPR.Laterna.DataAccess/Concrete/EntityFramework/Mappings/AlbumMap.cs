using GPR.Laterna.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.DataAccess.Concrete.EntityFramework.Mappings
{
    public class AlbumMap : EntityTypeConfiguration<Album>
    {
        public AlbumMap()
        {
            ToTable(@"albums", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("id");
            Property(x => x.ArtistId).HasColumnName("artist_id");
            Property(x => x.AlbumTypeId).HasColumnName("album_type_id");
            Property(x => x.Name).HasColumnName("name");
            Property(x => x.SpotId).HasColumnName("spot_id");
            Property(x => x.Copyrights).HasColumnName("copyrights");
            Property(x => x.Popularity).HasColumnName("popularity");
            Property(x => x.ReleaseData).HasColumnName("release_date");
            Property(x => x.Images).HasColumnName("images");
            Property(x => x.Checked).HasColumnName("checked");
            Property(x => x.CreatedAt).HasColumnName("created_at");
            Property(x => x.UpdatedAt).HasColumnName("updated_at");
        }
    }
}
