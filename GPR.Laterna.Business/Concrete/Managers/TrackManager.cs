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
    public class TrackManager : ITrackService
    {
        private ITrackDal _trackDal;
        public TrackManager()
        {
            _trackDal = DalFactory.CreateTrackDal();
        }
        public List<Track> GetAll()
        {
            return _trackDal.GetList();
        }

        public Track GetById(int id)
        {
            return _trackDal.Get(x => x.Id == id);
        }

        public List<Track> GetTop()
        {
            var tracks = _trackDal.GetList();
            var desc = tracks.OrderByDescending(s => s.Popularity).Take(3).ToList();
            return desc;
        }
    }
}
