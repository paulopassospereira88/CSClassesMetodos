
var aluno = new
{
    Id = 1,
    Nome = "Paulo",
    Email = "teste@teste.com",
    Endereco = new
    {
        Id = 1,
        Cidade = "gyn",
        Pais = "BR"
    }
};

Console.WriteLine(aluno.Nome);
Console.WriteLine(aluno.Endereco.Cidade);

var alunos = new[]
{
    new {Id = 1, Nome = "Teste1", Email = "teste@teste.com" },
    new {Id = 2, Nome = "Teste2", Email = "teste@teste.com" },
    new {Id = 3, Nome = "Teste3", Email = "teste@teste.com" },
};

Console.WriteLine(alunos.First());
Console.WriteLine(alunos[1]);
