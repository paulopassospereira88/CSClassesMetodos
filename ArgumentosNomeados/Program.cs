Console.WriteLine("Argumentos nomeados");


Email.Enviar(destino: "teste@teste.com", assunto: "teste com teste", titulo: "Urgnte");

public class Email
{
    public static void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"{destino}, {titulo} : {assunto}");
    }
}
