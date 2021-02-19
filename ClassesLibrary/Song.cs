﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    class Song
    {
        //fields
        private string _artist;
        private string _title;
        private int _lengthInSeconds;

        //properties
        public string Artist { get; set; }
        public string Title { get; set; }
        public int LengthInSeconds { get; set; }

        //ctor
        public Song(string artist, string title, int lengthInSeconds)
        {
            Artist = artist;
            Title = title;
            LengthInSeconds = lengthInSeconds;
        }

        public Song()
        {

        }

        //methods
        public override string ToString()
        {
            return string.Format("Artist: {0}\n" +
                "Title: {1}\n" +
                "Length In Seconds: {2}\n", 
                Artist, Title, LengthInSeconds);
        }
    }
}
