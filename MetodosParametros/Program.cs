Console.WriteLine("Metodos - Paramentos");

var aluno = new Aluno();

Console.WriteLine("Digite o nome do aluno: ");
aluno.Nome = Console.ReadLine();

Console.WriteLine("Digite a idade do aluno: ");
aluno.Idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o sexo do aluno: ");
aluno.Sexo = Console.ReadLine();

Console.WriteLine("Aprovado (s)sim (n)ao : ");
aluno.Aprovado = Console.ReadLine();

Curso curso = new Curso();
curso.Resultado(aluno);

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}

public class Curso
{
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"\nO aluno {aluno.Nome}, sexo {aluno.Sexo} com idade {aluno.Idade} anos");
        if (aluno.Aprovado == "s")
        {
            Console.WriteLine("\nFoi Aprovado");
        }
        else
        {
            Console.WriteLine("\nFoi Reprovado");
        }
    }
    
}