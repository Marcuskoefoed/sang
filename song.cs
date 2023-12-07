using System.Text;

namespace sang
{
    internal class Song : Stamp
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Length { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Artist> Artists { get; set; }

        public override string ToString()
        {
            return $"Title: {Title}\nGenre: {Genre}\nLength: {GetTimeFromSeconds()}\nRelease Date: {ReleaseDate:yyyy-MM-dd}\nArtists: {ShowArtists()}\n";
        }

        private string ShowArtists()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Artist artist in Artists)
            {
                sb.Append(artist);
            }
            return sb.ToString();
        }

        private TimeSpan GetTimeFromSeconds()
        {
            return TimeSpan.FromSeconds(Length);
        }
    }
}
