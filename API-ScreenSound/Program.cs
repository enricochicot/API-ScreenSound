using System.Text.Json;
using API_ScreenSound.Modelos;
using API_ScreenSound.Filtros;

using (HttpClient client = new HttpClient())
{
    try //caminho feliz
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistaOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michael Jackson");
    }
    catch (Exception ex)
    {
     Console.WriteLine($"Temos um problema na API: {ex.Message}");
    }
        
}