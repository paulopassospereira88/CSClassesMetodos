Console.WriteLine("Classes\n");

Pessoa p1 = new Pessoa();
p1.Nome = "Paulo";
p1.Idade = 35;
p1.Sexo = "Macho";

Console.WriteLine($"Nome {p1.Nome} tem idade {p1.Idade} sexo {p1.Sexo}\n");

Pessoa p2 = new Pessoa();
p2.Nome = "Paula";
p2.Idade = 35;
p2.Sexo = "Femea";

Console.WriteLine($"Nome {p2.Nome} tem idade {p2.Idade} sexo {p2.Sexo}\n");

Console.ReadKey();

class Pessoa
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
}
