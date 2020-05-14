using GPR.Laterna.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UserFollowedAlbumMap : EntityTypeConfiguration<UserFollowedAlbum>
    {
        public UserFollowedAlbumMap()
        {
            ToTable(@"user_followed_albums", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("id");
            Property(x => x.UserId).HasColumnName("user_id");
            Property(x => x.AlbumId).HasColumnName("album_id");
            Property(x => x.CreatedAt).HasColumnName("created_at");
            Property(x => x.UpdatedAt).HasColumnName("updated_at");
        }
    }
}
