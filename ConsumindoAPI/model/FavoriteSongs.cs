using System.Text.Json;

namespace api.Model;

class FavoriteSongs
{
    public string Name { get; set; }
    public List<Song> Playlist { get; set; }

    public FavoriteSongs(string name)
    {
        Name = name;
        Playlist = new List<Song>();
    }

    public void AddSong(Song song)
    {
        Playlist.Add(song);
    }

    public void DisplayFavoriteSongs()
    {
        System.Console.WriteLine($"These are your playlist songs -> {Name} ");
        foreach (var musica in Playlist)
        {
            System.Console.WriteLine($"-> {musica.Name} By {musica.Artist}");
        }
    }

    public void GenerateJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            name = Name,
            songs = Playlist
        });
        string fileName = $"playlist-{Name}.json";

        File.WriteAllText(fileName, json);
        System.Console.WriteLine("Json was sucessfully created ");
    }
}