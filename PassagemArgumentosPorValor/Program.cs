Console.WriteLine("Passagem de argumentos por valor e referencia");

int x = 20;
Console.WriteLine("\nValor do argumento x antes de passar por valor : " + x);

Calculo calc = new Calculo();
calc.Dobrar(ref x);
//calc.Dobrar(x);

Console.WriteLine("\nValor do argumento x depois de passar por valor : " + x);

public class Calculo
{
    public void Dobrar(ref int y)
    {
        y *= 2;
        Console.WriteLine("\nValor do parametrop y no metodo Dobrar " + y);
    }

    public void Dobrar(int y)
    {
        y *= 2;
        Console.WriteLine("\nValor do parametrop y no metodo Dobrar " + y);
    }
}
