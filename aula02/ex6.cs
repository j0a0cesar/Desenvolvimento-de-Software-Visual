/*
Exercício 6 – Verificar se a pessoa é maior de idade
Crie um programa que peça a idade do usuário e verifique 
se ele é maior de idade (18 anos ou mais).
Exiba uma mensagem informando se a pessoa é maior ou menor de idade.
*/
namespace ExerciosCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade.");
            }
            else
            {
                Console.WriteLine("Você é menor de idade.");
            }   
            
        }
    }
}
