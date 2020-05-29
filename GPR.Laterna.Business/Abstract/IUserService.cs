using GPR.Laterna.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetById(int id);
        User Login(string email,string password);
        User Add(User user);
        User Update(User user);
        void Delete(User user);
        bool LikeArtist(long userId,long artistId);
    }
}
