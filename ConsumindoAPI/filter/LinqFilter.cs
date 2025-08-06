using api.Model;

namespace api.Filter;

internal class LinqFilter
{
    public static void GenderFilter(List<Song> songs)
    {
        var allGenders = songs.Select(m => m.Genre).Distinct().ToList();
        foreach (var genre in allGenders)
        {
            System.Console.WriteLine($"-> {genre}");
        }
    }

    public static void ArtistSortFilter(List<Song> songs)
    {
        var allArtists = songs.OrderBy(m => m.Artist).Select(m => m.Artist).Distinct().ToList();
        foreach (var artist in allArtists)
        {
            System.Console.WriteLine($"-> {artist}");
        }
    }

    public static void ArtistPerGenderFilter(List<Song> songs, string gender)
    {
        var artistPerGender = songs.Where(m => m.Genre.Contains(gender))
        .OrderBy(m => m.Artist).Select(m => m.Artist).Distinct().ToList();

        foreach (var artist in artistPerGender)
        {
            System.Console.WriteLine($"-> {artist}");
        }
    }

    public static void MusicByArtistFilter(List<Song> songs, string artist)
    {
        var MusicByArtist = songs.Where(m => m.Artist.Equals(artist))
        .Select(m => m.Name).ToList();

        System.Console.WriteLine($"songs by {artist}: ");
        foreach (var music in MusicByArtist)
        {
            System.Console.WriteLine($"-> {music}");
        }
    }

    public static void MusicByYear(List<Song> songs, int year)
    {
        var musicByYear = songs.OrderBy(m => m.Year)
        .Where(m => m.Year.Equals(year)).Select(m => m.Name).ToList();

        System.Console.WriteLine($"songs by {year}: ");
        foreach (var music in musicByYear)
        {
            System.Console.WriteLine($"-> {music}");
        }
    }

    public static void MusicByTonalityFilter(List<Song> songs, string key)
    {
        var musicByTonality = songs.Where(m => m.Tonality.Equals(key)).Select(m => m.Name).ToList();

        foreach (var music in musicByTonality)
        {
            System.Console.WriteLine($"-> {music}");
        }
    }
}