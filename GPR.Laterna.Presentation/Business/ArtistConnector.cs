using GPR.Laterna.Business.Abstract;
using GPR.Laterna.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.Presentation.Business
{
    public class ArtistConnector
    {
        private IArtistService _artistService;

        public ArtistConnector()
        {
            _artistService = ManagerFactory.CreateArtistService();
        }

        public List<Artist> GetAll()
        {
            return _artistService.GetAll();
        }
        public Artist GetArtist(int artist)
        {
            return _artistService.GetById(artist);
        }
        
    }
}
