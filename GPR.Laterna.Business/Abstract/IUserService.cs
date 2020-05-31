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

        List<UserLikedArtist> GetUserLikedArtists(long id);
        List<UserFollowedArtist> GetUserFollowedArtists(long id);
        List<UserLikedAlbum> GetUserLikedAlbums(long id);
        List<UserFollowedAlbum> GetUserFollowedAlbums(long id);

        bool LikeArtist(long userId,long artistId);
        bool FollowArtist(long userId,long artistId);
        bool LikeAlbum(long userId, long albumId);
        bool FollowAlbum(long userId, long albumId);
        bool LikeTrack(long userId, long trackId);
        bool FollowTrack(long userId, long trackId);
    }
}
