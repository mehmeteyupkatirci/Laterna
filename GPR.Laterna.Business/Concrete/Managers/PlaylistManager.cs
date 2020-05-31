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

        public PlaylistManager()
        {
            _playlistDal = DalFactory.CreatePlaylistDal();
        }
        public List<Playlist> GetAll()
        {
            return _playlistDal.GetList();
        }

        public Playlist GetById(long id)
        {
            return _playlistDal.Get(x => x.Id == id);
        }
    }
}
