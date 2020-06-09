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

        private IArtistDal _artistDal;
        private IAlbumDal _albumDal;
        private ITrackDal _trackDal;
        private IPlaylistDal _playlistDal;
        private IUserLikedArtistDal _userLikedArtistDal;
        private IUserFollowedArtistDal _userFollowedArtistDal;

        private IUserFollowedAlbumDal _userFollowedAlbumDal;
        private IUserLikedAlbumDal _userLikedAlbumDal;

        private IUserLikedTrackDal _userLikedTrackDal;
        private IUserFollowedTrackDal _userFollowedTrackDal;

        private IUserLikedPlaylistDal _userLikedPlaylistDal;
        private IUserFollowedPlaylistDal _userFollowedPlaylistDal;

        public UserManager()
        {
            _userDal = DalFactory.CreateUserDal();
            _userLikedArtistDal = DalFactory.CreateUserLikedArtistDal();
            _userFollowedArtistDal = DalFactory.CreateUserFollowedArtistDal();
            _userFollowedAlbumDal = DalFactory.CreateUserFollowedAlbumDal();
            _userLikedAlbumDal = DalFactory.CreateUserLikedAlbumDal();
            _userFollowedTrackDal = DalFactory.CreateUserFollowedTrackDal();
            _userLikedTrackDal = DalFactory.CreateUserLikedTrackDal();
            _userFollowedPlaylistDal = DalFactory.CreateUserFollowedPlaylistDal();
            _userLikedPlaylistDal = DalFactory.CreateUserLikedPlaylistDal();
            _artistDal = DalFactory.CreateArtistDal();
            _albumDal = DalFactory.CreateAlbumDal();
            _trackDal = DalFactory.CreateTrackDal();
            _playlistDal = DalFactory.CreatePlaylistDal();
        }
        public User Add(User user)
        {
            return _userDal.Add(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public void DeleteFollowedAlbum(UserFollowedAlbum userFollowedAlbum)
        {
            _userFollowedAlbumDal.Delete(userFollowedAlbum);
        }

        public void DeleteFollowedArtist(UserFollowedArtist userFollowedArtist)
        {
            _userFollowedArtistDal.Delete(userFollowedArtist);
        }

        public void DeleteFollowedPlaylist(UserFollowedPlaylist userFollowedPlaylist)
        {
            _userFollowedPlaylistDal.Delete(userFollowedPlaylist);
        }

        public void DeleteFollowedTrack(UserFollowedTrack userFollowedTrack)
        {
            _userFollowedTrackDal.Delete(userFollowedTrack);
        }

        public void DeleteLikedAlbum(UserLikedAlbum userLikedAlbum)
        {
            _userLikedAlbumDal.Delete(userLikedAlbum);
        }

        public void DeleteLikedArtist(UserLikedArtist userLikedArtist)
        {
            _userLikedArtistDal.Delete(userLikedArtist);
        }

        public void DeleteLikedPlaylist(UserLikedPlaylist userLikedPlaylist)
        {
            _userLikedPlaylistDal.Delete(userLikedPlaylist);
        }

        public void DeleteLikedTrack(UserLikedTrack userLikedTrack)
        {
            _userLikedTrackDal.Delete(userLikedTrack);
        }

        public bool FollowAlbum(long userId, long albumId)
        {
            var obj = _userFollowedAlbumDal.Get(x => x.UserId == userId && x.AlbumId == albumId);
            if (obj == null)
            {
                _userFollowedAlbumDal.Add(new UserFollowedAlbum()
                {
                    AlbumId = albumId,
                    UserId = userId,
                    UpdatedAt = DateTime.Now,
                    CreatedAt = DateTime.Now
                });
                return true;
            }
            return false;
        }

        public bool FollowArtist(long userId, long artistId)
        {
            var obj = _userFollowedArtistDal.Get(x => x.UserId == userId && x.ArtistId == artistId);
            if (obj == null)
            {
                _userFollowedArtistDal.Add(new UserFollowedArtist()
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

        public bool FollowPlaylist(long userId, long playlistId)
        {
            var obj = _userFollowedPlaylistDal.Get(x => x.UserId == userId && x.PlaylistId == playlistId);
            if (obj == null)
            {
                _userFollowedPlaylistDal.Add(new UserFollowedPlaylist()
                {
                    PlaylistId = playlistId,
                    UserId = userId,
                    UpdatedAt = DateTime.Now,
                    CreatedAt = DateTime.Now
                });
                return true;
            }
            return false;
        }

        public bool FollowTrack(long userId, long trackId)
        {
            var obj = _userFollowedTrackDal.Get(x => x.UserId == userId && x.TrackId == trackId);
            if (obj == null)
            {
                _userFollowedTrackDal.Add(new UserFollowedTrack()
                {
                    TrackId = trackId,
                    UserId = userId,
                    UpdatedAt = DateTime.Now,
                    CreatedAt = DateTime.Now
                });
                return true;
            }
            return false;
        }

        public List<User> GetAll()
        {
            return _userDal.GetList();
        }

        public User GetById(int id)
        {
            return _userDal.Get(x => x.Id == id);
        }

        public List<UserFollowedAlbum> GetUserFollowedAlbums(long id)
        {
           
            return _userFollowedAlbumDal.GetList(x=>x.UserId == id);
        }

        public List<UserFollowedArtist> GetUserFollowedArtists(long id)
        {
            return _userFollowedArtistDal.GetList(x=>x.UserId == id);
        }

        public Artist GetFollowedArtistName(long id)
        {
            var userFollowedArtist = _userFollowedArtistDal.Get(x => x.Id == id);
            var artist = _artistDal.Get(x => x.Id == userFollowedArtist.ArtistId);
            return artist;
        }

        public List<UserFollowedPlaylist> GetUserFollowedPlaylists(long id)
        {
            return _userFollowedPlaylistDal.GetList(x=>x.UserId == id);
        }

        public List<UserFollowedTrack> GetUserFollowedTracks(long id)
        {
            return _userFollowedTrackDal.GetList(x=>x.UserId==id);
        }

        public List<UserLikedAlbum> GetUserLikedAlbums(long id)
        {
            return _userLikedAlbumDal.GetList(x => x.UserId == id);
        }

        public List<UserLikedArtist> GetUserLikedArtists(long id)
        {
            return _userLikedArtistDal.GetList(x=>x.UserId == id);
        }

        public List<UserLikedPlaylist> GetUserLikedPlaylists(long id)
        {
            return _userLikedPlaylistDal.GetList(x=> x.UserId == id);
        }

        public List<UserLikedTrack> GetUserLikedTracks(long id)
        {
            return _userLikedTrackDal.GetList(x=>x.UserId == id);
        }

        public bool LikeAlbum(long userId, long albumId)
        {
            var obj = _userLikedAlbumDal.Get(x => x.UserId == userId && x.AlbumId == albumId);
            if (obj == null)
            {
                _userLikedAlbumDal.Add(new UserLikedAlbum()
                {
                    AlbumId = albumId,
                    UserId = userId,
                    UpdatedAt = DateTime.Now,
                    CreatedAt = DateTime.Now
                });
                return true;
            }
            return false;
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

        public bool LikePlaylist(long userId, long playlistId)
        {
            var obj = _userLikedPlaylistDal.Get(x => x.UserId == userId && x.PlaylistId == playlistId);
            if (obj == null)
            {
                _userLikedPlaylistDal.Add(new UserLikedPlaylist()
                {
                    PlaylistId = playlistId,
                    UserId = userId,
                    UpdatedAt = DateTime.Now,
                    CreatedAt = DateTime.Now
                });
                return true;
            }
            return false;
        }

        public bool LikeTrack(long userId, long trackId)
        {
            var obj = _userLikedTrackDal.Get(x => x.UserId == userId && x.TrackId == trackId);
            if (obj == null)
            {
                _userLikedTrackDal.Add(new UserLikedTrack()
                {
                    TrackId = trackId,
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

        public Album GetFollowedAlbumName(long id)
        {
            var userFollowedAlbum = _userFollowedAlbumDal.Get(x => x.Id == id);
            var album = _albumDal.Get(x => x.Id == userFollowedAlbum.AlbumId);
            return album;
        }

        public Track GetFollowedTrackName(long id)
        {
            var userFollowedTrack = _userFollowedTrackDal.Get(x => x.Id == id);
            var track = _trackDal.Get(x => x.Id == userFollowedTrack.TrackId);
            return track;
        }

        public Playlist GetFollowedPlaylistName(long id)
        {
            var userFollowedPlaylist = _userFollowedPlaylistDal.Get(x => x.Id == id);
            var playlist = _playlistDal.Get(x => x.Id == userFollowedPlaylist.PlaylistId);
            return playlist;
        }
    }
}
