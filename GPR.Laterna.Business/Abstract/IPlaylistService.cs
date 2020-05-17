using GPR.Laterna.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.Business.Abstract
{
    public interface IPlaylistService
    {
        List<Playlist> GetAll();
        Playlist GetById(int id);
    }
}
