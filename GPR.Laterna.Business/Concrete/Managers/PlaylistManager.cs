using GPR.Laterna.Business.Abstract;
using GPR.Laterna.DataAccess.Abstract;
using GPR.Laterna.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.Business.Concrete.Managers
{
    public class PlaylistManager : IPlaylistService
    {
        private IPlaylistDal _playlistDal;
        private IPlaylistTrackDal _playlistTrackDal;

        public PlaylistManager()
        {
            _playlistDal = DalFactory.CreatePlaylistDal();
            _playlistTrackDal = DalFactory.CreatePlaylistTrackDal();
        }

        public Playlist Add(Playlist playlist)
        {
            return _playlistDal.Add(playlist);
        }

        public void Delete(Playlist playlist)
        {
            _playlistDal.Delete(playlist);
        }

        public List<Playlist> GetAll()
        {
            return _playlistDal.GetList();
        }

        public Playlist GetById(long id)
        {
            return _playlistDal.Get(x => x.Id == id);
        }

        public List<Playlist> GetUserPlaylist(long userId)
        {
            return _playlistDal.GetList(x=>x.UserId==userId);
        }

        public bool PlaylistTracks(long playlistId, long trackId)
        {
            var obj = _playlistTrackDal.Get(x => x.PlaylistId == playlistId && x.TrackId == trackId);
            if (obj == null)
            {
                _playlistTrackDal.Add(new PlaylistTrack()
                {
                    PlaylistId = playlistId,
                    TrackId = trackId,
                    UpdatedAt = DateTime.Now,
                    CreatedAt = DateTime.Now
                });
                return true;
            }
            return false;
        }

        public Playlist Update(Playlist playlist)
        {
            return _playlistDal.Update(playlist);
        }
    }
}
