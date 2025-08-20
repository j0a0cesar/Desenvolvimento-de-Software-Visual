/*
7. Ranking de Pontuação de Jogadores
Você tem um ranking com pontuações de jogadores. Mostre quem fez mais de 500 pontos.

namespace Csharp
{

    public class Program
    {
        static void Main(string[] args)
        {
            List<int> ranking = new List<int>
            {
                350,1500, 1000, 450, 500,777
            };



            for (int index = 0; index < ranking.Count; index++)
            {
                if (ranking[index] > 500)
                {
                    System.Console.WriteLine($"Ranking: {ranking[index]}");
                }
            }
            System.Console.WriteLine("");
        }
    }
}
*/
namespace Csharp
{

    public class Program
    {
        public class Jogadores
        {
            public string Nome { get; set; }
            public int Ranking { get; set; }
        }
        static void Main(string[] args)
        {
            List<Jogadores> pontuacao = new List<Jogadores>
            {
                new Jogadores{Nome = "Ronaldo", Ranking = 2000 },
                new Jogadores{Nome = "Neymar", Ranking = 1450 },
                new Jogadores{Nome = "Tche Tche", Ranking = 399 },
                new Jogadores{Nome = "Depay", Ranking = 999 },
                new Jogadores{Nome = "Felix Tores", Ranking = 400 },
            };



            foreach(Jogadores jogador in pontuacao)
            {
                if (jogador.Ranking > 500)
                {
                    System.Console.WriteLine($"Nome: {jogador.Nome}");
                    System.Console.WriteLine($"Ranking: {jogador.Ranking}");
                }
            }
            System.Console.WriteLine("");
        }
    }
}
