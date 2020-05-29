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
    public class ArtistManager : IArtistService
    {
        private IArtistDal _artistDal;

        public ArtistManager()
        {
            _artistDal = DalFactory.CreateArtistDal();
        }
        public List<Artist> GetAll()
        {
            return _artistDal.GetList();
        }

        public Artist GetById(long id)
        {
            return _artistDal.Get(x=>x.Id==id);
        }

        public List<Artist> GetTop()
        {
            var artists = _artistDal.GetList();
            var desc = artists.OrderByDescending(s => s.Popularity).Take(3).ToList();
            return desc;
        }
    }
}
