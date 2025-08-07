using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
Exercício 1 – Declarando variáveis simples
Crie um programa que declara as seguintes variáveis e exiba seus valores no console:

Um número inteiro representando a idade de uma pessoa.
Um número real representando a altura de uma pessoa.
Um caractere representando a inicial do nome da pessoa.
Um texto com o nome completo da pessoa.
Um valor booleano indicando se a pessoa está ativa.
*/

namespace primeiros_passos
{
    public class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();

            System.Console.WriteLine("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a inicial do seu nome: ");
            char inicial = char.Parse(Console.ReadLine());
            System.Console.WriteLine();

        }
    }
}
