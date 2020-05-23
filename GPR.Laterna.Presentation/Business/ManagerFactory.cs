using GPR.Laterna.Business.Abstract;
using GPR.Laterna.Business.Concrete.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.Presentation.Business
{
    public class ManagerFactory
    {
        public static IArtistService CreateArtistService()
        {
            return new ArtistManager();
        }
        public static IAlbumService CreateAlbumService()
        {
            return new AlbumManager();
        }
        public static ITrackService CreateTrackService()
        {
            return new TrackManager();
        }
    }
}
