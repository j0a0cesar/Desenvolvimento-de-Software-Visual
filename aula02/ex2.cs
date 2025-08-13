/*Exercício 2 – Conversa com o usuário
Peça para o usuário digitar sua idade, altura, e nome. 
Depois, exiba essas informações no console formatadas de forma amigável*/

namespace ExerciosCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura (em metros):");
            float altura = float.Parse(Console.ReadLine());

            Console.WriteLine($"Olá, {nome}! Você tem {idade} anos e {altura} metros de altura.");
        }
    }
}
