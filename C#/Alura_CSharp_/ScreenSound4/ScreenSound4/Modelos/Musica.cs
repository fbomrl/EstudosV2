using System.Text.Json.Serialization;

namespace ScreenSound4.Modelos;
internal class Musica
{
    private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("year")]
    public string? StringAno { get; set; }
    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tonalidade { 
        get 
        {
            return tonalidades[Key];
        } 
    }
    public int Ano
    {
        get
        {
            return int.Parse(StringAno!);
        }
    }



    public void ExibirDetalhesdaMusica()
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Duracao: {Duracao / 1000} segundos");
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }
}
