/*Exercício 12 – Contar quantos nomes começam com uma letra
Peça ao usuário para digitar 5 nomes. Para cada nome, verifique se ele começa com a letra "A" (maiúscula). 
o final, mostre quantos nomes começam com "A".*/ 

namespace AulaDois
{ // nome do projeto
  public class Program
  { //sempre classe com letra maiuscula
    static void Main(string[] ars)
    {
        int contador = 0;
        Console.WriteLine("Digite 5 nome:");
       for (int index = 1; index <= 5; index++)
        {
            Console.WriteLine($"{index} nome: ");
            string nome = Console.ReadLine();

            
            if(nome.StartsWith("A")){
                contador++;
            }
        } 
        System.Console.WriteLine($"\nA quantidade de nomes que começão com letra A: {contador}");
    }
  }
}

