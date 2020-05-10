using GPR.Laterna.DataAccess.Abstract;
using GPR.Laterna.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.Business.Concrete
{
    public class DalFactory
    {
        public static IUserDal CreateUserDal()
        {
            return new EfUserDal();
        }
    }
}
