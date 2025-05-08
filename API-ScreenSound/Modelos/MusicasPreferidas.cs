using System.Text.Json;

namespace API_ScreenSound.Modelos;

internal class MusicasPreferidas
{
    public string Nome { get; set; }
    public List<Musica> listaDeMusicasFavorita;

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        listaDeMusicasFavorita = new List<Musica>();
    }
    public void AdicionarMusicasFavoritas(Musica musica)
    {
        listaDeMusicasFavorita.Add(musica);
    }
    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
        foreach (var musica in listaDeMusicasFavorita)
        {
            Console.WriteLine($"{musica.Nome} de {musica.Artista}");
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = listaDeMusicasFavorita
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo Json foi criado com sucesso!{Path.GetFullPath(nomeDoArquivo)}");
    }
}
