/*
1. Playlist de Músicas Favoritas
Você tem uma lista de músicas que mais ouviu no último mês. Mostre todas as músicas na tela,
mas se a música for "Sweet Child O' Mine", exiba "Essa é lendária!" ao lado.
*/

namespace AulaDois
{ // nome do projeto
  public class Program
  { //sempre classe com letra maiuscula
    static void Main(string[] ars)
    {
        List<string> musicas = new List<string>
        {
            "Californication",
            "Hotel Califonia",
            "TNT",
            "Sweet Child O' Mine",
            "Iron main"
            
        };
        foreach (var musica in musicas)
        {
            if(musica == "Sweet Child O' Mine")
            {
                System.Console.WriteLine($"{musica}\nEssa é lendária!");
            }else
            {
                System.Console.WriteLine(musica);
            }
            
        }
    }
  }
}

