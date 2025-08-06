using System.Globalization;
using System.Text.Json;
using api.Filter;
using api.Model;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musics = JsonSerializer.Deserialize<List<Song>>(response)!;

        LinqFilter.GenderFilter(musics);

        LinqFilter.ArtistSortFilter(musics);

        LinqFilter.MusicByYear(musics, 2000);

        LinqFilter.MusicByTonalityFilter(musics, "C#");

        System.Console.Write("Gender you would like to find artists: ");
        string gender = System.Console.ReadLine()!;
        LinqFilter.ArtistPerGenderFilter(musics, gender);

        System.Console.Write("Artist you would like to see the songs: ");
        string artist = System.Console.ReadLine()!;
        LinqFilter.MusicByArtistFilter(musics, artist);

        FavoriteSongs CleanHouse = new FavoriteSongs("Songs to clean the house");
        CleanHouse.AddSong(musics[523]);
        CleanHouse.AddSong(musics[31]);
        CleanHouse.AddSong(musics[991]);
        CleanHouse.AddSong(musics[2]);
        CleanHouse.AddSong(musics[0]);

        CleanHouse.DisplayFavoriteSongs();
        CleanHouse.GenerateJson();

    }
    catch (Exception e)
    {
        System.Console.WriteLine($"ERROR: {e.Message}");
    }
}