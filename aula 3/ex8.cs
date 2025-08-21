/*
8. Quantidade de Palavras com Mais de 5 Letras
Você tem uma lista de palavras. Conte quantas têm mais de 5 letras.
*/
namespace Csharp
{

    public class Program
    {
        static void Main(string[] args)
        {
            List<string> palavras = new List<string>
            {
                "Ciencia",
                "Computação",
                "Csharp",
                "C++",
                "Dotnet",
                "Fremework"
            };

            for (int index = 0; index < palavras.Count; index++)
            {
                if (palavras[index].Length > 5) {
                    System.Console.WriteLine($"{palavras[index]}");
                }
            }



            System.Console.WriteLine("");
        }
    }
}

