Console.WriteLine("Construtores 1");

Aluno aluno = new Aluno("Paulo", 35, "masculino", "SIM");

Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade == 0 ? "null" : aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    public Aluno (string nome, int idade, string sexo, string aprovado)
    {
        this.Nome = nome;
        this.Idade = idade;
        this.Sexo = sexo;
        this.Aprovado = aprovado;
    }

}