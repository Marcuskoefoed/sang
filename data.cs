using sang;
using Sang;
using System;
using System.Collections.Generic;

namespace Sang
{
    internal class Data
    {
        public static List<Song> Songs { get; set; } = new();
        public static List<Artist> Artists { get; set; } = new();
        public static List<PlaylistAndAlbum> Playlists { get; set; } = new();

        public static void AddData()
        {
            Artist a1 = new Artist();
            a1.ArtistName = "Michael Jackson";
            a1.Birthday = new DateTime(1973, 12, 7);
            a1.User = "Daniel";
            a1.Country = "US";
            Artists.Add(a1);

            Artist a2 = new Artist()
            {
                ArtistName = "Lil Nas X",
                Birthday = new DateTime(1999, 11, 3),
                User = a1.User,
                Country = a1.Country
            };
            Artists.Add(a2);

            Console.WriteLine(a1);

            Song s1 = new Song()
            {
                Title = "Stay With Me",
                Genre = "Pip Roeggae",
                Length = 225,
                ReleaseDate = new(1984, 12, 1),
                Artists = new List<Artist>() { a1, a2 },
                User = "Fans"
            };

            Song s2 = new Song()
            {
                Title = "Stay With Me Pt2",
                Genre = "Pip Roeggae",
                Length = 215,
                ReleaseDate = new(1985, 12, 1),
                Artists = new List<Artist>() { a1, a2 },
                User = "Fans"
            };
            //Songs.AddRange(new List<Song>() { s1, s2 });

            PlaylistAndAlbum p1 = new("Bedroom", new List<Song>() { s1, s2 });

            Playlists.Add(p1);
        }
    }
}
