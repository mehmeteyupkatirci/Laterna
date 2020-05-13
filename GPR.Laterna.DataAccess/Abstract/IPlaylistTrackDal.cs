using GPR.Core.DataAccess;
using GPR.Laterna.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.DataAccess.Abstract
{
    public interface IPlaylistTrackDal : IEntityRepository<PlaylistTrack>
    {
    }
}
