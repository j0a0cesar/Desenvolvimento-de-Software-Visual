/*
2. Sistema de Aprovação de Notas
Uma turma fez uma prova e você tem as notas em uma lista. 
Exiba cada nota e diga se o aluno foi Aprovado (≥ 6.0) ou Reprovado (< 6.0).
*/

namespace AulaDois
{ // nome do projeto
  public class Program
  { //sempre classe com letra maiuscula
    static void Main(string[] ars)
    {
        List<double> notas = new List<double>
        {
            6.0,5.9,9.9,7.7,10.0
        };
        foreach (var nota in notas)
        {
            if(nota < 6.0)
            {
                System.Console.WriteLine($"A sua nota foi: {nota}\nReprovado!");
            }else
            {
                System.Console.WriteLine($"A sua nota foi: {nota}\nAprovado!");
            }
            
        }
    }
  }
}

