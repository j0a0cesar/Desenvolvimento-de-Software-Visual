/*Exercício 9 – Verificar se o número é par ou ímpar
Peça ao usuário um número inteiro. Mostre se ele é par ou ímpar.*/ 

namespace AulaDois
{ // nome do projeto
  public class Program
  { //sempre classe com letra maiuscula
    static void Main(string[] ars)
    {
      Console.WriteLine("Digite a sua nota (0 - 10): ");
      int nota = int.Parse(Console.ReadLine());
      
      if(nota >= 6){
        Console.WriteLine("Aprovado!");
      }
      else
      {
        Console.WriteLine("Reprovado!");
      }
    }
  }
}

