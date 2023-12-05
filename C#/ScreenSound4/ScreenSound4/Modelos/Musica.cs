using System.Text.Json.Serialization;

namespace ScreenSound4.Modelos;
internal class Musica
{
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
    }
}
