Console.WriteLine("Construtor estatico");

Pessoa p1 = new Pessoa("Paulo", 35);
Console.WriteLine(p1.Nome +" - "+ p1.Idade);
Console.WriteLine("Idade minima " +Pessoa.IdadeMinima);

Pessoa p2 = new Pessoa("Jose", 45);
Console.WriteLine(p2.Nome + " - " + p2.Idade);
Console.WriteLine("Idade minima " + Pessoa.IdadeMinima);

public class Pessoa
{
    public static int IdadeMinima;
    public string Nome { get; set; } = string.Empty;
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Console.WriteLine("\nExecutando o construtor parametrizado");
        this.Nome = nome;
        this.Idade = idade;
    }

    public Pessoa() { }

    static Pessoa()
    {
        Console.WriteLine("\nExecutando o construtor estatico");
        Console.WriteLine("\nInicializando o campo Idade Minima");
        IdadeMinima = 18;
    }
}
