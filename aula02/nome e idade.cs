//Entrada e Saida de dados

using System; // um item que permite a "impressão" da memsagem do Console...
class Program // precisa ter uma CLASSEdot
{
    static void Main ()
    {
        Console.WriteLine("Digite o seu nome: ");
        string nome = Console.ReadLine ();

        Console.WriteLine("Digite a sua idade: ");
        int idade = int.Parse(Console.ReadLine ());

        Console.WriteLine($"{nome} tem {idade} anos e está aprendendo C# "); //solução algoritma
    }
} 
