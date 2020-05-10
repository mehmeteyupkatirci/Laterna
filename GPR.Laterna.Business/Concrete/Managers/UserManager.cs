using GPR.Laterna.Business.Abstract;
using GPR.Laterna.DataAccess.Abstract;
using GPR.Laterna.DataAccess.Concrete.EntityFramework;
using GPR.Laterna.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.Business.Concrete.Managers
{
    public class UserManager : IUserService
    {

        private IUserDal _userDal;
        

        public UserManager()
        {
            _userDal = DalFactory.CreateUserDal();

        }


        public User Add(User user)
        {
            //first send mail
            //validation
            //log the info
            return _userDal.Add(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public List<User> GetAll()
        {
            return _userDal.GetList();
        }

        public User GetById(int id)
        {
            return _userDal.Get(x => x.Id == id);
        }

        public User Update(User user)
        {
            return _userDal.Update(user);
        }
    }
}
