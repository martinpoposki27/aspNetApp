using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace albumsMVC.Models
{
    public class AlbumDto
    {
        public int Id { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }
        public string Name { get; set; }
    }
}