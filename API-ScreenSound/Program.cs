using (HttpClient client = new HttpClient())
{
    try //caminho feliz
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta); 
    }
    catch (Exception ex)
    {
     Console.WriteLine($"Temos um problema na API: {ex.Message}");
    }
        
}