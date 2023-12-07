using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sang
{
    internal class PlaylistAndAlbum : Stamp
    {
        public string Title { get; set; }
        public List<Song> Songs { get; set; }
        public TimeSpan Time => GetLength();

        public PlaylistAndAlbum(string title, List<Song> songs)
        {
            Title = title;
            Songs = songs;
        }

        private TimeSpan GetLength()
        {
            int length = 0;
            foreach (var song in Songs)
            {
                length += song.Length;
            }
            return TimeSpan.FromSeconds(length);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"Title: {Title}\nLength: {Time}\nSongs:\n");
            foreach (Song song in Songs)
            {
                sb.Append(song.Title).Append("\n");
            }
            return sb.ToString();
        }
    }

}
