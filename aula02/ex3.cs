/*Exercício 3 – Tipos e operações
Crie duas variáveis inteiras chamadas a e b, com os valores 10 e 20. Some esses dois valores e exiba o resultado.
 Depois, crie duas variáveis do tipo double e faça o mesmo.*/

namespace ExerciosCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int somaInteiros = a + b;

            Console.WriteLine($"A soma de {a} e {b} é: {somaInteiros}");

            double x = 10.5;
            double y = 20.5;
            double somaDoubles = x + y;

            Console.WriteLine($"A soma de {x} e {y} é: {somaDoubles}");

        }
    }
}

