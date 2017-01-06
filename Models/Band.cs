using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Projekt.Models
{
    public class Band
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Debiut { get; set; }
        public DateTime End { get; set; }
        //public List<Artist> ActualArtists { get; set; }
        // public List<Artist> ExArtists { get; set; }
        public string Image { get; set; }
        //public List<Album> Albums { get; set; }
        // public List<Song> Songs { get; set; }
    }

    public class BandDbContext : DbContext
    {
        public DbSet<Band> Bands { get; set; }
    }
}