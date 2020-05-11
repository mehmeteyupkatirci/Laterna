using GPR.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.Entities.Concrete
{
    public class Album:IEntity
    {
        public long Id { get; set; }
        public long ArtistId { get; set; }
        public long AlbumTypeId { get; set; }
        public string Name { get; set; }
        public string SpotId { get; set; }
        public string Copyrights { get; set; }
        public string Genres { get; set; }
        public int Popularity { get; set; }
        public string ReleaseData { get; set; }
        public string Images { get; set; }
        public string Checked { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
