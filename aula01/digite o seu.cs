//Entrada e Saida de dados

using System; // um item que permite a "impressão" da memsagem do Console...
class Program // precisa ter uma CLASSEdot
{
    static void Main ()
    {
        Console.WriteLine("Digite o seu nome: ");
        string nome = Console.ReadLine ();

        Console.WriteLine($"Olá {nome} seja bem vindo ao C# "); //solução algoritma
    }
} 

