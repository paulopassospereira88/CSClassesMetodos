Console.WriteLine("Basico de Metodos");

var minhaClasse = new MinhaClasse();

minhaClasse.Saudacao("Paulo", DateTime.Now);

Console.ReadKey();

class MinhaClasse
{
    public void Saudacao(string nome, DateTime data)
    {
        Console.WriteLine($"Bem-Vindo {nome}");
        Console.WriteLine(data);
    }

}
