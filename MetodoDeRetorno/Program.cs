Console.WriteLine("Metodos com retorno");

Calculadora calculadora = new Calculadora();

var valor1 = calculadora.Somar(1, 2);
Console.WriteLine(valor1);

var valor2 = calculadora.Subtrair(1, 2);
Console.WriteLine(valor2);

var valor3 = calculadora.Multiplicar(1, 2);
Console.WriteLine(valor3);

var valor4 = calculadora.Dividir(1, 2);
Console.WriteLine(valor4);

public class Calculadora
{
    public int Somar(int num1, int num2)
    {
        return num1 + num2;
    }
    
    public int Subtrair(int num1, int num2)
    {
        return num1 - num2;
    }
    
    public int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }
    
    public int Dividir(int num1, int num2)
    {
        return num1 / num2;
    }
}