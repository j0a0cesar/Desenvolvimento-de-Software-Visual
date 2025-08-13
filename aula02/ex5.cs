/*Exercício 5 – Misturando tipos e concatenação
Declare as seguintes variáveis:
nome (string)
idade (int)
altura (double)
gostaDeProgramar (bool)
Depois, exiba no console uma frase como: "Olá, meu nome é João, tenho 30 anos,
1.80m de altura e é verdade que gosto de programar: True"*/

namespace ExerciosCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nome = "João";
            int idade = 19;
            double altura = 1.78;
            bool gostaDeProgrmar = true;

            Console.WriteLine("Olá, meu nome é " + nome + ", tenho " + idade + " anos, minha altura é " + altura + " metros e  na verdade que gsto de programar: " + gostaDeProgrmar);

            
        }
    }
}
