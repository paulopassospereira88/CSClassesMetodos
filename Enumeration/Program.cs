Console.WriteLine("## Enum ##\n");

Console.WriteLine(DiasDaSemana.Segunda);

int dia1 = (int)DiasDaSemana.Terca;
Console.WriteLine(dia1);

enum DiasDaSemana
{
    Segunda,
    Terca,
    Quarta,
    Quinta,
    Sexta,
    Sabado,
    Domingo
}
