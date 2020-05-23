using GPR.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.Entities.Concrete
{
    public class Track:IEntity
    {
        public long Id { get; set; }
        public string SpotId { get; set; }
        public long AlbumId { get; set; }
        public string Name { get; set; }
        public string DiscNumber { get; set; }
        public string DurationMs { get; set; }
        public string PreviewUrl { get; set; }
        public int? Popularity { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
