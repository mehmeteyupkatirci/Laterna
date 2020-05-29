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
        private IUserLikedArtistDal _userLikedArtistDal;

        public UserManager()
        {
            _userDal = DalFactory.CreateUserDal();
            _userLikedArtistDal = DalFactory.CreateUserLikedArtistDal();

        }
        public User Add(User user)
        {
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

        public bool LikeArtist(long userId, long artistId)
        {
            var obj = _userLikedArtistDal.Get(x => x.UserId == userId && x.ArtistId == artistId);
            if (obj == null)
            {
                _userLikedArtistDal.Add(new UserLikedArtist()
                {
                    ArtistId = artistId,
                    UserId = userId,
                    UpdatedAt = DateTime.Now,
                    CreatedAt = DateTime.Now
                });
                return true;
            }
            return false;
        }

        public User Login(string email, string password)
        {
            return _userDal.Get(x=>x.Email==email && x.Password == password);
        }

        public User Update(User user)
        {
            return _userDal.Update(user);
        }
    }
}
