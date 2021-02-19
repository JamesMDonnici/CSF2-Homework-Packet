using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    class Artist
    {
        //fields
        private Song[] _tracks;
        private string _title;
        private string _genre;

        //properties
        public Song[] Tracks { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        //ctors
        public Artist(Song[] tracks, string title, string genre)
        {
            Tracks = tracks;
            Title = title;
            Genre = genre;
        }

        public Artist()
        {

        }

        //methods
        public override string ToString()
        {
            return string.Format("Tracks: {0}\n" +
                "Title: {1}\n" +
                "Genre: {3}\n",
                Tracks, Title, Genre);
        }
    }
}
