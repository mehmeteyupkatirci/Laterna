using GPR.Laterna.DataAccess.Concrete.EntityFramework.Mappings;
using GPR.Laterna.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.DataAccess.Concrete.EntityFramework
{
    public class LaternaContext:DbContext
    {
        public LaternaContext()
        {
            Database.SetInitializer<LaternaContext>(null);
        }
         
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
