using GPR.Laterna.Business.Abstract;
using GPR.Laterna.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.Presentation.Business
{
    public class TrackConnector
    {
        private ITrackService _trackService;
        public TrackConnector()
        {
            _trackService = ManagerFactory.CreateTrackService();
        }
        public List<Track> GetAll()
        {
            return _trackService.GetAll();
        }
    }
}
