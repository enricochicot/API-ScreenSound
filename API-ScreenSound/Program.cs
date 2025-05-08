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
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michael Jackson");


        var musicasPreferidasDoEnrico = new MusicasPreferidas("Enrico");
        musicasPreferidasDoEnrico.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidasDoEnrico.AdicionarMusicasFavoritas(musicas[5]);
        musicasPreferidasDoEnrico.AdicionarMusicasFavoritas(musicas[66]);
        musicasPreferidasDoEnrico.AdicionarMusicasFavoritas(musicas[768]);
        musicasPreferidasDoEnrico.AdicionarMusicasFavoritas(musicas[324]);
        musicasPreferidasDoEnrico.ExibirMusicasFavoritas();
        musicasPreferidasDoEnrico.GerarArquivoJson();
    }
    catch (Exception ex)
    {
     Console.WriteLine($"Temos um problema na API: {ex.Message}");
    }
        
}