using System;
using System.Collections.Generic;

namespace sang
{
    internal class Program
    {
        static List<Artist> artists = new List<Artist>();
        static List<Song> songs = new List<Song>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add Artist");
                Console.WriteLine("2. Add Song");
                Console.WriteLine("3. View All Songs");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddArtist();
                        break;
                    case "2":
                        AddSong();
                        break;
                    case "3":
                        ViewAllSongs();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddArtist()
        {
            Console.Write("Enter Artist Name: ");
            string artistName = Console.ReadLine();

            Console.Write("Enter Artist Country: ");
            string country = Console.ReadLine();

            Console.Write("Enter Artist Birthday (yyyy-MM-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime birthday))
            {
                Artist artist = new Artist
                {
                    ArtistName = artistName,
                    Country = country,
                    Birthday = birthday
                };
                artists.Add(artist);
                Console.WriteLine("Artist added successfully!\n");
            }
            else
            {
                Console.WriteLine("Invalid date format. Artist not added.\n");
            }
        }

        static void AddSong()
        {
            Console.Write("Enter Song Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Song Genre: ");
            string genre = Console.ReadLine();

            Console.Write("Enter Song Length (seconds): ");
            if (int.TryParse(Console.ReadLine(), out int length))
            {
                Console.Write("Enter Release Date (yyyy-MM-dd): ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime releaseDate))
                {
                    Console.Write("Enter Artist Name: ");
                    string artistName = Console.ReadLine();

                    Artist artist = artists.Find(a => a.ArtistName.Equals(artistName, StringComparison.OrdinalIgnoreCase));
                    if (artist != null)
                    {
                        Song song = new Song
                        {
                            Title = title,
                            Genre = genre,
                            Length = length,
                            ReleaseDate = releaseDate,
                            Artists = new List<Artist> { artist }
                        };
                        songs.Add(song);
                        Console.WriteLine("Song added successfully!\n");
                    }
                    else
                    {
                        Console.WriteLine("Artist not found. Song not added.\n");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid date format. Song not added.\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid length format. Song not added.\n");
            }
        }

        static void ViewAllSongs()
        {
            Console.WriteLine("\nAll Songs:\n");
            foreach (var song in songs)
            {
                Console.WriteLine(song);
            }
            Console.WriteLine();
        }
    }
}
