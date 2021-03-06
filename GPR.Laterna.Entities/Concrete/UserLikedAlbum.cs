﻿using GPR.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.Entities.Concrete
{
    public class UserLikedAlbum:IEntity
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long AlbumId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
