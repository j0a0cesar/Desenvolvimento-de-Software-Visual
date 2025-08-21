/*
10. Procurando um Item na Mochila
Você tem uma lista de itens da sua mochila para um acampamento. Pergunte ao usuário um item e diga se ele está na mochila.
*/
namespace Csharp
{

    public class Program
    {
        static void Main(string[] args)
        {
            List<string> mochila = new List<string>
            {
                "Lanterna",

                "Kit de primeiros socorros",

                "Água",

                "Frutas",

                "Comidas",

                "Barraca",

                "Colchão",

                "Roupas",

                "Capa de chuva",

                "Fósforo"
            };

            System.Console.WriteLine("Você tem água na mochila: (true/false)");
            bool agua = bool.Parse(Console.ReadLine());

            System.Console.WriteLine("Você colocou a barraca na mochila: (true/false)");
            bool barraca = bool.Parse(Console.ReadLine());

            System.Console.WriteLine("");

            if (mochila.Count < 1)
            {
                System.Console.WriteLine("Vai fazer mochila");
            }

            else if (agua != true)
            {
                System.Console.WriteLine("Vai pegar a água!");
            }
            else if (barraca != true)
            {
                System.Console.WriteLine("Vai dormir onde? Tem que pegar a barraca!");
            }
        
            System.Console.WriteLine("");
        }
    }
}

