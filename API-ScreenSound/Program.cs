using System.Text.Json;
using API_ScreenSound.Modelos;

using (HttpClient client = new HttpClient())
{
    try //caminho feliz
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[1998].ExibirDetalhesDaMusica();
    }
    catch (Exception ex)
    {
     Console.WriteLine($"Temos um problema na API: {ex.Message}");
    }
        
}