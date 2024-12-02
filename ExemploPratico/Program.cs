using ExemploPratico;

Console.WriteLine("Dados do cliente");

Cadastro cadastro = new Cadastro();
Cliente cliente = new Cliente();

Cliente cliente1 = cadastro.Registrar();
Cliente cliente2 = cadastro.Registrar(cliente);

cadastro.ExibirDados(cliente1);
cadastro.ExibirDados("Um texto", cliente2);