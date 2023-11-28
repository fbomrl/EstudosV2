using System.Text.Json;
using TesteAPI.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://anapioficeandfire.com/api/characters/");
        var personagens = JsonSerializer.Deserialize<List<Personagem>>(resposta)!;
        personagens[7].MostrarPersonagens();
        Console.WriteLine("\n" + personagens.Count);

    } catch (Exception ex)
    {
        Console.WriteLine("Deu ruim: "+ ex.Message);
    }
}