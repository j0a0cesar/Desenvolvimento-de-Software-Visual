
namespace AulaDois
{ // nome do projeto
  public class Program
  { //sempre classe com letra maiuscula
    static void Main(string[] ars)
    {
        List<string> nomes = new List<string>
        {
            "Yuri",
            "Romero",
            "Garro",
            "Depay",
            "Hugo"
        };
        foreach (var nome in nomes)
        {
            System.Console.WriteLine(nome);
        }
    }
  }
}

