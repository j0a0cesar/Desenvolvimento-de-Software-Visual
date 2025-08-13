/*Exercício 10 – Verificar se pode entrar em uma festa
Um sistema de entrada de festa deve permitir apenas pessoas com idade igual ou maior que 18 e com convite. 
Solicite a idade e se a pessoa tem convite (true ou false). Exiba se a pessoa pode entrar ou não.*/ 

namespace AulaDois
{ // nome do projeto
  public class Program
  { //sempre classe com letra maiuscula
    static void Main(string[] ars)
    {
      Console.WriteLine("Digite a sua idade: ");
      int idade = int.Parse(Console.ReadLine());

      Console.WriteLine("Você tem convite (true ou false): ");
      bool convite = bool.Parse(Console.ReadLine());
      
      if(idade >= 18 && convite == true){
        Console.WriteLine("VOCÊ PODE ENTRAR!");
      }
      else
      {
        Console.WriteLine("VOCÊ NÃO PODE ENTRAR!");
      }
    }
  }
}

