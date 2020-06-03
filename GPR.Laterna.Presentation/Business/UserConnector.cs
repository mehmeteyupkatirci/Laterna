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
        public User Add(string email, string name, string password, string rePassword)
        {
            if (password != rePassword || password == "" || email == "" || name == "")
            {
                return null;
            }
            User user = new User();
            user.Password = password;
            user.Name = name;
            user.Email = email;
            user.UpdatedAt = DateTime.Now;
            user.CreatedAt = DateTime.Now;

            return _userService.Add(user);
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
        public bool LikedTrack(long userId, long trackId)
        {
            return _userService.LikeTrack(userId,trackId);
        }
        public bool FollowTrack(long userId, long trackId)
        {
            return _userService.FollowTrack(userId, trackId);
        }
        public bool LikedPlaylist(long userId, long playlistId)
        {
            return _userService.LikePlaylist(userId,playlistId);
        }
        public bool FollowedPlaylist(long userId, long playlistId)
        {
            return _userService.FollowPlaylist(userId, playlistId);
        }
        public List<UserLikedArtist> GetUserLikedArtists(long id)
        {
            return _userService.GetUserLikedArtists(id);
        }
        public List<UserFollowedArtist> GetUserFollowedArtists(long id)
        {
            return _userService.GetUserFollowedArtists(id);
        }
        public List<UserLikedAlbum> GetUserLikedAlbums(long id)
        {
            return _userService.GetUserLikedAlbums(id);
        }
        public List<UserFollowedAlbum> GetUserFollowedAlbums(long id)
        {
            return _userService.GetUserFollowedAlbums(id);
        }
        public List<UserLikedTrack> GetUserLikedTracks(long id)
        {
            return _userService.GetUserLikedTracks(id);
        }
        public List<UserFollowedTrack> GetUserFollowedTracks(long id)
        {
            return _userService.GetUserFollowedTracks(id);
        }
        public List<UserLikedPlaylist> GetUserLikedPlaylists(long id)
        {
            return _userService.GetUserLikedPlaylists(id);
        }
        public List<UserFollowedPlaylist> GetUserFollowedPlaylists(long id)
        {
            return _userService.GetUserFollowedPlaylists(id);
        }
        public void DeleteUserLikedArtist(long userLikedArtistId)
        {
            UserLikedArtist userLikedArtist = new UserLikedArtist();
            userLikedArtist.Id = userLikedArtistId;
            _userService.DeleteLikedArtist(userLikedArtist);
        }
        public void DeleteUserLikedAlbum(long userLikedAlbumId)
        {
            UserLikedAlbum userLikedAlbum = new UserLikedAlbum();
            userLikedAlbum.Id = userLikedAlbumId;
            _userService.DeleteLikedAlbum(userLikedAlbum);
        }
        public void DeleteUserLikedTrack(long userLikedTrackId)
        {
            UserLikedTrack userLikedTrack = new UserLikedTrack();
            userLikedTrack.Id = userLikedTrackId;
            _userService.DeleteLikedTrack(userLikedTrack);
        }
        public void DeleteUserLikedPlaylist(long userLikedPlaylistId)
        {
            UserLikedPlaylist userLikedPlaylist = new UserLikedPlaylist();
            userLikedPlaylist.Id = userLikedPlaylistId;
            _userService.DeleteLikedPlaylist(userLikedPlaylist);
        }
    }
}
