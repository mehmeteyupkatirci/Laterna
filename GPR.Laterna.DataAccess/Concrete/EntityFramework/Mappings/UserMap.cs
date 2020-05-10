using GPR.Laterna.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UserMap:EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable(@"users",@"dbo");
            HasKey(x=>x.Id);

            Property(x => x.Id).HasColumnName("id");
            Property(x => x.Name).HasColumnName("name");
            Property(x => x.Email).HasColumnName("email");
            Property(x => x.EmailVerifiedAt).HasColumnName("email_verified_at");
            Property(x => x.Password).HasColumnName("password");
            Property(x => x.RememberToken).HasColumnName("remember_token");
            Property(x => x.DeletedAt).HasColumnName("deleted_at");
            Property(x => x.CreatedAt).HasColumnName("created_at");
            Property(x => x.UpdatedAt).HasColumnName("updated_at");
        }
    }
}
