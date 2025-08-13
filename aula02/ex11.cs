/*Exercício 11 – Verificar números pares e ímpares
Use um loop for para percorrer os números de 1 a 10. Para cada número, mostre se ele é par ou ímpar.*/ 

namespace AulaDois
{ // nome do projeto
  public class Program
  { //sempre classe com letra maiuscula
    static void Main(string[] ars)
    {

        for (int index = 0; index <= 10; index++)
        {
            if( index % 2 ==  0){
             Console.WriteLine($"{index} = PAR");
            }
            else{
             Console.WriteLine($"{index} = ÍMPAR");
            }
        }
    }
  }
}

