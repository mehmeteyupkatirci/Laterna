using GPR.Laterna.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ArtistMap:EntityTypeConfiguration<Artist>
    {
        public ArtistMap()
        {
            ToTable(@"artists", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("id");
            Property(x => x.Name).HasColumnName("name");
            Property(x => x.Genres).HasColumnName("genres");
            Property(x => x.Popularity).HasColumnName("popularity");
            Property(x => x.Images).HasColumnName("images");
            Property(x => x.Checked).HasColumnName("checked");
            Property(x => x.Searched).HasColumnName("searched");
            Property(x => x.SpotId).HasColumnName("spot_id");
            Property(x => x.CreatedAt).HasColumnName("created_at");
            Property(x => x.UpdatedAt).HasColumnName("updated_at");
        }
    }
}
