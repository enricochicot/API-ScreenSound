using API_ScreenSound.Modelos;

namespace API_ScreenSound.Filtros
{
    internal class LinqOrder
    {
        public static void ExibirListaDeArtistaOrdenados(List<Musica>musicas)
        {
            var artistasOrdenadas = musicas.OrderBy(musica => musica.Artista)
                .Select(musica => musica.Artista).Distinct().ToList();
            Console.WriteLine("Lista de artistas ordenados");
            foreach(var artista in artistasOrdenadas)
            {
                Console.WriteLine($"- {artista}");
            }
        }
    }
}
