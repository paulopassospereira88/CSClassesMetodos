Console.WriteLine("## Divisao de numeros inteiros");

Console.WriteLine("\nInforme o valor de x ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nInforme o valor de y ");
int y = Convert.ToInt32(Console.ReadLine());

try
{
    int result = x / y;
    Console.WriteLine($"\n{x} / {y} = {result}");
}
catch (DivideByZeroException e)
{
    Console.WriteLine($"Erro: {e.Message}");
}
finally
{
    Console.WriteLine("Finalizando a execução do programa.");
}




