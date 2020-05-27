using GPR.Laterna.Business.Abstract;
using GPR.Laterna.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.Presentation.Business
{
    public class AlbumConnector
    {
        private IAlbumService _albumService;

        public AlbumConnector()
        {
            _albumService = ManagerFactory.CreateAlbumService();
        }

        public List<Album> GetAll()
        {
            return _albumService.GetAll();
        }
        public Album GetAlbum(int id)
        {
            return _albumService.GetById(id);
        }
    }
}
