﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Models
{
    public class Album
    {
        public int Id { get; set; }

        public int artistId { get; set; }
        public string Title { get; set; }

        public string Image { get; set; }

        public virtual Artist Artist { get; set; }

        public virtual List<Review> reviews { get; set; }
        public string recordLabel { get; set; }

        public virtual List<Song> songs { get; set; }
    }
}