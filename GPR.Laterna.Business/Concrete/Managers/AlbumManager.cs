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
    public class AlbumManager : IAlbumService
    {
        private IAlbumDal _albumDal;

        public AlbumManager()
        {
            _albumDal = DalFactory.CreateAlbumDal();
        }
        public List<Album> GetAll()
        {
            return _albumDal.GetList();
        }

        public Album GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
