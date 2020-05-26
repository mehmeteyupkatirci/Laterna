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
    }
}
