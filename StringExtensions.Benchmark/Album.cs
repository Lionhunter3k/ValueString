using System;
using System.Collections.Generic;
using System.Text;

namespace StringExtensions.Benchmark
{
    public class Album
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string AlbumArtUrl { get; set; }

        public string Title { get; set; }
        public decimal Price { get; set; }
        public Genre Genre { get; set; }
        public Artist Artist { get; set; }
    }
}
