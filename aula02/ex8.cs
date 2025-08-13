/*Exercício 8 – Verificar se o aluno foi aprovado
Solicite a nota de um aluno (de 0 a 10). 
Se a nota for maior ou igual a 6, exiba "Aprovado",
 caso contrário, exiba "Reprovado".*/ 

namespace AulaDois
{
  public class Program
  {
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

