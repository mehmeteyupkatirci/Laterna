using GPR.Laterna.Business.Abstract;
using GPR.Laterna.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.Presentation.Business
{
    public class PlaylistConnector
    {
        private IPlaylistService _playlistService;
        public PlaylistConnector()
        {
            _playlistService = ManagerFactory.CreatePlaylistService();
        }
        public List<Playlist> GetAll()
        {
            return _playlistService.GetAll();
        }
        public Playlist GetPlaylist(long playlistId)
        {
            return _playlistService.GetById(playlistId);
        }
        public List<Playlist> GetUserPlaylists(long userId)
        {
            return _playlistService.GetUserPlaylist(userId);
        }
        public bool AddPlaylistTrack(long userId, long playlistId)
        {
            return _playlistService.PlaylistTracks(userId, playlistId);
        }
        public Playlist AddPlaylist(string playlistName, string playlistDescription, bool isPublic)
        {
            Playlist playlist = new Playlist();
            playlist.Name = playlistName;
            playlist.Public = isPublic;
            playlist.Description = playlistDescription;
            playlist.CreatedAt = DateTime.Now;
            playlist.UserId = Properties.Settings.Default.User.Id;
            playlist.UpdatedAt = DateTime.Now;
            return _playlistService.Add(playlist);
        }
        public Playlist UpdatePlaylist(string playlistName, string playlistDescription, bool isPublic,long playlistId)
        {
            Playlist playlist = new Playlist();
            playlist.Id = playlistId;
            playlist.Name = playlistName;
            playlist.Public = isPublic;
            playlist.Description = playlistDescription;
            playlist.CreatedAt = DateTime.Now;
            playlist.UserId = Properties.Settings.Default.User.Id;
            playlist.UpdatedAt = DateTime.Now;
            return _playlistService.Update(playlist);
        }
        public void DeletePlaylist(long playlistId)
        {
            Playlist playlist = new Playlist();
            playlist.Id = playlistId;
            _playlistService.Delete(playlist);
        }
    }
}
