/*5. Contagem Regressiva de Lançamento
Você tem uma contagem regressiva para o lançamento de um jogo. Imprima os números de 10 até 1 usando for e no final escreva "Lançado!".*/

namespace Csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
        for (int index = 10; index >= 0; index--)
        {
            if (index == 0)
            {
                Console.WriteLine("Lançado!");
            }
            else
            {
                Console.WriteLine($"{index}");
            }
                
        }

        }
    }
}
