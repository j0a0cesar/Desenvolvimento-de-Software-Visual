/*
6. Lista de Compras com Preços
Você tem uma lista de itens e seus preços correspondentes. 
Mostre todos e destaque aqueles que custam mais que R$ 50 com a mensagem "Item caro".

//com dicionario

namespace Csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> compras = new Dictionary<string, double>
            {
                { "Tomate", 6.45},
                { "Arroz", 25.50 },
                { "Picanha", 80.00 },
                { "Azeite de Oliva", 55.75 },
                { "Chocolate", 15.00 }
            };

            System.Console.WriteLine("--- Lista de Compras (Dictionary) ---");

            // Para cada "par" (Key/Value) dentro do dicionário "compras"...
            foreach (KeyValuePair<string, double> par in compras)
            {
                // Acessamos o nome com par.Key e o preço com par.Value
                string nomeDoItem = par.Key;
                double precoDoItem = par.Value;



                // A lógica do if é em cima do preço (par.Value)
                if (precoDoItem > 50)
                {
                    System.Console.WriteLine("\n--- Item caro! --- ");
                    System.Console.WriteLine($"Nome: {nomeDoItem} | Preço: R${precoDoItem}");
                    System.Console.WriteLine("-------------------\n");
                }
                else
                {
                    System.Console.WriteLine($"Nome: {nomeDoItem} | Preço: R${precoDoItem}");
                }
            }
        }
    }
}
*/
namespace Csharp
{

    public class Itens
    {
        public string Nome{ get; set; }
        public double Preco{ get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Itens> compras = new List<Itens>
            {
                new Itens{Nome = "Tomate", Preco = 7.50},
                new Itens{Nome = "Arroz  5kg", Preco = 20.10},
                new Itens{Nome = "Pão de Alho", Preco = 21.45},
                new Itens{Nome = "Picnha", Preco = 79.00},
                new Itens{Nome = "Paleta", Preco = 49.90}
            };

            System.Console.WriteLine("--- PRODUTOS ---");
            foreach (Itens item in compras)
            {
                if (item.Preco > 50.00)
                {
                    System.Console.WriteLine("\n--- Item caro! --- ");
                    System.Console.WriteLine($"Nome: {item.Nome} | Preço: R${item.Preco}");
                    System.Console.WriteLine("-------------------\n");
                }
                else
                {
                    System.Console.WriteLine($"Nome: {item.Nome} | Preço: R${item.Preco}");
                }
            }

        }
    }
}
