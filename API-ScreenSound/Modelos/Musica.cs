
using System.Text.Json.Serialization;

namespace API_ScreenSound.Modelos
{
    internal class Musica
    {
        [JsonPropertyName("song")]//representa um metadado especifico para o nome
        public string? Nome {  get; set; }
        [JsonPropertyName("artist")]
        public string? Artista { get; set; }
        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }
        [JsonPropertyName("genre")]
        public string Genero { get; set; }

        public void ExibirDetalhesDaMusica()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Duração: {Duracao}");
            Console.WriteLine($"Genêro: {Genero}");
        }
    }
}
