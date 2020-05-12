using GPR.Core.DataAccess.EntityFramework;
using GPR.Laterna.DataAccess.Abstract;
using GPR.Laterna.DataAccess.Concrete.EntityFramework;
using GPR.Laterna.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.DataAccess.Concrete
{
    public class EfPlaylistDal:EfEntityRepositoryBase<Playlist, LaternaContext>,IPlaylistDal
    {

    }
}
