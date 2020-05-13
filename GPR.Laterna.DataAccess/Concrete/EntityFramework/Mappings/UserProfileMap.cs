using GPR.Laterna.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UserProfileMap : EntityTypeConfiguration<UserProfile>
    {
        public UserProfileMap()
        {
            ToTable(@"user_profile", @"dbo");
            HasKey(x => x.Id);
            
            Property(x => x.UserID).HasColumnName("user_id");
            Property(x => x.Address).HasColumnName("address");
            Property(x => x.Phone).HasColumnName("phone");
            Property(x => x.Age).HasColumnName("age");
            Property(x => x.Gender).HasColumnName("gender");
            Property(x => x.CreatedAt).HasColumnName("created_at");
            Property(x => x.UpdatedAt).HasColumnName("updated_at");
        }
    }
}
