/*
4. Filtro de Nomes com Letra 'A'
Crie uma lista de nomes de amigos. Mostre apenas os que começam com a letra A.
*/


namespace Csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> amigos = new List<string>
            { "Alex", "Bruno", "Ana", "Carlos", "Alice" };

            for (int i = 0; i < amigos.Count; i++)
            {
                if (amigos[i].StartsWith("A"))
                {
                    System.Console.WriteLine($"Esses são os amigos que começam com a letra A: {amigos[i]}");
                }
            }

        }
    }
}
