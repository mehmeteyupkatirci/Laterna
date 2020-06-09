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

        void DeleteLikedArtist(UserLikedArtist userLikedArtist);
        void DeleteLikedAlbum(UserLikedAlbum userLikedAlbum);
        void DeleteLikedTrack(UserLikedTrack userLikedTrack);
        void DeleteLikedPlaylist(UserLikedPlaylist userLikedPlaylist);

        void DeleteFollowedArtist(UserFollowedArtist userFollowedArtist);
        void DeleteFollowedAlbum(UserFollowedAlbum userFollowedAlbum);
        void DeleteFollowedTrack(UserFollowedTrack userFollowedTrack);
        void DeleteFollowedPlaylist(UserFollowedPlaylist userFollowedPlaylist);
                   
        List<UserLikedArtist> GetUserLikedArtists(long id);
        List<UserFollowedArtist> GetUserFollowedArtists(long id);
        List<UserLikedAlbum> GetUserLikedAlbums(long id);
        List<UserFollowedAlbum> GetUserFollowedAlbums(long id);
        List<UserLikedTrack> GetUserLikedTracks(long id);
        List<UserFollowedTrack> GetUserFollowedTracks(long id);
        List<UserFollowedPlaylist> GetUserFollowedPlaylists(long id);
        List<UserLikedPlaylist> GetUserLikedPlaylists(long id);
        
        Artist GetFollowedArtistName(long id);
        Album GetFollowedAlbumName(long id);
        Track GetFollowedTrackName(long id);
        Playlist GetFollowedPlaylistName(long id);

        Artist GetLikedArtistName(long id);
        Album GetLikedAlbumName(long id);
        Track GetLikedTrackName(long id);
        Playlist GetLikedPlaylistName(long id);

        bool LikeArtist(long userId,long artistId);
        bool FollowArtist(long userId,long artistId);
        bool LikeAlbum(long userId, long albumId);
        bool FollowAlbum(long userId, long albumId);
        bool LikeTrack(long userId, long trackId);
        bool FollowTrack(long userId, long trackId);
        bool LikePlaylist(long userId, long playlistId);
        bool FollowPlaylist(long userId, long playlistId);
    }
}
