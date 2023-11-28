
using System.Text.Json.Serialization;

namespace TesteAPI.Modelos
{
    internal class Personagem
    {
        [JsonPropertyName("name")]
        public string? Nome { get; set; }
        [JsonPropertyName("gender")]
        public string? Genero { get; set; }
        [JsonPropertyName("culture")]
        public string? Cultura { get; set; }
        [JsonPropertyName("born")]
        public string? Nascimento { get; set; }
        [JsonPropertyName("died")]
        public string? Morte { get; set; }
        [JsonPropertyName("titles")]
        public List<string>? Títulos { get; set; }


        public void MostrarPersonagens()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Genero: {Genero}");
            Console.WriteLine($"Cultura: {Cultura}");
            Console.WriteLine($"Nascimento: {Nascimento}");
            Console.WriteLine($"Morto: {Morte}");
            Console.WriteLine($"Titulos: {Títulos}");
            foreach (string titulos in Títulos)
            {
                Console.WriteLine($"- {titulos}");
            }
        }

    }
}
