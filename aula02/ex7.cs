/*Exercício 7 – Verificar número positivo ou negativo
Peça para o usuário digitar um número inteiro. 
Mostre na tela se ele é positivo, negativo ou zero.*/

namespace ExerciosCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num> 0)
            {
                Console.WriteLine("O número que você digitou é positivo.");
            }
            else if (num == 0)
            {
                Console.WriteLine("O número que você digitou é igual a zero.");
            }
            else
            {
                Console.WriteLine("O número que você digitou é negativo.");
            }   
            
        }
    }
}

