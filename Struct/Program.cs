Console.WriteLine("## STRUCT ##\n");

Cliente cliente = new Cliente();

cliente.Nome = "Maria";
cliente.Idade = 40;
Console.WriteLine($"{cliente.Nome} {cliente.Idade}");

public struct Cliente
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Cliente(string? nome, int idade)
    {
        this.Nome = nome;
        this.Idade = idade;
    }
}
