Console.WriteLine("Assinatura de metodo - Sobrecarga\n");

Email email = new Email();
email.Enviar("teste@teste.com");
email.Enviar("teste@teste.com", "Teste");
email.Enviar("teste@teste.com", 1200.0);

public class Email
{
    public void Enviar(string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"Assunto Padrao");
    }

    public void Enviar(string endereco, string assunto)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{assunto}");
    }

    public void Enviar(string endereco, double valor)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"Proposta comercial");
        Console.WriteLine($"{valor}");
    }

}
