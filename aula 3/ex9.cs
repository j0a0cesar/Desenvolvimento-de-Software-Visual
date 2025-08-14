/*
9. Aumentando Valores
Você tem uma lista de salários. 
Aplique um aumento de 10% a todos os salários menores que R$ 3000. 
Exiba o salários com 2 casas decimais
*/

namespace AulaDois
{ // nome do projeto
  public class Program
  { //sempre classe com letra maiuscula
    static void Main(string[] ars)
    {
        List<double> salarios = new List<double>
        {
            2500, 3700, 5000, 1200, 800
        };
        for (int index = 0; index < salarios.Count; index++)
        {
            if (salarios[index] < 3000)
            {
                salarios[index] *= 1.10;
                
            }
        }
        foreach (var item in salarios)
        {
            System.Console.WriteLine($"R$ {item:F2}");
        }
    }
  }
}

