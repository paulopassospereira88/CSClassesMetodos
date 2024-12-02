Console.WriteLine("Passagem argumentos por refencia usando OUT");

Console.WriteLine("Informe o raio do circulo");
double raio = Convert.ToDouble(Console.ReadLine());
Ciruculo circulo = new();

//double perimetro = ciruculo.CalculaPerimetro(raio);
//double area = ciruculo.CalculaArea(raio);

double circunferencia = circulo.CalculaAreaPerimetro(raio, out double area);

Console.WriteLine("Perimetro da circunferencia " + circunferencia);
Console.WriteLine("Area da circunferencia : " + area);

public class Ciruculo

{

    public double CalculaAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
    ////public double CalculaArea(double raio)
    ////{
    ////    double area = Math.PI * Math.Pow(raio, 2);
    ////    return area;
    ////}

    //public double CalculaPerimetro(double raio)
    //{
    //    double perimetro = 2 * Math.PI * raio;
    //    return perimetro;
    //}

}
