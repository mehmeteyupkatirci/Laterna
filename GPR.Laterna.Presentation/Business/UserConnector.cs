using GPR.Laterna.Business.Abstract;
using GPR.Laterna.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.Presentation.Business
{
    public class UserConnector
    {
        private IUserService _userService;
        public UserConnector()
        {
            _userService = ManagerFactory.CreateUserService();
        }
        public User Login(string email, string password)
        {
            return _userService.Login(email, password);
        }
        public User Update(string email, string name, string password,string rePassword)
        {
            if(password != rePassword || password=="" || email =="" || name=="" )
            {
                return null;
            }
            User user = Properties.Settings.Default.User;
            user.Password = password;
            user.Name = name;
            user.Email = email;
            user.UpdatedAt = DateTime.Now;

            return _userService.Update(user);
        }
        public bool LikedArtist(long userId, long artistId)
        {
           return _userService.LikeArtist(userId,artistId);
        }
        public bool FollowArtist(long userId, long artistId)
        {
            return _userService.FollowArtist(userId, artistId);
        }
        public bool LikedAlbum(long userId, long albumId)
        {
            return _userService.LikeAlbum(userId, albumId);
        }
        public bool FollowAlbum(long userId, long albumId)
        {
            return _userService.FollowAlbum(userId, albumId);
        }
    }
}
