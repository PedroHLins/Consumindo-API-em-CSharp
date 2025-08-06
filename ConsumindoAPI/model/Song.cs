using System.Text.Json.Serialization;

namespace api.Model;

internal class Song
{
    private string[] tonalities = ["C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"];

    [JsonPropertyName("artist")]
    public string Artist { get; set; }
    [JsonPropertyName("song")]
    public string Name { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duration { get; set; }
    [JsonPropertyName("genre")]
    public string Genre { get; set; }
    [JsonPropertyName("year")]
    public string YearString { get; set; }
    [JsonPropertyName("key")]
    public int Key{ get; set; }
    public string Tonality
    {
        get
        {
            return tonalities[Key];
        }
    }

    public int Year
    {
        get
        {
            return int.Parse(YearString);
        }
    }

    public void DisplayDetails()
    {
        System.Console.WriteLine($"Artist: {Artist}");
        System.Console.WriteLine($"Music name: {Name}");
        System.Console.WriteLine($"Release year: {Year}");
        System.Console.WriteLine($"Genero: {Genre}");
        System.Console.WriteLine($"Duração: {Duration / 1000}s");
        System.Console.WriteLine($"Tonalidade: {Tonality}");
    }
}