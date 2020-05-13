using GPR.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.Entities.Concrete
{
    public class UserProfile:IEntity
    {
        public long Id { get; set; }
        public long UserID { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
